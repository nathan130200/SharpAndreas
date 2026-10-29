#include "ServicesBridge.h"
#include <cstring>
#include <cmath>
#ifndef HOST_CHECK
#include <CPickups.h>
#include <CTheZones.h>
#include <CWeather.h>
#include <CTheScripts.h>
#include <CDecisionMakerTypes.h>
#else
#include "HostCheckEntities.h"
#endif
int __cdecl InvokeServices(int operation,ServiceArgs* args) noexcept {
    if(!args)return -1;
    try {
#ifndef HOST_CHECK
        if(operation==1) {
            int index=CPickups::GetActualPickupIndex(args->first);
            if(index<0 || static_cast<unsigned>(index)>=MAX_NUM_PICKUPS)return 0;
            auto* pickup=&CPickups::aPickUps[index];
            if(pickup->m_nPickupType==PICKUP_NONE)return 0;
            args->data=pickup;args->first=pickup->m_nModelIndex;args->second=pickup->m_nPickupType;return 1;
        }
        if(operation==2 || operation==3) {
            if(!args->data)return -1;
            CZone* zone=nullptr;
            if(operation==2) {
                if(!std::isfinite(args->x)||!std::isfinite(args->y)||!std::isfinite(args->z))return -1;
                CVector point(args->x,args->y,args->z);zone=CTheZones::FindSmallestZoneForPosition(point,false);
            } else {
                if(!args->text)return -1;
                char label[9]{};int length=0;
                while(args->text[length]) {if(length==8 || args->text[length]>127)return -1;label[length]=static_cast<char>(args->text[length]);length++;}
                short index=CTheZones::FindZoneByLabel(label,ZONE_TYPE_NAVI);
                if(index>=0)zone=CTheZones::GetInfoZone(index);
            }
            if(!zone)return 0;
            auto& output=*static_cast<ZoneData*>(args->data);
            std::memcpy(output.label,zone->m_szLabel,8);std::memcpy(output.textKey,zone->m_szTextKey,8);
            output.minX=zone->m_fX1;output.minY=zone->m_fY1;output.minZ=zone->m_fZ1;
            output.maxX=zone->m_fX2;output.maxY=zone->m_fY2;output.maxZ=zone->m_fZ2;
            output.type=zone->m_nType;output.level=zone->m_nLevel;output.native=zone;return 1;
        }
        if(operation==5 || operation==6) {
            int index=CTheScripts::GetActualScriptThingIndex(args->first,7);
            if(index<10 || index>=20 || args->second<0 || args->second>=96)return -1;
            auto* manager=CDecisionMakerTypes::GetInstance();
            if(operation==6)manager->FlushDecisionMakerEventResponse(static_cast<eDecisionMakerType>(index),static_cast<eEventType>(args->second));
            else {
                if(args->x<0 || args->x>255 || args->y<0 || args->y>255 || args->z<0 || args->z>255 || args->w<0 || args->w>255)return -1;
                manager->AddEventResponse(static_cast<eDecisionMakerType>(index),static_cast<eEventType>(args->second),static_cast<eTaskType>(args->third),
                    DecisionChances(static_cast<unsigned char>(args->x),static_cast<unsigned char>(args->y),static_cast<unsigned char>(args->z),static_cast<unsigned char>(args->w)),DecisionContext((args->fourth&1)!=0,(args->fourth&2)!=0));
            }
            return 1;
        }
        if(operation==4) {
            args->first=CWeather::OldWeatherType;args->second=CWeather::NewWeatherType;args->third=CWeather::ForcedWeatherType;
            args->x=CWeather::Rain;args->y=CWeather::InterpolationValue;return 1;
        }
#else
        if(operation==5 || operation==6)return 1;
        if(operation==1)return GetCheckPickupInfo(args->first,&args->first,&args->second,&args->data);
        if(operation==2 || operation==3) {
            if(!args->data)return -1;
            auto& output=*static_cast<ZoneData*>(args->data);output={};
            std::memcpy(output.label,"GANTON",6);std::memcpy(output.textKey,"GANTON",6);
            output.minX=2000;output.minY=-2000;output.minZ=-100;output.maxX=3000;output.maxY=-1000;output.maxZ=1000;output.level=1;
            return 1;
        }
        if(operation==4) {args->first=1;args->second=4;args->third=-1;args->x=0.25f;args->y=0.5f;return 1;}
#endif
        return -1;
    }catch(...) {return -2;}
}
