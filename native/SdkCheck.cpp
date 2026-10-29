#include "SdkBridge.h"
#include "SdkCheckIds.g.h"
#include "HostCheckEntities.h"
#include <map>
#include <array>
#include <CPed.h>
#include <CVehicle.h>
#include <CPickup.h>
namespace {
alignas(CPed) std::array<unsigned char,sizeof(CPed)> peds[3]{};
alignas(CVehicle) std::array<unsigned char,8192> vehicles[6]{};
std::map<int,std::array<unsigned char,8192>> dynamicPeds,dynamicVehicles;
bool initialized=false;
void Init() {
    if(initialized)return;initialized=true;
    for(int i=0;i<3;i++)reinterpret_cast<CPed*>(peds[i].data())->m_nPedType=i==0?0:4;
    int types[]={VEHICLE_AUTOMOBILE,VEHICLE_TRAIN,VEHICLE_TRAILER,VEHICLE_PLANE,VEHICLE_HELI,VEHICLE_BOAT};
    for(int i=0;i<6;i++)reinterpret_cast<CVehicle*>(vehicles[i].data())->m_nVehicleSubClass=static_cast<eVehicleType>(types[i]);
}
void* __cdecl GetPed(int handle) {Init();if(auto it=dynamicPeds.find(handle);it!=dynamicPeds.end())return it->second.data();if(handle==556)handle=43;if(handle==813)handle=44;return handle>=42 && handle<=44?peds[handle-42].data():nullptr;}
void* __cdecl GetVehicle(int handle) {Init();if(auto it=dynamicVehicles.find(handle);it!=dynamicVehicles.end())return it->second.data();if(handle==556)handle=104;if(handle==813)handle=106;int index=handle==42?0:handle-103;return index>=0 && index<6?vehicles[index].data():nullptr;}
int __cdecl PedRef(void* pointer) {for(auto& pair:dynamicPeds)if(pointer==pair.second.data())return pair.first;for(int i=0;i<3;i++)if(pointer==peds[i].data())return 42+i;return -1;}
int __cdecl VehicleRef(void* pointer) {for(auto& pair:dynamicVehicles)if(pointer==pair.second.data())return pair.first;for(int i=0;i<6;i++)if(pointer==vehicles[i].data())return i==0?42:103+i;return -1;}
void __cdecl Weapons(short,int,int,int) { }
}
static unsigned short __cdecl ClockMinutes(unsigned char hours,unsigned char minutes) { return static_cast<unsigned short>(hours*60+minutes); }
void* __cdecl ResolveSdkBinding(int id) {
    switch(id) {
    case CHECK_CLOCK_MINUTES:return reinterpret_cast<void*>(&ClockMinutes);
    case CHECK_CPOOLS_GETPED:return reinterpret_cast<void*>(&GetPed);
    case CHECK_CPOOLS_GETVEHICLE:return reinterpret_cast<void*>(&GetVehicle);
    case CHECK_CPOOLS_GETPEDREF:return reinterpret_cast<void*>(&PedRef);
    case CHECK_CPOOLS_GETVEHICLEREF:return reinterpret_cast<void*>(&VehicleRef);
    case CHECK_CGANGS_SETGANGWEAPONS:return reinterpret_cast<void*>(&Weapons);
    default:return nullptr;
    }
}

void RegisterCheckVehicle(int handle,int model) {auto& bytes=dynamicVehicles[handle];auto* value=reinterpret_cast<CVehicle*>(bytes.data());value->m_nVehicleSubClass=VEHICLE_AUTOMOBILE;value->m_nModelIndex=static_cast<short>(model);}
void RegisterCheckPed(int handle,int model,int type) {auto& bytes=dynamicPeds[handle];auto* value=reinterpret_cast<CPed*>(bytes.data());value->m_nPedType=type;value->m_nModelIndex=static_cast<short>(model);}
void RemoveCheckVehicle(int handle) {dynamicVehicles.erase(handle);}
void RemoveCheckPed(int handle) {dynamicPeds.erase(handle);}
int CheckDynamicVehicleCount() {return static_cast<int>(dynamicVehicles.size());}
int CheckDynamicPedCount() {return static_cast<int>(dynamicPeds.size());}

static std::map<int,std::array<unsigned char,sizeof(CPickup)>> checkPickups;
void RegisterCheckPickup(int handle,int model,int type) {auto& bytes=checkPickups[handle];auto& pickup=*reinterpret_cast<CPickup*>(bytes.data());pickup.m_nModelIndex=static_cast<short>(model);pickup.m_nPickupType=static_cast<unsigned char>(type);}
void RemoveCheckPickup(int handle) {checkPickups.erase(handle);}
int GetCheckPickupInfo(int handle,int* model,int* type,void** pointer) {auto it=checkPickups.find(handle);if(it==checkPickups.end())return 0;auto& pickup=*reinterpret_cast<CPickup*>(it->second.data());*model=pickup.m_nModelIndex;*type=pickup.m_nPickupType;*pointer=&pickup;return 1;}

