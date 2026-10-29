// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMirrors : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CMirrors(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pBuffer")]
    public static RwRaster? @Buffer { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC7C71C)) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(new IntPtr(0xC7C71C))); set { SdkMemory.Write(new IntPtr(0xC7C71C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pZBuffer")]
    public static RwRaster? @ZBuffer { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC7C720)) == IntPtr.Zero ? null : new RwRaster(SdkMemory.Read<IntPtr>(new IntPtr(0xC7C720))); set { SdkMemory.Write(new IntPtr(0xC7C720),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("TypeOfMirror")]
    public static uint @TypeOfMirror { get => SdkMemory.Read<uint >(new IntPtr(0xC7C724)); set { SdkMemory.Write(new IntPtr(0xC7C724),value); } }
    [NativeMember("bRenderingReflection")]
    public static bool @RenderingReflection { get => SdkMemory.Read<bool >(new IntPtr(0xC7C728)); set { SdkMemory.Write(new IntPtr(0xC7C728),value); } }
    [NativeMember("d3dRestored")]
    public static bool @D3dRestored { get => SdkMemory.Read<bool >(new IntPtr(0xC7C729)); set { SdkMemory.Write(new IntPtr(0xC7C729),value); } }
    [NativeMember("MirrorFlags")]
    public static uint @MirrorFlags { get => SdkMemory.Read<uint >(new IntPtr(0xC7C618)); set { SdkMemory.Write(new IntPtr(0xC7C618),value); } }
    [NativeMember("MirrorV")]
    public static float @MirrorV { get => SdkMemory.Read<float >(new IntPtr(0xC7C61C)); set { SdkMemory.Write(new IntPtr(0xC7C61C),value); } }
    [NativeMember("MirrorNormal")]
    public static CVector @MirrorNormal { get => new CVector(new IntPtr(0xC803D8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC803D8),12); } }
    public static void @BeforeConstructRenderList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3180 >(3180)(); }
    public static void @BeforeMainRender() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3181 >(3181)(); }
    public static void @BuildCamMatrix(CMatrix? @mat,CVector @pointA,CVector @pointB) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3182 >(3182)(@mat?.Pointer ?? IntPtr.Zero,@pointA.Pointer,@pointB.Pointer); }
    public static void @BuildCameraMatrixForScreens(CMatrix? @mat) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3183 >(3183)(@mat?.Pointer ?? IntPtr.Zero); }
    public static void @CreateBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3184 >(3184)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3185 >(3185)(); }
    public static void @RenderMirrorBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3186 >(3186)(); }
    public static void @ShutDown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3187 >(3187)(); }
}
