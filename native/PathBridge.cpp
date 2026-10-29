#include "PathBridge.h"
#include <CPathFind.h>
#include <algorithm>
#include <cmath>
#include <limits>
#include <vector>

namespace {
constexpr int Areas=NUM_PATH_MAP_AREAS+NUM_PATH_INTERIOR_AREAS;
#ifdef HOST_CHECK
CPathFind& Paths() {
    static CPathFind paths{};
    static CPathNode nodes[6]{};
    static CNodeAddress links[6]{};
    static bool initialized=false;
    if(!initialized) {
        initialized=true;
        paths.m_pPathNodes[0]=nodes;paths.m_pNodeLinks[0]=links;
        paths.m_dwNumNodes[0]=6;paths.m_dwNumVehicleNodes[0]=3;paths.m_dwNumPedNodes[0]=3;paths.m_dwNumAddresses[0]=6;
        int positions[6][2]={{0,0},{0,10},{1,0},{2,0},{12,0},{1,0}};
        int targets[]={1,0,0,4,-1,3};
        for(int i=0;i<6;i++) {
            nodes[i].Address.Set(0,i);nodes[i].CoorsX=positions[i][0]*8;nodes[i].CoorsY=positions[i][1]*8;
            nodes[i].Width=16;nodes[i].IndexAdjacentNodes=i;
            if(targets[i]>=0) {nodes[i].NumberAdjNodes=1;links[i].Set(0,targets[i]);}
        }
        nodes[2].WaterNode=true;nodes[5].SwitchedOff=true;
    }
    return paths;
}
#else
CPathFind& Paths() {return ThePaths;}
#endif
CPathNode* Node(CPathFind& paths,int area,int index) {
    return area>=0 && area<Areas && index>=0 && static_cast<unsigned>(index)<paths.m_dwNumNodes[area] && paths.m_pPathNodes[area]
        ? &paths.m_pPathNodes[area][index]:nullptr;
}
int Type(CPathFind& paths,int area,int index) {return static_cast<unsigned>(index)<paths.m_dwNumVehicleNodes[area]?0:1;}
bool Eligible(const CPathNode& node,int flags) {return (!node.SwitchedOff || (flags&1)) && (!node.WaterNode || (flags&2));}
template<class Action> void Links(CPathFind& paths,int area,const CPathNode& node,Action action) {
    if(!paths.m_pNodeLinks[area])return;
    unsigned start=static_cast<unsigned short>(node.IndexAdjacentNodes);
    for(unsigned i=0;i<node.NumberAdjNodes && start+i<paths.m_dwNumAddresses[area];++i) {
        auto address=paths.m_pNodeLinks[area][start+i];
        if(auto* linked=Node(paths,address.Region,address.Index))action(address,*linked);
    }
}
PathResult Describe(CPathFind& paths,int area,int index) {
    const auto& node=*Node(paths,area,index);
    PathResult result{area,index,Type(paths,area,index),
        (node.SwitchedOff?1:0)|(node.WaterNode?2:0)|(node.OnDeadEnd?4:0)|(node.DontWanderHere?8:0),node.NumberAdjNodes,
        node.CoorsX/8.f,node.CoorsY/8.f,node.CoorsZ/8.f,std::numeric_limits<float>::quiet_NaN(),node.Width/16.f,-1,-1};
    Links(paths,area,node,[&](CNodeAddress address,const CPathNode& linked) {
        if(result.headingArea>=0 || linked.SwitchedOff || linked.WaterNode!=node.WaterNode || Type(paths,address.Region,address.Index)!=result.type)return;
        float dx=(linked.CoorsX-node.CoorsX)/8.f,dy=(linked.CoorsY-node.CoorsY)/8.f;
        if(dx==0 && dy==0)return;
        float degrees=std::atan2(-dx,dy)*180.f/3.14159265358979323846f;
        result.heading=degrees<0?degrees+360.f:degrees;
        result.headingArea=address.Region;result.headingIndex=address.Index;
    });
    return result;
}
struct Candidate {double distance;int area,index;};
bool Less(const Candidate& a,const Candidate& b) {
    if(a.distance!=b.distance)return a.distance<b.distance;
    return a.area!=b.area?a.area<b.area:a.index<b.index;
}
}
int __cdecl InvokePathQuery(const PathQuery* query,PathResult* output,int capacity) noexcept {
    if(!query || capacity<0 || (!output && capacity) || query->operation<0 || query->operation>2)return -1;
    try {
        auto& paths=Paths();
        if(query->operation!=0) {
            auto* node=Node(paths,query->area,query->index);
            if(!node)return 0;
            if(query->operation==1) {if(capacity)output[0]=Describe(paths,query->area,query->index);return 1;}
            int count=0;
            Links(paths,query->area,*node,[&](CNodeAddress address,const CPathNode&) {
                if(count<capacity)output[count]=Describe(paths,address.Region,address.Index);
                ++count;
            });
            return count;
        }
        if(query->type<0 || query->type>1 || query->nth<0 || (query->flags&~3) || !std::isfinite(query->x) || !std::isfinite(query->y) || !std::isfinite(query->z) || !std::isfinite(query->radius) || query->radius<0)return -1;
        const double radiusSquared=static_cast<double>(query->radius)*query->radius;
        std::vector<Candidate> candidates;
        Candidate best{std::numeric_limits<double>::infinity(),-1,-1};
        for(int area=0;area<Areas;area++) {
            if(!paths.m_pPathNodes[area])continue;
            unsigned end=std::min(paths.m_dwNumNodes[area],static_cast<unsigned>(65535));
            unsigned vehicleEnd=std::min(paths.m_dwNumVehicleNodes[area],end);
            unsigned start=query->type==0?0:vehicleEnd;
            if(query->type==0)end=vehicleEnd;
            for(unsigned index=start;index<end;index++) {
                const auto& node=paths.m_pPathNodes[area][index];
                if(!Eligible(node,query->flags))continue;
                double dx=node.CoorsX/8.0-query->x,dy=node.CoorsY/8.0-query->y,dz=node.CoorsZ/8.0-query->z;
                Candidate candidate{dx*dx+dy*dy+dz*dz,area,static_cast<int>(index)};
                if(candidate.distance>radiusSquared)continue;
                if(query->nth) candidates.push_back(candidate);
                else if(Less(candidate,best))best=candidate;
            }
        }
        if(query->nth) {
            if(static_cast<size_t>(query->nth)>=candidates.size())return 0;
            std::nth_element(candidates.begin(),candidates.begin()+query->nth,candidates.end(),Less);
            best=candidates[query->nth];
        }
        if(best.area<0)return 0;
        if(capacity)output[0]=Describe(paths,best.area,best.index);
        return 1;
    }catch(...) {return -2;}
}
