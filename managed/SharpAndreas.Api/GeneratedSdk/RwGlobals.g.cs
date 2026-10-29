// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RwGlobals : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=344;
    public RwGlobals(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("curCamera")]
    public NativePointer<IntPtr> @CurCamera { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("curWorld")]
    public NativePointer<IntPtr> @CurWorld { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("renderFrame")]
    public ushort @RenderFrame { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("lightFrame")]
    public ushort @LightFrame { get => SdkMemory.Read<ushort >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("pad")]
    public NativeArray<ushort> @Pad { get => new NativeArray<ushort>(Pointer+12,2); }
    [NativeMember("dOpenDevice")]
    public RwDevice @DOpenDevice { get => new RwDevice(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,56); } }
    [NativeMember("stdFunc")]
    public NativeArray<IntPtr> @StdFunc { get => new NativeArray<IntPtr>(Pointer+72,29); }
    [NativeMember("dirtyFrameList")]
    public RwLinkList @DirtyFrameList { get => new RwLinkList(Pointer+188); set { SdkMemory.Copy(value.Pointer,Pointer+188,8); } }
    [NativeMember("fileFuncs")]
    public RwFileFunctions @FileFuncs { get => new RwFileFunctions(Pointer+196); set { SdkMemory.Copy(value.Pointer,Pointer+196,44); } }
    [NativeMember("stringFuncs")]
    public RwStringFunctions @StringFuncs { get => new RwStringFunctions(Pointer+240); set { SdkMemory.Copy(value.Pointer,Pointer+240,68); } }
    [NativeMember("memoryFuncs")]
    public RwMemoryFunctions @MemoryFuncs { get => new RwMemoryFunctions(Pointer+308); set { SdkMemory.Copy(value.Pointer,Pointer+308,16); } }
    [NativeMember("memoryAlloc")]
    public NativeFunctionPointer<Callback_803f61a1d639> @MemoryAlloc { get => new NativeFunctionPointer<Callback_803f61a1d639>(SdkMemory.Read<IntPtr>(Pointer+324)); set { SdkMemory.Write(Pointer+324,value.Pointer); } }
    [NativeMember("memoryFree")]
    public NativeFunctionPointer<Callback_6cb9c7cf1b01> @MemoryFree { get => new NativeFunctionPointer<Callback_6cb9c7cf1b01>(SdkMemory.Read<IntPtr>(Pointer+328)); set { SdkMemory.Write(Pointer+328,value.Pointer); } }
    [NativeMember("metrics")]
    public RwMetrics? @Metrics { get => SdkMemory.Read<IntPtr>(Pointer+332) == IntPtr.Zero ? null : new RwMetrics(SdkMemory.Read<IntPtr>(Pointer+332)); set { SdkMemory.Write(Pointer+332,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("engineStatus")]
    public RwEngineStatus @EngineStatus { get => SdkMemory.Read<RwEngineStatus >(Pointer+336); set { SdkMemory.Write(Pointer+336,value); } }
    [NativeMember("resArenaInitSize")]
    public uint @ResArenaInitSize { get => SdkMemory.Read<uint >(Pointer+340); set { SdkMemory.Write(Pointer+340,value); } }
}
