// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBmx : CBike
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2104;
    public CBmx(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fBunnyHopCharge")]
    public float @BunnyHopCharge { get => SdkMemory.Read<float >(Pointer+2068); set { SdkMemory.Write(Pointer+2068,value); } }
    [NativeMember("field_818")]
    public float @Field818 { get => SdkMemory.Read<float >(Pointer+2072); set { SdkMemory.Write(Pointer+2072,value); } }
    [NativeMember("m_fSprintLeanAngle")]
    public float @SprintLeanAngle { get => SdkMemory.Read<float >(Pointer+2076); set { SdkMemory.Write(Pointer+2076,value); } }
    [NativeMember("field_820")]
    public float @Field820 { get => SdkMemory.Read<float >(Pointer+2080); set { SdkMemory.Write(Pointer+2080,value); } }
    [NativeMember("m_fPedalAngleL")]
    public float @PedalAngleL { get => SdkMemory.Read<float >(Pointer+2084); set { SdkMemory.Write(Pointer+2084,value); } }
    [NativeMember("m_fPedalAngleR")]
    public float @PedalAngleR { get => SdkMemory.Read<float >(Pointer+2088); set { SdkMemory.Write(Pointer+2088,value); } }
    [NativeMember("m_fDistanceBetweenWheels")]
    public float @DistanceBetweenWheels { get => SdkMemory.Read<float >(Pointer+2092); set { SdkMemory.Write(Pointer+2092,value); } }
    [NativeMember("m_fWheelsBalance")]
    public float @WheelsBalance { get => SdkMemory.Read<float >(Pointer+2096); set { SdkMemory.Write(Pointer+2096,value); } }
    [NativeMember("field_834")]
    public byte @Field834 { get => SdkMemory.Read<byte >(Pointer+2100); set { SdkMemory.Write(Pointer+2100,value); } }
    [NativeMember("_pad")]
    public NativeArray<sbyte> @Pad { get => new NativeArray<sbyte>(Pointer+2101,3); }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1219 >(1219)(Pointer,@modelIndex,@createdBy); }
    public void @GetFrameOffset(NativePointer<float> @arg0,NativePointer<float> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1220 >(1220)(Pointer,@arg0.Pointer,@arg1.Pointer); }
    public void @ProcessBunnyHop() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1221 >(1221)(Pointer); }
    public static void @LaunchBunnyHopCB(CAnimBlendAssociation? @blendAssoc,NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1222 >(1222)(@blendAssoc?.Pointer ?? IntPtr.Zero,@data.Pointer); }
}
