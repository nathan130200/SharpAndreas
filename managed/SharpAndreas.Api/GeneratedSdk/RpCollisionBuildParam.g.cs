// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpCollisionBuildParam : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RpCollisionBuildParam(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("flags")]
    public uint @Flags { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("sortCallBack")]
    public NativeFunctionPointer<Callback_1ad657fedfc3> @SortCallBack { get => new NativeFunctionPointer<Callback_1ad657fedfc3>(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value.Pointer); } }
    [NativeMember("sortCallBackData")]
    public NativePointer<IntPtr> @SortCallBackData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
}
