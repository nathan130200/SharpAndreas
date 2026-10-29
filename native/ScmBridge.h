#pragma once
#include <cstdint>
int __cdecl InvokeScm(const uint8_t* code, int codeSize, int32_t* locals, int localCount, int* condition);
