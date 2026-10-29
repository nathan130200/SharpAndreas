#pragma once
#include <cstdint>
struct HudArgs {
    float x,y,width,height,z,scale;
    uint32_t color;
    const wchar_t* text;
    const uint32_t* pixels;
    int pixelCount,textureWidth,textureHeight,ped,bone;
};
static_assert(sizeof(HudArgs)==56);
int __cdecl InvokeHudBridge(int operation,uint32_t owner,uint32_t texture,HudArgs* args) noexcept;
