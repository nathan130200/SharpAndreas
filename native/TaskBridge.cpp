#include "TaskBridge.h"
#include <CTask.h>
#include <CTaskSimple.h>
#include <CTaskComplex.h>
#ifndef HOST_CHECK
#include <CPed.h>
#include <CTaskSimpleStandStill.h>
#include <CTaskComplexWanderStandard.h>
#endif
#include <memory>
#include <unordered_map>
#include <vector>
#include <new>
#include <cstring>

namespace {
struct Owner { ManagedTaskCallback callback; bool active = true; };
struct Entry { CTask* task; uint32_t owner; bool owned; bool proxy; };
std::unordered_map<uint32_t, std::shared_ptr<Owner>> owners;
std::unordered_map<uint32_t, Entry> entries;
uint32_t nextId = 0;
uint32_t Id() { return nextId < INT32_MAX ? ++nextId : 0; }
void* Allocate(size_t size) {
#ifdef HOST_CHECK
    return ::operator new(size, std::nothrow);
#else
    return reinterpret_cast<void*(__cdecl*)(unsigned int)>(0x61A5A0)(static_cast<unsigned int>(size));
#endif
}
void Free(void* pointer) {
#ifdef HOST_CHECK
    ::operator delete(pointer);
#else
    reinterpret_cast<void(__cdecl*)(void*)>(0x61A5B0)(pointer);
#endif
}
int PedHandle(CPed* ped) {
#ifdef HOST_CHECK
    return ped ? 42 : -1;
#else
    return ped ? reinterpret_cast<int(__cdecl*)(CPed*)>(0x54FF60)(ped) : -1;
#endif
}
// Derive from the SDK classes themselves; GTA dispatches their genuine MSVC task vtables.
struct SimpleAbi : CTaskSimple {
    SimpleAbi() : CTaskSimple(plugin::dummy) { m_pParentTask=nullptr; }
    virtual bool ProcessPed(CPed*) override = 0;
    virtual bool SetPedPosition(CPed*) override = 0;
    static void operator delete(void* p) { Free(p); }
};
struct ComplexAbi : CTaskComplex {
    ComplexAbi() : CTaskComplex(plugin::dummy) { m_pParentTask=nullptr; m_pSubTask=nullptr; }
    virtual void SetSubTask(CTask*) override = 0;
    virtual CTask* CreateNextSubTask(CPed*) override = 0;
    virtual CTask* CreateFirstSubTask(CPed*) override = 0;
    virtual CTask* ControlSubTask(CPed*) override = 0;
    static void operator delete(void* p) { Free(p); }
};
static_assert(sizeof(SimpleAbi) == sizeof(CTaskSimple));
static_assert(sizeof(ComplexAbi) == sizeof(CTaskComplex));
struct CompletedTask final : SimpleAbi {
    CTask* Clone() override {
        auto memory = Allocate(sizeof(CompletedTask));
        return memory ? reinterpret_cast<CTask*>(::new(memory) CompletedTask()) : nullptr;
    }
    CTask* GetSubTask() override { return nullptr; }
    bool IsSimple() override { return true; }
    eTaskType GetId() override { return TASK_NONE; }
    void StopTimer(CEvent*) override {}
    bool MakeAbortable(CPed*, eAbortPriority, CEvent*) override { return true; }
    bool ProcessPed(CPed*) override { return true; }
    bool SetPedPosition(CPed*) override { return false; }
};
CTask* Complete() {
    auto memory=Allocate(sizeof(CompletedTask));
    return memory ? reinterpret_cast<CTask*>(::new(memory) CompletedTask()) : nullptr;
}
CTask* Consume(uint32_t owner, uint32_t id) {
    auto it = entries.find(id);
    if (it == entries.end() || it->second.owner != owner || !it->second.owned) return nullptr;
    CTask* task = it->second.task;
    if (it->second.proxy) it->second.owned = false;
    else entries.erase(it);
    return task;
}
CTask* CreateProxy(uint32_t owner, uint32_t id, int kind, int type, bool owned);
struct State {
    uint32_t owner, id;
    int type;
    std::shared_ptr<Owner> host;
    State(uint32_t o, uint32_t i, int t) : owner(o), id(i), type(t), host(owners.at(o)) {}
    intptr_t Call(int event, CPed* ped = nullptr, int arg = 0, intptr_t data = 0) {
        return host->active ? host->callback(id, event, PedHandle(ped), arg, data) : 0;
    }
    CTask* Clone(int kind) {
        if (!host->active) return Complete();
        uint32_t cloneId = Id();
        if (!cloneId) return nullptr;
        auto clone = CreateProxy(owner, cloneId, kind, type, false);
        if (!clone) return nullptr;
        if (host->active && !Call(4, nullptr, 0, cloneId)) { delete clone; return Complete(); }
        return clone;
    }
    void Destroy() { Call(5); entries.erase(id); }
};
struct SimpleProxy final : SimpleAbi {
    State state;
    SimpleProxy(uint32_t o, uint32_t i, int t) : state(o,i,t) {}
    ~SimpleProxy() override { state.Destroy(); }
    CTask* Clone() override { return state.Clone(10); }
    CTask* GetSubTask() override { return nullptr; }
    bool IsSimple() override { return true; }
    eTaskType GetId() override { return static_cast<eTaskType>(state.type); }
    void StopTimer(CEvent* event) override { state.Call(3, nullptr, 0, reinterpret_cast<intptr_t>(event)); }
    bool MakeAbortable(CPed* ped, eAbortPriority priority, CEvent* event) override {
        return !state.host->active || state.Call(2, ped, static_cast<int>(priority), reinterpret_cast<intptr_t>(event)) != 0;
    }
    bool ProcessPed(CPed* ped) override { return !state.host->active || state.Call(0, ped) != 0; }
    bool SetPedPosition(CPed* ped) override { return state.Call(1, ped) != 0; }
};
struct ComplexProxy final : ComplexAbi {
    State state;
    ComplexProxy(uint32_t o, uint32_t i, int t) : state(o,i,t) {}
    ~ComplexProxy() override { delete m_pSubTask; m_pSubTask = nullptr; state.Destroy(); }
    CTask* Clone() override { return state.Clone(11); }
    CTask* GetSubTask() override { return m_pSubTask; }
    bool IsSimple() override { return false; }
    eTaskType GetId() override { return static_cast<eTaskType>(state.type); }
    void StopTimer(CEvent* event) override { state.Call(3, nullptr, 0, reinterpret_cast<intptr_t>(event)); }
    bool MakeAbortable(CPed* ped, eAbortPriority priority, CEvent* event) override {
        if (!state.host->active) return true;
        return state.Call(2,ped,static_cast<int>(priority),reinterpret_cast<intptr_t>(event)) != 0 && (!m_pSubTask || m_pSubTask->MakeAbortable(ped,priority,event));
    }
    void SetSubTask(CTask* task) override {
        if (task == m_pSubTask) return;
        delete m_pSubTask; m_pSubTask = task;
        if (task) task->m_pParentTask = reinterpret_cast<CTask*>(this);
    }
    CTask* Child(int event, CPed* ped) { return Consume(state.owner, static_cast<uint32_t>(state.Call(event,ped))); }
    CTask* CreateNextSubTask(CPed* ped) override { return Child(7,ped); }
    CTask* CreateFirstSubTask(CPed* ped) override { return Child(6,ped); }
    CTask* ControlSubTask(CPed* ped) override {
        auto choice = state.Call(8,ped,0,reinterpret_cast<intptr_t>(m_pSubTask));
        return choice == -1 ? m_pSubTask : Consume(state.owner, static_cast<uint32_t>(choice));
    }
};
CTask* CreateProxy(uint32_t owner, uint32_t id, int kind, int type, bool owned) {
    void* memory = Allocate(kind == 10 ? sizeof(SimpleProxy) : sizeof(ComplexProxy));
    if (!memory) return nullptr;
    auto task = kind == 10 ? reinterpret_cast<CTask*>(::new(memory) SimpleProxy(owner,id,type)) : reinterpret_cast<CTask*>(::new(memory) ComplexProxy(owner,id,type));
    entries.emplace(id, Entry{task,owner,owned,true});
    return task;
}
#ifdef HOST_CHECK
std::vector<CTask*> checkTasks;
struct CheckStandStill final : SimpleAbi {
    int ticks = 2;
    CTask* Clone() override { void* p = Allocate(sizeof(CheckStandStill)); return p ? reinterpret_cast<CTask*>(::new(p) CheckStandStill()) : nullptr; }
    CTask* GetSubTask() override { return nullptr; }
    bool IsSimple() override { return true; }
    eTaskType GetId() override { return TASK_SIMPLE_STAND_STILL; }
    void StopTimer(CEvent*) override {}
    bool MakeAbortable(CPed*, eAbortPriority, CEvent*) override { return true; }
    bool ProcessPed(CPed*) override { return --ticks <= 0; }
    bool SetPedPosition(CPed*) override { return false; }
};
bool ProcessCheck(CTask* task, CPed* ped) {
    if (task->IsSimple()) return reinterpret_cast<SimpleAbi*>(task)->ProcessPed(ped);
    auto complex = reinterpret_cast<ComplexAbi*>(task);
    if (!complex->m_pSubTask) complex->SetSubTask(complex->CreateFirstSubTask(ped));
    else {
        auto controlled = complex->ControlSubTask(ped);
        if (controlled != complex->m_pSubTask) complex->SetSubTask(controlled);
    }
    if (!complex->m_pSubTask) return true;
    if (ProcessCheck(complex->m_pSubTask,ped)) {
        auto next = complex->CreateNextSubTask(ped);
        complex->SetSubTask(next);
    }
    return !complex->m_pSubTask;
}
#endif
}

