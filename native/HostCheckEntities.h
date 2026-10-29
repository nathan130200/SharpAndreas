#pragma once
#ifdef HOST_CHECK
void RegisterCheckVehicle(int handle,int model);
void RegisterCheckPed(int handle,int model,int type);
void RemoveCheckVehicle(int handle);
void RemoveCheckPed(int handle);
int CheckDynamicVehicleCount();
int CheckDynamicPedCount();
void RegisterCheckPickup(int handle,int model,int type);
void RemoveCheckPickup(int handle);
int CheckServiceHandleCount();
int GetCheckPickupInfo(int handle,int* model,int* type,void** pointer);
#endif
