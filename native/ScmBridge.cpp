#include "ScmBridge.h"
#ifdef HOST_CHECK
#include "HostCheckEntities.h"
#include "RuntimeServices.h"
#endif
#include <array>
#include <cstring>
#include <vector>
#include <map>
#include <set>
#ifndef HOST_CHECK
#include <CRunningScript.h>
#endif

#ifdef HOST_CHECK
namespace {std::set<int> servicePickups,serviceDecisions,serviceBlips,serviceSpheres,serviceMarkers;}
int CheckServiceHandleCount() {return static_cast<int>(servicePickups.size()+serviceDecisions.size()+serviceBlips.size()+serviceSpheres.size()+serviceMarkers.size());}
#endif
namespace {
// A temporary CRunningScript has no durable instruction pointer or registered lifetime.
// Block commands which suspend, branch, retain bytecode pointers, or control that thread.
bool IsCallable(uint16_t opcode) {
    opcode &= 0x7FFF;
    if (opcode > 0x0A50) return false; // Stock interpreter, not a CLEO dispatcher.
    switch (opcode) {
    case 0x0001: case 0x0002: case 0x004C: case 0x004D: case 0x004E: case 0x004F:
    case 0x0050: case 0x0051: case 0x00C5: case 0x00C6: case 0x00CD: case 0x00CE:
    case 0x00D3: case 0x00D4: case 0x00D5: case 0x00D6: case 0x00D7: case 0x02A1:
    case 0x02CD: case 0x0700: case 0x0701: case 0x0707: case 0x0871: case 0x0872:
    case 0x0913: return false;
    default: return true;
    }
}
struct Parameter { uint8_t type; int32_t bits; };
// Validate the transport representation independently of the game interpreter.
bool Decode(const uint8_t* code, int size, int localCount, std::vector<Parameter>& params) {
    int cursor = 2;
    while (cursor < size) {
        uint8_t type = code[cursor++];
        if (type == 0) return cursor == size;
        int bytes;
        switch (type) {
        case 1: case 6: bytes = 4; break;
        case 3: bytes = 2; break;
        case 9: bytes = 8; break;
        case 14:
            if (cursor >= size) return false;
            bytes = code[cursor++]; break;
        default: return false;
        }
        if (cursor + bytes >= size || params.size() >= 64) return false;
        int32_t value = 0;
        if (type == 1 || type == 6) std::memcpy(&value, code + cursor, 4);
        if (type == 3) {
            uint16_t index; std::memcpy(&index, code + cursor, 2);
            if (index >= localCount) return false;
            value = index;
        }
        params.push_back({type, value});
        cursor += bytes;
    }
    return false;
}
}

