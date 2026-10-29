#pragma once
#include <string>
void SetPluginDataRoot(const wchar_t* path);
void __cdecl WritePluginLog(const wchar_t* script,const wchar_t* message) noexcept;
void WriteNativeLog(const std::string& text) noexcept;
int __cdecl QueryGameState(int operation);
void __cdecl SetModOverlay(const wchar_t* text);
void DrawModOverlay();
void SetCheckPaused(bool paused);

void SetProfilerOverlay(const wchar_t* text);
void DrawProfilerOverlay();
