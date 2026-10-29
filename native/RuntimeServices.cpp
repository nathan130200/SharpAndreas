#include <windows.h>
#include "RuntimeServices.h"
#include "HudBridge.h"
#include <filesystem>
#include <mutex>
#include <sstream>
#include <cstdio>
#include <array>
#include <cstring>
#ifndef HOST_CHECK
#include <CMenuManager.h>
#include <CTimer.h>
#include <CTheScripts.h>
#include <CFont.h>
#include <RenderWare.h>
#endif
namespace {
std::filesystem::path logPath;
std::mutex logMutex;
std::wstring modText,profilerText;
bool checkPaused=false,checkMission=false;
unsigned int checkGameTime=0;
std::string Utf8(const wchar_t* text) {
    if(!text || !*text)return {};
    int length=WideCharToMultiByte(CP_UTF8,0,text,-1,nullptr,0,nullptr,nullptr);
    std::string result(length,'\0');WideCharToMultiByte(CP_UTF8,0,text,-1,result.data(),length,nullptr,nullptr);result.pop_back();return result;
}
}
void SetPluginDataRoot(const wchar_t* path) {
    std::filesystem::create_directories(path);
    logPath=std::filesystem::path(path)/L"plugin.log";
}
void __cdecl WritePluginLog(const wchar_t* script,const wchar_t* message) noexcept {
    try {
        SYSTEMTIME now;GetLocalTime(&now);
        char stamp[64];std::snprintf(stamp,sizeof(stamp),"[%04u-%02u-%02u %02u:%02u:%02u.%03u] ",now.wYear,now.wMonth,now.wDay,now.wHour,now.wMinute,now.wSecond,now.wMilliseconds);
        std::string prefix=std::string(stamp)+"["+Utf8(script)+"] [";
        std::string text=Utf8(message),record;
        std::istringstream lines(text);std::string line;
        if(text.empty())record=prefix+"]\n";
        while(std::getline(lines,line)) {if(!line.empty() && line.back()=='\r')line.pop_back();record+=prefix+line+"]\n";}
        std::lock_guard<std::mutex> guard(logMutex);
        HANDLE file=CreateFileW(logPath.c_str(),FILE_APPEND_DATA,FILE_SHARE_READ|FILE_SHARE_WRITE,nullptr,OPEN_ALWAYS,FILE_ATTRIBUTE_NORMAL,nullptr);
        if(file==INVALID_HANDLE_VALUE) {OutputDebugStringA(record.c_str());return;}
        DWORD written;WriteFile(file,record.data(),static_cast<DWORD>(record.size()),&written,nullptr);CloseHandle(file);
    } catch(...) {OutputDebugStringW(L"SharpAndreas logging failed\n");}
}
void WriteNativeLog(const std::string& text) noexcept {
    try {
        int length=MultiByteToWideChar(CP_UTF8,0,text.c_str(),-1,nullptr,0);
        std::wstring wide(length,L'\0');MultiByteToWideChar(CP_UTF8,0,text.c_str(),-1,wide.data(),length);
        WritePluginLog(L"Loader",wide.c_str());
    } catch(...) {OutputDebugStringA(text.c_str());}
}
int __cdecl QueryGameState(int operation) {
#ifdef HOST_CHECK
    if(operation==0 || operation==1)return checkPaused?1:0;
    if(operation==2)return checkMission?1:0;
    if(operation==3 || operation==4) {
        checkMission=operation==3;
        WriteNativeLog(checkMission?"SCM ONMISSION true":"SCM ONMISSION false");return 1;
    }
    if(operation==5)return static_cast<int>(checkGameTime);
#else
    if(operation==0)return (CTimer::m_UserPause || CTimer::m_CodePause || FrontEndMenuManager.m_bMenuActive)?1:0;
    if(operation==1)return FrontEndMenuManager.m_bMenuActive?1:0;
    if(operation>=2 && operation<=4) {
        // OnAMissionFlag is a byte OFFSET into ScriptSpace, not the boolean value itself.
        int offset=CTheScripts::OnAMissionFlag;
        if(offset<=0 || offset>200000-static_cast<int>(sizeof(int)))return operation==3?-1:0;
        int value=0;
        if(operation==2) {std::memcpy(&value,CTheScripts::ScriptSpace+offset,sizeof(value));return value==1?1:0;}
        value=operation==3?1:0;std::memcpy(CTheScripts::ScriptSpace+offset,&value,sizeof(value));return 1;
    }
    if(operation==5)return static_cast<int>(CTimer::m_snTimeInMilliseconds);
#endif
    return -1;
}
void SetCheckPaused(bool paused) {checkPaused=paused;if(!paused)checkGameTime+=16;}
void __cdecl SetModOverlay(const wchar_t* text) {modText=text?text:L"";}
void DrawModOverlay() {
    try {
#ifndef HOST_CHECK
    if(!QueryGameState(1))return;
    HudArgs overlay{};
    if(InvokeHudBridge(1,0xfffffffe,0,&overlay)!=1)return;
    struct Restore {~Restore(){HudArgs end{};InvokeHudBridge(2,0xfffffffe,0,&end);}} restore;
    // Preserve the exact SDK font-settings block, including scale, orientation, colors and render state.
    std::array<unsigned char,0x7C> saved{};
    std::memcpy(saved.data(),reinterpret_cast<void*>(0xC71A54),saved.size());
    float width=static_cast<float>(RsGlobal.maximumWidth),height=static_cast<float>(RsGlobal.maximumHeight);
    if(width<=0 || height<=0)return;
    float sx=width/640.0f,sy=height/448.0f;
    CFont::SetScale(0.3f*sx,0.6f*sy);CFont::SetFontStyle(FONT_SUBTITLES);
    CFont::SetProportional(true);CFont::SetBackground(false,false);CFont::SetJustify(false);
    CFont::SetOrientation(ALIGN_RIGHT);CFont::SetRightJustifyWrap(0);CFont::SetSlant(0);
    CFont::SetDropColor(CRGBA(0,0,0,255));CFont::SetEdge(1);CFont::SetDropShadowPosition(0);
    CFont::SetColor(CRGBA(255,220,128,255));
    float x=width-16*sx,y=16*sy;
    CFont::PrintString(x,y,"SharpAndreas .NET Mods");y+=15*sy;
    CFont::SetColor(CRGBA(255,255,255,255));
    std::wistringstream lines(modText);std::wstring line;int count=0;
    while(std::getline(lines,line) && y<height-28*sy) {
        if(line.size()>62)line=line.substr(0,59)+L"...";
        for(auto& c:line)if(c==L'~')c=L'?';
        int length=WideCharToMultiByte(CP_ACP,0,line.c_str(),-1,nullptr,0,"?",nullptr);
        std::string ansi(length,'\0');WideCharToMultiByte(CP_ACP,0,line.c_str(),-1,ansi.data(),length,"?",nullptr);
        CFont::PrintString(x,y,ansi.c_str());y+=13*sy;count++;
    }
    if(count==0)CFont::PrintString(x,y,"No mods loaded");
    else if(lines.good())CFont::PrintString(x,y,"...");
    CFont::RenderFontBuffer();
    std::memcpy(reinterpret_cast<void*>(0xC71A54),saved.data(),saved.size());
#endif
    }catch(...) {WriteNativeLog("Mod overlay drawing failed.");}
}

