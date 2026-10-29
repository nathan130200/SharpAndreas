#pragma once
#include <cstdint>
using ManagedTaskCallback = intptr_t(__cdecl*)(uint32_t, int, int, int, intptr_t);
intptr_t __cdecl InvokeTaskBridge(int operation, uint32_t owner, uint32_t task, int argument, intptr_t data, int count);
void TickTaskCheckBackend();
