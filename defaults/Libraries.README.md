Shared managed dependencies placed here load into the default AssemblyLoadContext.
They are shared for the process lifetime. Replacing a shared assembly requires restarting GTA.
A mod can privately override a dependency in Mods/<ModId>/Libraries; private managed dependencies load from memory in that mod's collectible context.
Native dependencies must be x86 and remain normal Windows-loaded DLLs.
