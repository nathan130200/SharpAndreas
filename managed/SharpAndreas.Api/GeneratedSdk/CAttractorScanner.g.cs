// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAttractorScanner : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=144;
    public CAttractorScanner(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public sbyte @Field0 { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("_pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+1,3); }
    [NativeMember("field_4")]
    public CTaskTimer @Field4 { get => new CTaskTimer(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,12); } }
    [NativeMember("m_pEffectInUse")]
    public C2dEffect? @EffectInUse { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new C2dEffect(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_14")]
    public int @Field14 { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("field_18")]
    public NativeArray<int> @Field18 { get => new NativeArray<int>(Pointer+24,10); }
    [NativeMember("field_40")]
    public NativeArray<int> @Field40 { get => new NativeArray<int>(Pointer+64,10); }
    [NativeMember("field_68")]
    public NativeArray<int> @Field68 { get => new NativeArray<int>(Pointer+104,10); }
}
