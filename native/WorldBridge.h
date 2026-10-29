#pragma once
struct WorldQuery { int type, flags; float x, y, z, radius; };
struct WorldEntry { int handle, kind; double distanceSquared; };
static_assert(sizeof(WorldQuery)==24 && sizeof(WorldEntry)==16);
int __cdecl InvokeWorldQuery(const WorldQuery* query, WorldEntry* output, int capacity) noexcept;
