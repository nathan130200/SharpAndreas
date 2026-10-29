#pragma once
struct ServiceArgs {int first,second,third,fourth;float x,y,z,w;void* data;int count;const wchar_t* text;};
struct ZoneData {char label[8],textKey[8];float minX,minY,minZ,maxX,maxY,maxZ;int type,level;void* native;};
static_assert(sizeof(ServiceArgs)==44 && sizeof(ZoneData)==52);
int __cdecl InvokeServices(int operation,ServiceArgs* args) noexcept;
