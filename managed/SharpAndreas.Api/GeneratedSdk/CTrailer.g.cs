// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTrailer : CAutomobile
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2548;
    public CTrailer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_988")]
    public NativeObjectArray<CColPoint> @Field988 { get => new NativeObjectArray<CColPoint>(Pointer+2440,2,44); }
    [NativeMember("field_9E0")]
    public float @Field9E0 { get => SdkMemory.Read<float >(Pointer+2528); set { SdkMemory.Write(Pointer+2528,value); } }
    [NativeMember("field_9E4")]
    public float @Field9E4 { get => SdkMemory.Read<float >(Pointer+2532); set { SdkMemory.Write(Pointer+2532,value); } }
    [NativeMember("field_9E8")]
    public NativeArray<sbyte> @Field9E8 { get => new NativeArray<sbyte>(Pointer+2536,4); }
    [NativeMember("field_9EC")]
    public float @Field9EC { get => SdkMemory.Read<float >(Pointer+2540); set { SdkMemory.Write(Pointer+2540,value); } }
    [NativeMember("field_9F0")]
    public float @Field9F0 { get => SdkMemory.Read<float >(Pointer+2544); set { SdkMemory.Write(Pointer+2544,value); } }
    [NativeMember("m_fTrailerSuspensionForce")]
    public static float @TrailerSuspensionForce { get => SdkMemory.Read<float >(new IntPtr(0x8D3464)); set { SdkMemory.Write(new IntPtr(0x8D3464),value); } }
    [NativeMember("m_fTrailerDampingForce")]
    public static float @TrailerDampingForce { get => SdkMemory.Read<float >(new IntPtr(0x8D3468)); set { SdkMemory.Write(new IntPtr(0x8D3468),value); } }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4216 >(4216)(Pointer,@modelIndex,@createdBy); }
    public void @ScanForTowLink() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4217 >(4217)(Pointer); }
}
