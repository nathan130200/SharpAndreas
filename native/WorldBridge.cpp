#include "WorldBridge.h"
#include <cmath>
#include <limits>
#include <CPool.h>
#ifndef HOST_CHECK
#include <CPools.h>
#include <CPickups.h>
#include <CCopPed.h>
#include <CHeli.h>
#include <CCutsceneObject.h>
#else
#include <array>
#endif

namespace {
struct Results {
    WorldEntry* output;
    int capacity, count=0;
    bool nearest;
    WorldEntry best{-1,-1,std::numeric_limits<double>::infinity()};
    void Add(WorldEntry entry) {
        if(nearest) { if(entry.distanceSquared<best.distanceSquared)best=entry; count=1; }
        else { if(count<capacity)output[count]=entry; ++count; }
    }
    int Finish() { if(nearest && count && capacity)output[0]=best; return count; }
};
template<class Pool,class Kind> void Scan(Pool* pool,const WorldQuery& query,Results& results,Kind kind) {
    if(!pool)return;
    const double radiusSquared=static_cast<double>(query.radius)*query.radius;
    for(int i=0;i<pool->m_nSize;++i) {
        auto entity=pool->GetAt(i);
        if(!entity)continue;
        const auto& position=entity->GetPosition();
        double dx=static_cast<double>(position.x)-query.x;
        double dy=static_cast<double>(position.y)-query.y;
        double dz=static_cast<double>(position.z)-query.z;
        double distanceSquared=dx*dx+dy*dy+dz*dz;
        if((query.flags&1) && (!std::isfinite(distanceSquared) || distanceSquared>radiusSquared))continue;
        results.Add({pool->GetRef(entity),kind(entity),distanceSquared});
    }
}
#ifdef HOST_CHECK
// Sparse real CPool bookkeeping exercises free slots and generation-bearing SCM handles.
struct Point {float x,y,z;};
struct MockEntity {Point position;int kind;const Point& GetPosition() const {return position;}};
struct Fixture {
    std::array<MockEntity,4> entities{};
    std::array<tPoolObjectFlags,4> flags{};
    CPool<MockEntity> pool;
    Fixture(int type) {
        pool.Init(4,entities.data(),flags.data());
        for(int i: {0,2,3}) {pool.SetFreeAt(i,false);pool.SetIdAt(i,42+i);}
        entities[0]={{1,2,3},0};
        entities[2]={{3,0,0},6};
        entities[3]={{100,0,0},4};
        if(type!=1)for(auto& entity:entities)entity.kind=-1;
    }
};
#endif
}
int __cdecl InvokeWorldQuery(const WorldQuery* query,WorldEntry* output,int capacity) noexcept {
    if(!query || query->type<0 || query->type>3 || (query->flags&~3) || capacity<0 || (!output && capacity))return -1;
    if(!std::isfinite(query->x) || !std::isfinite(query->y) || !std::isfinite(query->z) || !std::isfinite(query->radius) || query->radius<0)return -1;
    try {
        Results results{output,capacity,0,(query->flags&2)!=0};
#ifndef HOST_CHECK
        if(query->type==3) {
            double radiusSquared=static_cast<double>(query->radius)*query->radius;
            for(unsigned i=0;i<MAX_NUM_PICKUPS;i++) {
                auto& pickup=CPickups::aPickUps[i];if(pickup.m_nPickupType==PICKUP_NONE)continue;
                auto position=pickup.GetPosn();double dx=position.x-query->x,dy=position.y-query->y,dz=position.z-query->z;
                double distanceSquared=dx*dx+dy*dy+dz*dz;
                if((query->flags&1) && (!std::isfinite(distanceSquared) || distanceSquared>radiusSquared))continue;
                results.Add({CPickups::GetUniquePickupIndex(i),pickup.m_nPickupType,distanceSquared});
            }
        }
        switch(query->type) {
        case 0:Scan(CPools::ms_pPedPool,*query,results,[](auto*){return -1;});break;
        case 1:Scan(CPools::ms_pVehiclePool,*query,results,[](auto* vehicle){return static_cast<int>(vehicle->m_nVehicleSubClass);});break;
        case 2:Scan(CPools::ms_pObjectPool,*query,results,[](auto*){return -1;});break;
        }
#else
        static Fixture peds(0),vehicles(1),props(2);
        auto* pool=query->type==0?&peds.pool:query->type==1?&vehicles.pool:&props.pool;
        Scan(pool,*query,results,[](auto* entity){return entity->kind;});
#endif
        return results.Finish();
    } catch(...) {return -2;}
}
