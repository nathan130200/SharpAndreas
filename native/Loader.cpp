#include <windows.h>
#include <filesystem>
#include <fstream>
#include <string>
#include <stdexcept>
#include <vector>
#include <nethost.h>
#include <hostfxr.h>
#include <coreclr_delegates.h>
#include "ScmBridge.h"
#include "TaskBridge.h"
#include "SdkBridge.h"
#include "RuntimeServices.h"
#include "WorldBridge.h"
#include "PathBridge.h"
#include "HudBridge.h"
#include "ServicesBridge.h"
#ifdef HOST_CHECK
#include "HostCheckEntities.h"
#endif
#ifndef HOST_CHECK
#include <list>
#include <Events.h>
#endif

namespace fs = std::filesystem;
namespace {
HMODULE module;
fs::path root;
using Entry = int(__cdecl*)(void*, int);
Entry entry = nullptr;
bool attempted = false, stopped = false;
void Log(const std::string& text) noexcept {
    WriteNativeLog(text);
}
void HOSTFXR_CALLTYPE HostError(const wchar_t* text) {
    try { auto utf8 = fs::path(text).u8string(); Log(std::string(reinterpret_cast<const char*>(utf8.data()), utf8.size())); } catch (...) { Log("hostfxr error"); }
}
#ifdef HOST_CHECK
int checkFrame=0;
#endif
int __cdecl KeyDown(int key) {
#ifdef HOST_CHECK
    return (key==0x47 && checkFrame>=90 && checkFrame<=92) || (key==0x46 && checkFrame>=150 && checkFrame<=152)
        || (key==0x78 && ((checkFrame>=220 && checkFrame<=222) || (checkFrame>=260 && checkFrame<=262) || (checkFrame>=295 && checkFrame<=297)))
        || (key==0x79 && checkFrame>=270 && checkFrame<=272);
#else
    return key >= 0 && key <= 255 && (GetAsyncKeyState(key) & 0x8000) != 0;
#endif
}
void __cdecl Help(const char* text) {
#ifndef HOST_CHECK
    // Plugin-SDK CHud::SetHelpMessage, supported SA 1.0 US executables only.
    reinterpret_cast<void(__cdecl*)(const char*, bool, bool, bool)>(0x588BE0)(text, true, false, false);
#else
    Log(text);
#endif
}
struct StartArgs {
    int size, version;
    const wchar_t* root;
    decltype(&KeyDown) keyDown;
    decltype(&Help) help;
    decltype(&InvokeScm) scm;
    decltype(&InvokeTaskBridge) tasks;
    decltype(&ResolveSdkBinding) sdk;
    decltype(&WritePluginLog) logger;
    decltype(&QueryGameState) state;
    decltype(&SetModOverlay) overlay;
    decltype(&InvokeWorldQuery) world;
    decltype(&InvokePathQuery) paths;
    decltype(&InvokeHudBridge) hud;
    decltype(&InvokeServices) services;
};
template<class T> T Symbol(HMODULE lib, const char* name) {
    auto fn = reinterpret_cast<T>(GetProcAddress(lib, name));
    if (!fn) throw std::runtime_error(std::string("Missing hostfxr export: ") + name);
    return fn;
}
void Check(int status, const char* operation) {
    if (status < 0) throw std::runtime_error(std::string(operation) + " failed: " + std::to_string(status));
}
void Start() {
    if (attempted || stopped) return;
    attempted = true;
    try {
        auto assembly = root / L"Runtime/SharpAndreas.Runtime.dll";
        auto config = root / L"Runtime/SharpAndreas.Runtime.runtimeconfig.json";
        auto localRuntime = root / L"Runtime/dotnet";
        get_hostfxr_parameters parameters{sizeof(parameters), assembly.c_str(),
            fs::exists(localRuntime) ? localRuntime.c_str() : nullptr};
        size_t length = 0;
        get_hostfxr_path(nullptr, &length, &parameters);
        if (!length) throw std::runtime_error("No x86 .NET runtime found. Install .NET 10 x86.");
        std::vector<wchar_t> buffer(length);
        Check(get_hostfxr_path(buffer.data(), &length, &parameters), "get_hostfxr_path");
        // Keep hostfxr loaded for the process lifetime, as required by its delegates.
        HMODULE fxr = LoadLibraryExW(buffer.data(), nullptr, LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR | LOAD_LIBRARY_SEARCH_DEFAULT_DIRS);
        if (!fxr) throw std::runtime_error("Cannot load x86 hostfxr: " + std::to_string(GetLastError()));
        auto init = Symbol<hostfxr_initialize_for_runtime_config_fn>(fxr, "hostfxr_initialize_for_runtime_config");
        auto get = Symbol<hostfxr_get_runtime_delegate_fn>(fxr, "hostfxr_get_runtime_delegate");
        auto close = Symbol<hostfxr_close_fn>(fxr, "hostfxr_close");
        auto setError = Symbol<hostfxr_set_error_writer_fn>(fxr, "hostfxr_set_error_writer");
        auto previousError = setError(HostError);
        hostfxr_handle context = nullptr;
        hostfxr_initialize_parameters initParameters{sizeof(initParameters), assembly.c_str(),
            fs::exists(localRuntime) ? localRuntime.c_str() : nullptr};
        int status = init(config.c_str(), &initParameters, &context);
        void* delegate = nullptr;
        if (status >= 0 && context) status = get(context, hdt_load_assembly_and_get_function_pointer, &delegate);
        if (context) close(context);
        setError(previousError);
        Check(status, "Initialize .NET");
        if (!delegate) throw std::runtime_error("hostfxr returned no assembly loader");
        void* method = nullptr;
        Check(reinterpret_cast<load_assembly_and_get_function_pointer_fn>(delegate)(assembly.c_str(),
            L"SharpAndreas.Runtime.Bootstrap, SharpAndreas.Runtime", L"Dispatch",
            UNMANAGEDCALLERSONLY_METHOD, nullptr, &method), "Load managed entry point");
        auto candidate = reinterpret_cast<Entry>(method);
        std::wstring rootText = root.wstring();
        StartArgs args{sizeof(StartArgs), 10, rootText.c_str(), KeyDown, Help, InvokeScm, InvokeTaskBridge, ResolveSdkBinding, WritePluginLog, QueryGameState, SetModOverlay, InvokeWorldQuery, InvokePathQuery, InvokeHudBridge, InvokeServices};
        Check(candidate(&args, 0), "Start managed loader");
        entry = candidate;
        Log("CoreCLR initialized (x86).");
    } catch (const std::exception& ex) { Log(ex.what()); }
}
void Tick() {
    Start();
    if (entry && entry(nullptr, 1) < 0) { Log("Managed dispatcher failed; shutting down managed mods."); entry(nullptr,2);entry = nullptr; }
    if(!QueryGameState(0))TickTaskCheckBackend();
}
void Stop() {
    if (stopped) return;
    stopped = true;
    if (entry) { entry(nullptr, 2); entry = nullptr; }
}
}

