// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColModel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CColModel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_boundBox")]
    public CBoundingBox @BoundBox { get => new CBoundingBox(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("m_boundSphere")]
    public CSphere @BoundSphere { get => new CSphere(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,16); } }
    [NativeMember("m_nColSlot")]
    public byte @CollisionSlot { get => SdkMemory.Read<byte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_pColData")]
    public CCollisionData? @CollisionData { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CCollisionData(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D352 >(352)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D353 >(353)(Pointer); }
    public CColModel @AssignNative(CColModel @colModel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D354 >(354)(Pointer,@colModel.Pointer); return new CColModel(__sdkResult); }
    public void @MakeMultipleAlloc() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D355 >(355)(Pointer); }
    public void @AllocateData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D356 >(356)(Pointer); }
    public void @AllocateData(int @numSpheres,int @numBoxes,int @numLines,int @numVertices,int @numTriangles,bool @disks) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D357 >(357)(Pointer,@numSpheres,@numBoxes,@numLines,@numVertices,@numTriangles,(@disks ? 1 : 0)); }
    public void @AllocateData(int @size) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D358 >(358)(Pointer,@size); }
    public void @RemoveCollisionVolumes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D359 >(359)(Pointer); }
    public void @CalculateTrianglePlanes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D360 >(360)(Pointer); }
    public void @RemoveTrianglePlanes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D361 >(361)(Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D362 >(362)(@size); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D363 >(363)(@data.Pointer); }
}