intptr_t __cdecl InvokeTaskBridge(int op, uint32_t owner, uint32_t id, int arg, intptr_t data, int count) {
    try {
        if (op == 0) {
            if (!owner || !data || owners.count(owner)) return 0;
            owners[owner] = std::make_shared<Owner>(Owner{reinterpret_cast<ManagedTaskCallback>(data)});
            return 1;
        }
        auto host = owners.find(owner);
        if (host == owners.end() || !host->second->active) return 0;
        if (op == 4) {
            host->second->active = false; // Disable callbacks before managed references are released.
            std::vector<uint32_t> pending;
            for (const auto& pair : entries) if (pair.second.owner == owner && pair.second.owned) pending.push_back(pair.first);
            for (auto token : pending) {
                auto it = entries.find(token); if (it == entries.end()) continue;
                auto task = it->second.task; entries.erase(it); delete task;
            }
            owners.erase(host);
            return 1;
        }
        if (op == 1) {
            auto values = reinterpret_cast<const int*>(data);
            uint32_t token = Id(); if (!token) return 0;
            if ((arg == 10 || arg == 11) && values && count == 1) return CreateProxy(owner,token,arg,values[0],true) ? token : 0;
            CTask* task = nullptr;
#ifdef HOST_CHECK
            if (arg == 0 || arg == 1) { auto p = Allocate(sizeof(CheckStandStill)); if (p) task = reinterpret_cast<CTask*>(::new(p) CheckStandStill()); }
#else
            if (arg == 0 && values && count == 4) {
                task = reinterpret_cast<CTask*>(Allocate(sizeof(CTaskSimpleStandStill)));
                float blend; std::memcpy(&blend, values+3,4);
                if (task) plugin::CallMethod<0x62F310>(reinterpret_cast<CTaskSimpleStandStill*>(task),values[0],values[1]!=0,values[2]!=0,blend);
            }
            if (arg == 1 && values && count == 3) {
                task = reinterpret_cast<CTask*>(Allocate(sizeof(CTaskComplexWanderStandard)));
                if (task) plugin::CallMethod<0x48E4F0>(reinterpret_cast<CTaskComplexWanderStandard*>(task),values[0],static_cast<unsigned char>(values[1]),values[2]!=0);
            }
#endif
            if (!task) return 0;
            entries.emplace(token,Entry{task,owner,true,false}); return token;
        }
        auto entry = entries.find(id);
        if (entry == entries.end() || entry->second.owner != owner || !entry->second.owned) return 0;
        if (op == 3) { auto task=entry->second.task; entries.erase(entry); delete task; return 1; }
        if (op == 2 && data && count == 2) {
            auto options = reinterpret_cast<const int*>(data);
            if (options[0] < 0 || options[0] >= (options[1] ? 6 : 5)) return 0;
#ifdef HOST_CHECK
            if (arg != 42) return 0;
            checkTasks.push_back(Consume(owner,id));
#else
            auto ped = reinterpret_cast<CPed*(__cdecl*)(int)>(0x54FF90)(arg);
            if (!ped || !ped->m_pIntelligence) return 0;
            auto task = Consume(owner,id);
            auto manager = &ped->m_pIntelligence->m_TaskMgr;
            if (options[1]) plugin::CallMethod<0x681B60>(manager,task,options[0]);
            else plugin::CallMethod<0x681AF0>(manager,task,options[0],false);
#endif
            return 1;
        }
        if (op == 9) {
            auto clone=entry->second.task->Clone();
            if (!clone) return 0;
            for (auto& item : entries) if (item.second.task==clone) { item.second.owned=true; return item.first; }
            auto token=Id(); if (!token) { delete clone; return 0; }
            entries.emplace(token,Entry{clone,owner,true,false}); return token;
        }
        return 0;
    } catch (...) { return 0; }
}
void TickTaskCheckBackend() {
#ifdef HOST_CHECK
    for (size_t i=0;i<checkTasks.size();) {
        auto task=checkTasks[i];
        if (ProcessCheck(task,reinterpret_cast<CPed*>(1))) { checkTasks.erase(checkTasks.begin()+i); delete task; }
        else ++i;
    }
#endif
}