int __cdecl InvokeScm(const uint8_t* code, int codeSize, int32_t* locals, int localCount, int* condition) {
    if (!code || !locals || !condition || codeSize < 3 || codeSize > 4096 || localCount < 0 || localCount > 32) return -1;
    uint16_t opcode; std::memcpy(&opcode, code, 2);
    if (!IsCallable(opcode)) return -2;
    std::vector<Parameter> params;
    if (!Decode(code, codeSize, localCount, params)) return -1;
#ifndef HOST_CHECK
    // Use Plugin-SDK's real layout and game entry points; never retain this temporary script.
    CRunningScript script{};
    // CRunningScript::Init and ProcessOneCommand, verified against the installed SDK.
    // Calling the two wrappers directly avoids linking every CRunningScript static initializer.
    plugin::CallMethod<0x4648E0>(&script);
    std::strcpy(script.m_szName, "net-mod");
    std::array<uint8_t, 4096> buffer{};
    std::memcpy(buffer.data(), code, codeSize);
    script.m_pBaseIP = script.m_pCurrentIP = buffer.data();
    for (int i = 0; i < localCount; ++i) script.m_aLocalVars[i].iParam = locals[i];
    plugin::CallMethod<0x469EB0>(&script);
    for (int i = 0; i < localCount; ++i) locals[i] = script.m_aLocalVars[i].iParam;
    *condition = script.m_bCondResult ? 1 : 0;
#else
    // Deterministic host-check backend. Actual opcode execution must be checked in GTA.
    auto input = [&](size_t i) { return params.at(i).type == 3 ? locals[params.at(i).bits] : params.at(i).bits; };
    auto output = [&](size_t i, int32_t value) { if (params.at(i).type != 3) throw 0; locals[params.at(i).bits] = value; };
    bool result = false;
    static std::map<int,std::set<int>> groups{{10,{42}}};
    static std::map<int,int> leaders{{10,42}};
    static int nextGroup=11;
    static int passengerVehicle=-1, passengerEntries=0, passengerExits=0;
    struct MockEntity {int model;float x,y,z;int health;float tx=0,ty=0,tz=0;bool driving=false;};
    struct MockPoint {float x,y,z;};
    static std::map<int,MockEntity> raceCars,racePeds;
    static std::map<int,int> inCar;
    static std::map<int,MockPoint> checkpoints;
    static int nextEntity=1000,nextCheckpoint=10000,raceStarts=0;
    auto real=[&](size_t i) {int32_t bits=input(i);float value;std::memcpy(&value,&bits,4);return value;};

    try {
        switch (opcode & 0x7FFF) {
        case 0x0000: break;
        case 0x07E5:case 0x07E6:case 0x060A:case 0x06AE: {int id=++nextEntity;serviceDecisions.insert(id);output(1,id);break;}
        case 0x09F2:result=serviceDecisions.count(input(0));break;
        case 0x065C:serviceDecisions.erase(input(0));break;
        case 0x060B:case 0x06AD:break;
        case 0x0213:case 0x032B: {int id=++nextEntity;servicePickups.insert(id);RegisterCheckPickup(id,input(0),input(1));output((opcode&0x7FFF)==0x0213?5:6,id);break;}
        case 0x09D1:result=servicePickups.count(input(0));break;
        case 0x0214:result=false;break;
        case 0x0215:servicePickups.erase(input(0));RemoveCheckPickup(input(0));break;
        case 0x065B:for(int i=1;i<=3;i++){float v=static_cast<float>(i);int bits;std::memcpy(&bits,&v,4);output(i,bits);}break;
        case 0x075C:result=serviceBlips.count(input(0));break;
        case 0x0186:case 0x0187:case 0x0188: {int id=++nextCheckpoint;serviceBlips.insert(id);output(1,id);break;}
        case 0x03BC: {int id=++nextEntity;serviceSpheres.insert(id);output(4,id);break;}
        case 0x03BD:serviceSpheres.erase(input(0));break;
        case 0x0A40: {int id=++nextEntity;serviceMarkers.insert(id);output(4,id);break;}
        case 0x0A41:serviceMarkers.erase(input(0));break;
        case 0x0323:case 0x02D3:case 0x02DB:case 0x02D4:case 0x03A1:case 0x018B:
        case 0x0109:case 0x010D:case 0x0110:case 0x0A30:case 0x04BA:case 0x0918:case 0x0229:
        case 0x01E7:case 0x01E8:case 0x022A:case 0x022B:case 0x091D:case 0x091E:
        case 0x015F:case 0x0160:case 0x015A:case 0x02EB:case 0x0373:case 0x0003:case 0x016A:case 0x0169:
        case 0x018C:case 0x075E:case 0x0790:case 0x087C:case 0x0950:case 0x09AF:case 0x0951:
        case 0x04ED:case 0x04EF:case 0x0776:case 0x0777:case 0x0778:case 0x04E4:case 0x07C0:case 0x0873:
        case 0x01B5:case 0x01B6:case 0x01B7:case 0x08FD:case 0x0915:
        case 0x0629:case 0x062A:case 0x0623:case 0x0624:case 0x0A10:case 0x0A1F:break;
        case 0x010B:output(1,500);break;
        case 0x01C0:output(1,2);break;
        case 0x01E9:output(1,1);break;
        case 0x02E3: {float value=12.5f;int bits;std::memcpy(&bits,&value,4);output(1,bits);break;}
        case 0x06A2:for(int i=1;i<=3;i++)output(i,0);break;
        case 0x068D:case 0x068E:for(int i=0;i<3;i++)output(i,0);break;
        case 0x02CE: {float value=13.5f;int bits;std::memcpy(&bits,&value,4);output(3,bits);break;}
        case 0x075F:output(0,3);break;
        case 0x0760:output(1,100+input(0));break;
        case 0x0761:output(1,50);break;
        case 0x0942:case 0x04EE:case 0x07C1:result=true;break;
        case 0x0A36:result=false;break;
        case 0x0652:output(1,7);break;
        case 0x0653: {float value=2.5f;int bits;std::memcpy(&bits,&value,4);output(1,bits);break;}

        case 0x0006: case 0x0007: output(0, input(1)); break;
        case 0x0615: output(0,99); break;
        case 0x0616: case 0x0618: case 0x0643: case 0x061B: break;
        case 0x0646: output(1,0); break;
        case 0x05B9: case 0x05BA: case 0x05D3: case 0x05DE: case 0x05C4: case 0x0687: case 0x0792: break;
        case 0x09E7: result=input(0)==0; break;
        case 0x01B4: break;
        case 0x01BD: output(0,QueryGameState(5));break;
        case 0x00DF: result=inCar.count(input(0)) || (input(0)==42 && passengerVehicle>=0);break;
        case 0x00D9: output(1,inCar.count(input(0))?inCar[input(0)]:passengerVehicle);break;
        case 0x01EA: output(1,3);break;
        case 0x0431: result=input(1)==1 || input(1)==2;break; // Front passenger occupied.
        case 0x05CA:
            if(input(0)!=42 || input(1)!=42 || input(2)!=10000 || input(3)!=1 || ++passengerEntries!=1)return -1;
            passengerVehicle=input(1);break;
        case 0x05CD:
            if(input(0)!=42 || input(1)!=passengerVehicle || ++passengerExits!=1)return -1;
            passengerVehicle=-1;break;
        case 0x0256: result = input(0) == 0; break;
        case 0x01F5: output(1, 42); break;
        case 0x056D: result = (input(0)>=42 && input(0)<=44) || input(0)==556 || input(0)==813 || racePeds.count(input(0)); break;
        case 0x056E: result = input(0)==42 || (input(0)>=104 && input(0)<=108) || input(0)==556 || input(0)==813 || raceCars.count(input(0)); break;
        case 0x03CA: result = input(0)==42 || input(0)==556 || input(0)==813; break;
        case 0x07AF: output(1,10); break;
        case 0x062F: groups[++nextGroup]={};output(1,nextGroup);break;
        case 0x0630: leaders[input(0)]=input(1);groups[input(0)].insert(input(1));break;
        case 0x0631: groups[input(0)].insert(input(1));break;
        case 0x0632: groups.erase(input(0));leaders.erase(input(0));break;
        case 0x07FD: result=groups.count(input(0))!=0;break;
        case 0x06EE: result=groups.count(input(1)) && groups[input(1)].count(input(0));break;
        case 0x06EF: result=leaders.count(input(1)) && leaders[input(1)]==input(0);break;
        case 0x06C9: for(auto& group:groups)group.second.erase(input(0));break;
        case 0x084F: output(1,leaders.count(input(0))?leaders[input(0)]:-1);break;
        case 0x07F6: output(1,leaders.count(input(0))?1:0);output(2,static_cast<int>(groups[input(0)].size())-(leaders.count(input(0))?1:0));break;
        case 0x0226: output(1,racePeds.count(input(0))?racePeds[input(0)].health:100);break;
        case 0x0227: output(1,raceCars.count(input(0))?raceCars[input(0)].health:100);break;
        case 0x0224: if(raceCars.count(input(0)))raceCars[input(0)].health=input(1);break;
        case 0x0175: break;
        case 0x0247: case 0x0249: break;
        case 0x0248: result=true;break;
        case 0x009A: {
            int id=++nextEntity;racePeds[id]={input(1),real(2),real(3),real(4),100};RegisterCheckPed(id,input(1),input(0));output(5,id);break;
        }
        case 0x00A5: {
            int id=++nextEntity;raceCars[id]={input(0),real(1),real(2),real(3),1000};RegisterCheckVehicle(id,input(0));output(4,id);break;
        }
        case 0x009B: racePeds.erase(input(0));inCar.erase(input(0));RemoveCheckPed(input(0));break;
        case 0x00A6: {
            int id=input(0);raceCars.erase(id);RemoveCheckVehicle(id);
            for(auto it=inCar.begin();it!=inCar.end();)if(it->second==id)it=inCar.erase(it);else ++it;
            if(passengerVehicle==id)passengerVehicle=-1;break;
        }
        case 0x036A: case 0x072A:
            inCar[input(0)]=input(1);if(input(0)==42){passengerVehicle=input(1);raceStarts++;}break;
        case 0x0362: inCar.erase(input(0));if(input(0)==42)passengerVehicle=-1;break;
        case 0x05D1: {
            if(raceCars.count(input(1))) {auto& car=raceCars[input(1)];car.tx=real(2);car.ty=real(3);car.tz=real(4);car.driving=true;}break;
        }
        case 0x06D5: {int id=++nextCheckpoint;checkpoints[id]={real(1),real(2),real(3)};output(8,id);break;}
        case 0x06D6: checkpoints.erase(input(0));break;
        case 0x018A: {int id=++nextCheckpoint;serviceBlips.insert(id);output(3,id);break;}
        case 0x0164: serviceBlips.erase(input(0));break;
        case 0x0165: case 0x0168: break;
        case 0x0665: output(1, 7); break;
        case 0x00A0: case 0x00AA: case 0x01BB: {
            float x = 1, y = 2, z = 3;
            if((opcode&0x7FFF)==0x00AA && raceCars.count(input(0))) {
                auto& car=raceCars[input(0)];
                if(raceStarts==1 && input(0)==passengerVehicle && !checkpoints.empty()) {auto& point=checkpoints.begin()->second;car.x=point.x;car.y=point.y;car.z=point.z;}
                else if(car.driving) {car.x+=(car.tx-car.x)*0.2f;car.y+=(car.ty-car.y)*0.2f;car.z+=(car.tz-car.z)*0.2f;}
                x=car.x;y=car.y;z=car.z;
            }
            if((opcode&0x7FFF)==0x00A0 && racePeds.count(input(0))) {auto& ped=racePeds[input(0)];x=ped.x;y=ped.y;z=ped.z;}
            int32_t bits;
            std::memcpy(&bits, &x, 4); output(1, bits);
            std::memcpy(&bits, &y, 4); output(2, bits);
            std::memcpy(&bits, &z, 4); output(3, bits); break;
        }
        default: return -3;
        }
    } catch (...) { return -1; }
    *condition = result != ((opcode & 0x8000) != 0);
#endif
    return 0;
}
