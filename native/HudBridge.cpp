#include "HudBridge.h"
#include "RuntimeServices.h"
#include <map>
#include <array>
#include <vector>
#include <cstring>
#include <cmath>
#include <string>
#include <cwchar>
#ifndef HOST_CHECK
#include <windows.h>
#include <d3d9.h>
#include <RenderWare.h>
#include <CSprite2d.h>
#include <CSprite.h>
#include <CFont.h>
#include <CTxdStore.h>
#include <CPools.h>
#include <CPed.h>
#include <CVehicle.h>
#include <CColModel.h>
#include <extensions/Screen.h>
#endif
namespace {
struct Texture {uint32_t owner;int width,height;
#ifndef HOST_CHECK
    RwTexture* value;
#else
    std::vector<uint32_t> pixels;
#endif
};
std::map<uint32_t,Texture> textures;
struct Dictionary {uint32_t owner;int slot;};
std::map<uint32_t,Dictionary> dictionaries;
uint32_t nextDictionary=0;
void DestroyDictionary(Dictionary& value) {
#ifndef HOST_CHECK
    CTxdStore::RemoveRef(value.slot);CTxdStore::RemoveTxdSlot(value.slot);
#endif
}
uint32_t nextTexture=0,activeOwner=0;
#ifdef HOST_CHECK
int draws[16]{};
#endif
#ifndef HOST_CHECK
IDirect3DStateBlock9* savedDevice=nullptr;
std::array<unsigned char,0x7C> savedFont{};
struct State {RwRenderState key;void* value;};
std::vector<State> savedStates;
constexpr RwRenderState stateKeys[]={rwRENDERSTATETEXTURERASTER,rwRENDERSTATETEXTUREADDRESS,rwRENDERSTATETEXTUREADDRESSU,rwRENDERSTATETEXTUREADDRESSV,rwRENDERSTATETEXTUREFILTER,rwRENDERSTATEZTESTENABLE,rwRENDERSTATEZWRITEENABLE,rwRENDERSTATESRCBLEND,rwRENDERSTATEDESTBLEND,rwRENDERSTATEVERTEXALPHAENABLE,rwRENDERSTATEFOGENABLE,rwRENDERSTATECULLMODE,rwRENDERSTATESHADEMODE,rwRENDERSTATEALPHATESTFUNCTION,rwRENDERSTATEALPHATESTFUNCTIONREF};
CRGBA Color(uint32_t value) {return CRGBA((value>>16)&255,(value>>8)&255,value&255,value>>24);}
void End() {
    if(!activeOwner)return;
    CFont::RenderFontBuffer();
    std::memcpy(reinterpret_cast<void*>(0xC71A54),savedFont.data(),savedFont.size());
    for(auto& state:savedStates)RwRenderStateSet(state.key,state.value);
    if(savedDevice) {savedDevice->Apply();savedDevice->Release();savedDevice=nullptr;}
    savedStates.clear();activeOwner=0;
}
#else
void End() {activeOwner=0;}
#endif
void Destroy(Texture& texture) {
#ifndef HOST_CHECK
    RwTextureDestroy(texture.value);
#endif
}
}
int __cdecl InvokeHudBridge(int operation,uint32_t owner,uint32_t id,HudArgs* args) noexcept {
    try {
#ifdef HOST_CHECK
        if(operation==13)return static_cast<int>(textures.size()+dictionaries.size());
        if(operation==14)return id<16?draws[id]:-1;
        if(operation>=6 && operation<=8)draws[operation]++;
#endif
        if(operation==0) {
            if(!args)return -1;
#ifndef HOST_CHECK
            args->width=static_cast<float>(RsGlobal.maximumWidth);args->height=static_cast<float>(RsGlobal.maximumHeight);
#else
            args->width=640;args->height=448;
#endif
            return 1;
        }
        if(operation==12) {if(!args)return -1;SetProfilerOverlay(args->text);return 1;}
        if(!owner)return -1;
        if(operation==1) {
            if(activeOwner)return -1;
#ifndef HOST_CHECK
            savedStates.clear();savedStates.reserve(std::size(stateKeys));
            auto* device=static_cast<IDirect3DDevice9*>(RwD3D9GetCurrentD3DDevice());
            if(!device || device->TestCooperativeLevel()!=D3D_OK)return 0;
            if(FAILED(device->CreateStateBlock(D3DSBT_ALL,&savedDevice)))return 0;
            if(FAILED(savedDevice->Capture())) {savedDevice->Release();savedDevice=nullptr;return 0;}
            std::memcpy(savedFont.data(),reinterpret_cast<void*>(0xC71A54),savedFont.size());
            for(auto key:stateKeys) {void* value=nullptr;if(RwRenderStateGet(key,&value))savedStates.push_back({key,value});}
#endif
            activeOwner=owner;return 1;
        }
        if(operation==2) {if(activeOwner!=owner)return -1;End();return 1;}
        if(operation==10) {
            if(activeOwner==owner)End();
            for(auto it=textures.begin();it!=textures.end();) {if(it->second.owner==owner) {Destroy(it->second);it=textures.erase(it);}else ++it;}
            for(auto it=dictionaries.begin();it!=dictionaries.end();) {if(it->second.owner==owner) {DestroyDictionary(it->second);it=dictionaries.erase(it);}else ++it;}
            return 1;
        }
        if(operation==16) {
            if(!owner || !args || !args->pixels || args->pixelCount<=0 || nextDictionary>=0x7ffffffe)return -1;
            uint32_t handle=++nextDictionary;int slot=0;
#ifndef HOST_CHECK
            std::string name="SharpAndreas_"+std::to_string(handle);slot=CTxdStore::AddTxdSlot(name.c_str());if(slot<0)return -2;
            RwMemory memory{reinterpret_cast<RwUInt8*>(const_cast<uint32_t*>(args->pixels)),static_cast<RwUInt32>(args->pixelCount)};
            auto* stream=RwStreamOpen(rwSTREAMMEMORY,rwSTREAMREAD,&memory);if(!stream) {CTxdStore::RemoveTxdSlot(slot);return -2;}
            bool loaded=CTxdStore::LoadTxd(slot,stream);RwStreamClose(stream,nullptr);
            if(!loaded) {CTxdStore::RemoveTxdSlot(slot);return -2;}CTxdStore::AddRef(slot);
#endif
            Dictionary dictionary{owner,slot};try {dictionaries.emplace(handle,dictionary);}catch(...) {DestroyDictionary(dictionary);throw;}
            return static_cast<int>(handle);
        }
        if(operation==17 || operation==18) {
            auto it=dictionaries.find(id);if(it==dictionaries.end() || it->second.owner!=owner)return -1;
            if(operation==18) {DestroyDictionary(it->second);dictionaries.erase(it);return 1;}
            if(!args || !args->text || nextTexture>=0x7ffffffe)return -1;
            char name[33]{};int length=0;while(args->text[length]) {if(length==32 || args->text[length]>127)return -1;name[length]=static_cast<char>(args->text[length]);length++;}
            Texture texture{owner,1,1};
#ifndef HOST_CHECK
            auto* definition=CTxdStore::ms_pTxdPool->GetAt(it->second.slot);if(!definition || !definition->m_pRwDictionary)return -2;
            auto* value=RwTexDictionaryFindNamedTexture(definition->m_pRwDictionary,name);if(!value || !value->raster)return -2;
            RwTextureAddRef(value);texture.value=value;texture.width=value->raster->width;texture.height=value->raster->height;
#else
            texture.pixels.resize(1);
#endif
            uint32_t handle=++nextTexture;try {textures.emplace(handle,std::move(texture));}catch(...) {Destroy(texture);throw;}
            args->textureWidth=texture.width;args->textureHeight=texture.height;return static_cast<int>(handle);
        }
        if(operation==3) {
            if(!args || args->textureWidth<1 || args->textureWidth>2048 || args->textureHeight<1 || args->textureHeight>2048 || nextTexture>=0x7ffffffe)return -1;
            Texture texture{owner,args->textureWidth,args->textureHeight};
#ifndef HOST_CHECK
            auto* raster=RwRasterCreate(texture.width,texture.height,32,rwRASTERTYPETEXTURE|rwRASTERFORMAT8888);
            if(!raster)return -2;
            texture.value=RwTextureCreate(raster);
            if(!texture.value) {RwRasterDestroy(raster);return -2;}
            auto* clear=RwRasterLock(raster,0,rwRASTERLOCKWRITE|rwRASTERLOCKNOFETCH);
            if(!clear) {RwTextureDestroy(texture.value);return -2;}
            if(raster->depth!=32 || raster->width!=texture.width || raster->height!=texture.height || raster->stride<texture.width*4) {RwRasterUnlock(raster);RwTextureDestroy(texture.value);return -2;}
            for(int y=0;y<texture.height;y++)std::memset(clear+y*raster->stride,0,texture.width*4);
            if(!RwRasterUnlock(raster)) {RwTextureDestroy(texture.value);return -2;}
            RwTextureSetFilterMode(texture.value,rwFILTERLINEAR);
            RwTextureSetAddressing(texture.value,rwTEXTUREADDRESSCLAMP);
#else
            texture.pixels.resize(texture.width*texture.height);
#endif
            uint32_t handle=++nextTexture;
            try {textures.emplace(handle,std::move(texture));}catch(...) {Destroy(texture);throw;}
            return static_cast<int>(handle);
        }
        if(operation==4 || operation==5 || operation==8) {
            auto it=textures.find(id);
            if(it==textures.end() || it->second.owner!=owner)return -1;
            auto& texture=it->second;
            if(operation==5) {Destroy(texture);textures.erase(it);return 1;}
            if(!args)return -1;
            if(operation==4) {
                if(!args->pixels || args->pixelCount!=texture.width*texture.height)return -1;
#ifndef HOST_CHECK
                auto* raster=RwTextureGetRaster(texture.value);
                auto* pixels=RwRasterLock(raster,0,rwRASTERLOCKWRITE|rwRASTERLOCKNOFETCH);
                if(!pixels)return -2;
                if(raster->depth!=32 || raster->stride<texture.width*4) {RwRasterUnlock(raster);return -2;}
                for(int y=0;y<texture.height;y++)std::memcpy(pixels+y*raster->stride,args->pixels+y*texture.width,texture.width*4);
                if(!RwRasterUnlock(raster))return -2;
#else
                std::memcpy(texture.pixels.data(),args->pixels,args->pixelCount*4);
#endif
                return 1;
            }
            if(activeOwner!=owner)return -1;
#ifndef HOST_CHECK
            CSprite2d sprite;sprite.m_pTexture=texture.value;sprite.Draw(args->x,args->y,args->width,args->height,Color(args->color));
#endif
            return 1;
        }
        if(!args)return -1;
        if(operation==9) {
#ifndef HOST_CHECK
            RwV3d world{args->x,args->y,args->z},screen{};
            if(args->ped>=0) {
                if(args->bone==-1) {
                    auto* vehicle=CPools::GetVehicle(args->ped);if(!vehicle)return 0;
                    const auto& position=vehicle->GetPosition();world={position.x,position.y,position.z};
                    auto* collision=vehicle->GetColModel();float height=collision?collision->m_boundBox.m_vecMax.z:1.5f;
                    world.z+=(height>0?height:1.5f)+args->scale;
                } else {auto* ped=CPools::GetPed(args->ped);if(!ped || !ped->m_pRwClump)return 0;ped->GetBonePosition(world,8,true);}
            }
            float width,height;
            if(!CSprite::CalcScreenCoors(world,&screen,&width,&height,true,true))return 0;
            args->x=screen.x;args->y=screen.y;args->z=screen.z;
            return screen.x>=0 && screen.y>=0 && screen.x<=RsGlobal.maximumWidth && screen.y<=RsGlobal.maximumHeight;
#else
            if(args->z<0)return 0;args->x+=100;args->y=100-args->y;return 1;
#endif
        }
        if(activeOwner!=owner)return -1;
        if(operation==6) {
#ifndef HOST_CHECK
            CSprite2d::DrawRect(CRect(args->x,args->y,args->x+args->width,args->y+args->height),Color(args->color));
#endif
            return 1;
        }
        if(operation==7) {
            if(!args->text || std::wcslen(args->text)>1024)return -1;
#ifndef HOST_CHECK
            int length=WideCharToMultiByte(CP_ACP,0,args->text,-1,nullptr,0,"?",nullptr);
            std::string text(length,'\0');WideCharToMultiByte(CP_ACP,0,args->text,-1,text.data(),length,"?",nullptr);
            CFont::SetScale(args->scale*0.5f*RsGlobal.maximumWidth/640.f,args->scale*RsGlobal.maximumHeight/448.f);
            CFont::SetFontStyle(FONT_SUBTITLES);CFont::SetOrientation(ALIGN_LEFT);CFont::SetProportional(true);
            CFont::SetBackground(false,false);CFont::SetJustify(false);CFont::SetSlant(0);CFont::SetWrapx(static_cast<float>(RsGlobal.maximumWidth));
            CFont::SetColor(Color(args->color));CFont::SetEdge(0);CFont::SetDropShadowPosition(0);
            CFont::PrintString(args->x,args->y,text.c_str());CFont::RenderFontBuffer();
#endif
            return 1;
        }
        return -1;
    }catch(...) {return -3;}
}