void SetProfilerOverlay(const wchar_t* text) {profilerText=text?text:L"";}
void DrawProfilerOverlay() {
    try {
    if(profilerText.empty())return;
    constexpr uint32_t owner=0xffffffff;
    HudArgs args{};
    if(InvokeHudBridge(1,owner,0,&args)!=1)return;
    struct Restore {~Restore(){HudArgs end{};InvokeHudBridge(2,0xffffffff,0,&end);}} restore;
#ifdef HOST_CHECK
    static bool recorded=false;if(!recorded){recorded=true;WriteNativeLog("PROFILER OVERLAY ACTIVE");}
#endif
    InvokeHudBridge(0,0,0,&args);
    float screenWidth=args.width,screenHeight=args.height;
    if(screenWidth<=0 || screenHeight<=0)return;
    float sx=screenWidth/640.f,sy=screenHeight/448.f;
    int lines=1;for(auto c:profilerText)if(c==L'\n')lines++;
    args.x=8*sx;args.y=8*sy;args.width=screenWidth-16*sx;args.height=std::min(screenHeight-16*sy,(lines*13.f+12)*sy);args.color=0xB0000000;
    InvokeHudBridge(6,owner,0,&args);
    std::wistringstream input(profilerText);std::wstring line;float y=12*sy;int count=0;
    while(std::getline(input,line) && y<screenHeight-16*sy) {
        if(line.size()>110)line=line.substr(0,107)+L"...";
        for(auto& c:line)if(c==L'~')c=L'?';
        args.x=12*sx;args.y=y;args.scale=0.65f;args.text=line.c_str();args.color=count++?0xFFFFFFFF:0xFFFFDD88;
        InvokeHudBridge(7,owner,0,&args);y+=13*sy;
    }
    }catch(...) {WriteNativeLog("Profiler draw failed.");}
}
