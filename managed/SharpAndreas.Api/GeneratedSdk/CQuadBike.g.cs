// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CQuadBike : CAutomobile
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2492;
    public CQuadBike(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pHandling")]
    public NativePointer<IntPtr> @Handling { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+2440)); set { SdkMemory.Write(Pointer+2440,value.Pointer); } }
    [NativeMember("m_rideAnimData")]
    public CRideAnimData @RideAnimationData { get => new CRideAnimData(Pointer+2444); set { SdkMemory.Copy(value.Pointer,Pointer+2444,28); } }
    [NativeMember("field_9A8")]
    public float @Field9A8 { get => SdkMemory.Read<float >(Pointer+2472); set { SdkMemory.Write(Pointer+2472,value); } }
    [NativeMember("field_9AC")]
    public int @Field9AC { get => SdkMemory.Read<int >(Pointer+2476); set { SdkMemory.Write(Pointer+2476,value); } }
    [NativeMember("field_9B0")]
    public int @Field9B0 { get => SdkMemory.Read<int >(Pointer+2480); set { SdkMemory.Write(Pointer+2480,value); } }
    [NativeMember("field_9B4")]
    public int @Field9B4 { get => SdkMemory.Read<int >(Pointer+2484); set { SdkMemory.Write(Pointer+2484,value); } }
    [NativeMember("m_nQuadFlags")]
    public byte @QuadFlags { get => SdkMemory.Read<byte >(Pointer+2488); set { SdkMemory.Write(Pointer+2488,value); } }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3553 >(3553)(Pointer,@modelIndex,@createdBy); }
}
