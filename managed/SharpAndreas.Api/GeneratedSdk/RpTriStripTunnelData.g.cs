// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpTriStripTunnelData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public RpTriStripTunnelData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("quality")]
    public float @Quality { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("lengthLimit")]
    public uint @LengthLimit { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("costCB")]
    public NativeFunctionPointer<Callback_d14cd729481e> @CostCB { get => new NativeFunctionPointer<Callback_d14cd729481e>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
    [NativeMember("data")]
    public NativePointer<IntPtr> @Data { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
}
