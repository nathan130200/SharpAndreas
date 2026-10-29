// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCollisionData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CCollisionData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNumSpheres")]
    public ushort @CountSpheres { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nNumBoxes")]
    public ushort @CountBoxes { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nNumTriangles")]
    public ushort @CountTriangles { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nNumLines")]
    public byte @CountLines { get => SdkMemory.Read<byte >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nFlags")]
    public CCollisionData___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCollisio_3fbeec9a34 @Flags { get => new CCollisionData___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CCollisio_3fbeec9a34(Pointer+7); set { SdkMemory.Copy(value.Pointer,Pointer+7,1); } }
    [NativeMember("m_pSpheres")]
    public CColSphere? @Spheres { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CColSphere(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pBoxes")]
    public CColBox? @Boxes { get => SdkMemory.Read<IntPtr>(Pointer+12) == IntPtr.Zero ? null : new CColBox(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pVertices")]
    public CompressedVector? @Vertices { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CompressedVector(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTriangles")]
    public CColTriangle? @Triangles { get => SdkMemory.Read<IntPtr>(Pointer+24) == IntPtr.Zero ? null : new CColTriangle(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTrianglePlanes")]
    public CColTrianglePlane? @TrianglePlanes { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new CColTrianglePlane(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nNumShadowTriangles")]
    public uint @CountShadowTriangles { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nNumShadowVertices")]
    public uint @CountShadowVertices { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_pShadowVertices")]
    public CompressedVector? @ShadowVertices { get => SdkMemory.Read<IntPtr>(Pointer+40) == IntPtr.Zero ? null : new CompressedVector(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pShadowTriangles")]
    public CColTriangle? @ShadowTriangles { get => SdkMemory.Read<IntPtr>(Pointer+44) == IntPtr.Zero ? null : new CColTriangle(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value?.Pointer ?? IntPtr.Zero); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D343 >(343)(Pointer); }
    public void @RemoveCollisionVolumes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D344 >(344)(Pointer); }
    public void @Copy(CCollisionData @arg0) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D345 >(345)(Pointer,@arg0.Pointer); }
    public void @CalculateTrianglePlanes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D346 >(346)(Pointer); }
    public void @GetTrianglePoint(CVector @outVec,int @vertId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D347 >(347)(Pointer,@outVec.Pointer,@vertId); }
    public void @GetShadTrianglePoint(CVector @outVec,int @vertId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D348 >(348)(Pointer,@outVec.Pointer,@vertId); }
    public void @RemoveTrianglePlanes() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D349 >(349)(Pointer); }
    public void @SetLinkPtr(CLink_CCollisionData____4550f648a4? @link) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D350 >(350)(Pointer,@link?.Pointer ?? IntPtr.Zero); }
    public CLink_CCollisionData____4550f648a4? @GetLinkPtr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D351 >(351)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CLink_CCollisionData____4550f648a4(__sdkResult); }
}
