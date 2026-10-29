#pragma once
struct PathQuery {int operation,type,nth,area,index,flags;float x,y,z,radius;};
struct PathResult {int area,index,type,flags,links;float x,y,z,heading,width;int headingArea,headingIndex;};
static_assert(sizeof(PathQuery)==40 && sizeof(PathResult)==48);
int __cdecl InvokePathQuery(const PathQuery* query,PathResult* output,int capacity) noexcept;
