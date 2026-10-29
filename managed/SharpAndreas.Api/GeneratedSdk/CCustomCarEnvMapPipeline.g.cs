// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCustomCarEnvMapPipeline : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCustomCarEnvMapPipeline(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_envMapPluginOffset")]
    public static int @EnvMapPluginOffset { get => SdkMemory.Read<int >(new IntPtr(0x8D12C4)); set { SdkMemory.Write(new IntPtr(0x8D12C4),value); } }
    [NativeMember("ms_envMapAtmPluginOffset")]
    public static int @EnvMapAtmPluginOffset { get => SdkMemory.Read<int >(new IntPtr(0x8D12C8)); set { SdkMemory.Write(new IntPtr(0x8D12C8),value); } }
    [NativeMember("ms_specularMapPluginOffset")]
    public static int @SpecularMapPluginOffset { get => SdkMemory.Read<int >(new IntPtr(0x8D12CC)); set { SdkMemory.Write(new IntPtr(0x8D12CC),value); } }
    [NativeMember("fakeEnvMapPipeMatData")]
    public static CustomEnvMapPipeMaterialData @FakeEnvMapPipeMatData { get => new CustomEnvMapPipeMaterialData(new IntPtr(0xC02D18)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC02D18),12); } }
    [NativeMember("ObjPipeline")]
    public static RxPipeline? @ObjectPipeline { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC02D24)) == IntPtr.Zero ? null : new RxPipeline(SdkMemory.Read<IntPtr>(new IntPtr(0xC02D24))); set { SdkMemory.Write(new IntPtr(0xC02D24),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_gEnvMapPipeMatDataPool")]
    public static CPool_CustomEnvMapPipeMaterialData__52a3973ff8? @GEnvMapPipeMatDataPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC02D28)) == IntPtr.Zero ? null : new CPool_CustomEnvMapPipeMaterialData__52a3973ff8(SdkMemory.Read<IntPtr>(new IntPtr(0xC02D28))); set { SdkMemory.Write(new IntPtr(0xC02D28),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_gEnvMapPipeAtmDataPool")]
    public static CPool_CustomEnvMapPipeAtomicData__c90f29cf8e? @GEnvMapPipeAtmDataPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC02D2C)) == IntPtr.Zero ? null : new CPool_CustomEnvMapPipeAtomicData__c90f29cf8e(SdkMemory.Read<IntPtr>(new IntPtr(0xC02D2C))); set { SdkMemory.Write(new IntPtr(0xC02D2C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_gSpecMapPipeMatDataPool")]
    public static CPool_CustomSpecMapPipeMaterialData__00ddd6bf6e? @GSpecMapPipeMatDataPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC02D30)) == IntPtr.Zero ? null : new CPool_CustomSpecMapPipeMaterialData__00ddd6bf6e(SdkMemory.Read<IntPtr>(new IntPtr(0xC02D30))); set { SdkMemory.Write(new IntPtr(0xC02D30),value?.Pointer ?? IntPtr.Zero); } }
    public static int @CustomPipeInstanceCB(int @arg1,int @arg2,NativeFunctionPointer<Callback_bfb5e72c8a95> @callback) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2383 >(2383)(@arg1,@arg2,@callback.Pointer); return __sdkResult; }
    public static void @PreRenderUpdate() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2384 >(2384)(); }
    public static NativePointer<IntPtr> @pluginEnvMatConstructorCB(NativePointer<IntPtr> @object,int @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2385 >(2385)(@object.Pointer,@offset); return new NativePointer<IntPtr>(__sdkResult); }
    public static RwStream? @pluginEnvMatStreamWriteCB(RwStream? @stream,int @length,NativePointer<IntPtr> @arg3,int @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2386 >(2386)(@stream?.Pointer ?? IntPtr.Zero,@length,@arg3.Pointer,@arg4); return __sdkResult == IntPtr.Zero ? null : new RwStream(__sdkResult); }
    public static int @pluginEnvMatStreamGetSizeCB(NativePointer<IntPtr> @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2387 >(2387)(@arg0.Pointer); return __sdkResult; }
    public static NativePointer<IntPtr> @pluginEnvAtmConstructorCB(NativePointer<IntPtr> @object,int @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2388 >(2388)(@object.Pointer,@offset); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @pluginSpecMatConstructorCB(NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2389 >(2389)(@object.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static RwStream? @pluginSpecMatStreamWriteCB(RwStream? @stream,int @length,NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2390 >(2390)(@stream?.Pointer ?? IntPtr.Zero,@length,@object.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwStream(__sdkResult); }
    public static int @pluginSpecMatStreamGetSizeCB() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2391 >(2391)(); return __sdkResult; }
    public static CustomEnvMapPipeMaterialData? @DuplicateCustomEnvMapPipeMaterialData(NativePointer<IntPtr> @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2392 >(2392)(@arg0.Pointer); return __sdkResult == IntPtr.Zero ? null : new CustomEnvMapPipeMaterialData(__sdkResult); }
    public static NativePointer<IntPtr> @pluginEnvMatDestructorCB(NativePointer<IntPtr> @object,int @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2393 >(2393)(@object.Pointer,@offset); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @pluginEnvMatCopyConstructorCB(NativePointer<IntPtr> @object_dst,NativePointer<IntPtr> @object_src,int @offset,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2394 >(2394)(@object_dst.Pointer,@object_src.Pointer,@offset,@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static RwStream? @pluginEnvMatStreamReadCB(RwStream? @stream,int @length,NativePointer<IntPtr> @object,int @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2395 >(2395)(@stream?.Pointer ?? IntPtr.Zero,@length,@object.Pointer,@offset); return __sdkResult == IntPtr.Zero ? null : new RwStream(__sdkResult); }
    public static NativePointer<IntPtr> @pluginEnvAtmDestructorCB(NativePointer<IntPtr> @object,int @offset) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2396 >(2396)(@object.Pointer,@offset); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @pluginEnvAtmCopyConstructorCB(NativePointer<IntPtr> @object_dst,NativePointer<IntPtr> @object_src,int @offset,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2397 >(2397)(@object_dst.Pointer,@object_src.Pointer,@offset,@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @pluginSpecMatDestructorCB(NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2398 >(2398)(@object.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static NativePointer<IntPtr> @pluginSpecMatCopyConstructorCB(NativePointer<IntPtr> @object_dst,NativePointer<IntPtr> @object_src) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2399 >(2399)(@object_dst.Pointer,@object_src.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static RwStream? @pluginSpecMatStreamReadCB(RwStream? @stream,int @length,NativePointer<IntPtr> @object) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2400 >(2400)(@stream?.Pointer ?? IntPtr.Zero,@length,@object.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwStream(__sdkResult); }
    public static int @CustomPipeRenderCB(RwResEntry? @atomic,NativePointer<IntPtr> @object,byte @flags1,uint @flags2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2401 >(2401)(@atomic?.Pointer ?? IntPtr.Zero,@object.Pointer,@flags1,@flags2); return __sdkResult; }
    public static RxPipeline? @CreateCustomOpenGLObjPipe() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2402 >(2402)(); return __sdkResult == IntPtr.Zero ? null : new RxPipeline(__sdkResult); }
    public static sbyte @CreatePipe() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2403 >(2403)(); return __sdkResult; }
    public static void @DestroyPipe() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2404 >(2404)(); }
    public static void @SetFxEnvTexture(RpMaterial? @material,RwTexture? @texture) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2405 >(2405)(@material?.Pointer ?? IntPtr.Zero,@texture?.Pointer ?? IntPtr.Zero); }
    public static sbyte @RegisterPlugin() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2406 >(2406)(); return __sdkResult; }
    public static RpMaterial? @CustomPipeMaterialSetup(RpMaterial? @arg0,NativePointer<IntPtr> @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2407 >(2407)(@arg0?.Pointer ?? IntPtr.Zero,@arg1.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpMaterial(__sdkResult); }
    public static RpAtomic? @CustomPipeAtomicSetup(RpAtomic? @arg0) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2408 >(2408)(@arg0?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
}
