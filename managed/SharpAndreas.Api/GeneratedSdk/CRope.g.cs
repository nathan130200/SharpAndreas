// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRope : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=808;
    public CRope(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_avecRopeSegments")]
    public NativeObjectArray<CVector> @RopeSegments { get => new NativeObjectArray<CVector>(Pointer+0,32,12); }
    [NativeMember("m_avecRopeSegmentsReleased")]
    public NativeObjectArray<CVector> @RopeSegmentsReleased { get => new NativeObjectArray<CVector>(Pointer+384,32,12); }
    [NativeMember("m_nId")]
    public int @Id { get => SdkMemory.Read<int >(Pointer+768); set { SdkMemory.Write(Pointer+768,value); } }
    [NativeMember("field_304")]
    public float @Field304 { get => SdkMemory.Read<float >(Pointer+772); set { SdkMemory.Write(Pointer+772,value); } }
    [NativeMember("m_fMass")]
    public float @Mass { get => SdkMemory.Read<float >(Pointer+776); set { SdkMemory.Write(Pointer+776,value); } }
    [NativeMember("m_fRopeTotalLength")]
    public float @RopeTotalLength { get => SdkMemory.Read<float >(Pointer+780); set { SdkMemory.Write(Pointer+780,value); } }
    [NativeMember("m_pRopeHolder")]
    public CEntity? @RopeHolder { get => SdkMemory.Read<IntPtr>(Pointer+784) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+784)); set { SdkMemory.Write(Pointer+784,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pRopeAttachObject")]
    public CObject? @RopeAttachObject { get => SdkMemory.Read<IntPtr>(Pointer+788) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(Pointer+788)); set { SdkMemory.Write(Pointer+788,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAttachedEntity")]
    public CEntity? @AttachedEntity { get => SdkMemory.Read<IntPtr>(Pointer+792) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+792)); set { SdkMemory.Write(Pointer+792,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fRopeSegmentLength")]
    public float @RopeSegmentLength { get => SdkMemory.Read<float >(Pointer+796); set { SdkMemory.Write(Pointer+796,value); } }
    [NativeMember("m_nTime")]
    public uint @Time { get => SdkMemory.Read<uint >(Pointer+800); set { SdkMemory.Write(Pointer+800,value); } }
    [NativeMember("m_nNumSegments")]
    public byte @CountSegments { get => SdkMemory.Read<byte >(Pointer+804); set { SdkMemory.Write(Pointer+804,value); } }
    [NativeMember("m_nRopeType")]
    public byte @RopeType { get => SdkMemory.Read<byte >(Pointer+805); set { SdkMemory.Write(Pointer+805,value); } }
    [NativeMember("m_nFlags1")]
    public byte @Flags1 { get => SdkMemory.Read<byte >(Pointer+806); set { SdkMemory.Write(Pointer+806,value); } }
    [NativeMember("m_nFlags2")]
    public byte @Flags2 { get => SdkMemory.Read<byte >(Pointer+807); set { SdkMemory.Write(Pointer+807,value); } }
    public void @CreateHookObjectForRope() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3610 >(3610)(Pointer); }
    public void @PickUpObject(CEntity? @object) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3611 >(3611)(Pointer,@object?.Pointer ?? IntPtr.Zero); }
    public void @ReleasePickedUpObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3612 >(3612)(Pointer); }
    public void @Remove() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3613 >(3613)(Pointer); }
    public void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3614 >(3614)(Pointer); }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3615 >(3615)(Pointer); }
    public void @UpdateWeightInRope(CVector @a1,float @a2,CVector? @a3) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3616 >(3616)(Pointer,@a1.Pointer,@a2,@a3?.Pointer ?? IntPtr.Zero); }
}