void DrawManagedMods() noexcept {
    if(!entry || stopped)return;
    try {Check(entry(nullptr,3),"Draw managed mods");}catch(const std::exception& ex){Log(ex.what());}catch(...){Log("Managed drawing callback failed.");}
}

#ifdef HOST_CHECK
int wmain(int argc, wchar_t** argv) {
    if (argc != 2) return 2;
    root = fs::absolute(argv[1]);
    SetPluginDataRoot(root.c_str());
    Tick(); // Runtime and mod JIT startup is intentionally excluded from the frame check.
    ULONGLONG longest = 0;
    for (int i = 1; i < 320; ++i) {
        checkFrame=i;
        SetCheckPaused(i>=40 && i<70);
        if(i==100 && fs::exists(root/L"snapshots/replacement.dll")) {
            fs::copy_file(root/L"snapshots/replacement.dll",root/L"Mods/HotReload/HotReload.dll",fs::copy_options::overwrite_existing);
            fs::copy_file(root/L"snapshots/replacement.mod.tml",root/L"Mods/HotReload/mod.tml",fs::copy_options::overwrite_existing);
        }
        if(i==200 && fs::exists(root/L"snapshots/manifest-only.mod.tml"))
            fs::copy_file(root/L"snapshots/manifest-only.mod.tml",root/L"Mods/ManifestFolder/mod.tml",fs::copy_options::overwrite_existing);
        auto start = GetTickCount64();
        Tick();
        DrawManagedMods();
        DrawProfilerOverlay();
        auto elapsed = GetTickCount64() - start;
        if (elapsed > longest) longest = elapsed;
        Sleep(5); // Simulated frames; never used in the ASI's game callback.
    }
    Stop();
    TickTaskCheckBackend(); // Verify detached managed proxies can finish after script teardown.
    Log("Max frame dispatch ms: " + std::to_string(longest));
    if (longest >= 500) return 3;
    HudArgs hud{};
    if(InvokeHudBridge(13,0,0,&hud)!=0)return 4;
    for(uint32_t operation: {6u,7u,8u})if(InvokeHudBridge(14,0,operation,&hud)<=0)return 5;
    Log("HUD TEXTURES RELEASED; BOTH DRAW PATHS EXECUTED");
    if(QueryGameState(2)!=0 || CheckDynamicVehicleCount()!=0 || CheckDynamicPedCount()!=0)return 6;
    Log("RACE RESOURCES AND SCM ONMISSION CLEARED");
    if(CheckServiceHandleCount()!=0)return 7;
    Log("SERVICE HANDLES RELEASED");
    return attempted && fs::exists(root / L"plugin.log") ? 0 : 1;
}
#else
struct Plugin {
    Plugin() {
        wchar_t path[32768];
        if (!GetModuleHandleExW(GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS | GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT,
            reinterpret_cast<LPCWSTR>(&KeyDown), &module)) return;
        DWORD length = GetModuleFileNameW(module, path, 32768);
        if (!length || length == 32768) return;
        length=GetModuleFileNameW(nullptr,path,32768);
        if(!length || length==32768)return;
        root = fs::path(path).parent_path()/L"SharpAndreas";
        try {SetPluginDataRoot(root.c_str());}catch(...) {OutputDebugStringW(L"Cannot create SharpAndreas data directory");return;}
        // Guard before registering the SDK's fixed-address game hooks.
        auto image = reinterpret_cast<const unsigned char*>(GetModuleHandleW(nullptr));
        auto dos = reinterpret_cast<const IMAGE_DOS_HEADER*>(image);
        auto nt = reinterpret_cast<const IMAGE_NT_HEADERS*>(image + dos->e_lfanew);
        if (reinterpret_cast<uintptr_t>(image) != 0x400000 || nt->OptionalHeader.SizeOfImage < 0x429000) {
            Log("Unsupported executable image."); return;
        }
        DWORD signature = *reinterpret_cast<const DWORD*>(0x401000);
        if (signature != 0x53EC8B55 && signature != 0x16197BE9) {
            Log("Supported: GTA SA 1.0 US Compact / Hoodlum only."); return;
        }
        plugin::Events::gameProcessEvent += Tick;
        plugin::Events::shutdownRwEvent += Stop;
        plugin::Events::drawHudEvent += DrawProfilerOverlay;
        plugin::Events::drawAfterFadeEvent += [] {DrawManagedMods();DrawModOverlay();};
    }
} pluginInstance;
// No CoreCLR startup or shutdown under DllMain's loader lock.
BOOL WINAPI DllMain(HINSTANCE, DWORD, LPVOID) { return TRUE; }
#endif

