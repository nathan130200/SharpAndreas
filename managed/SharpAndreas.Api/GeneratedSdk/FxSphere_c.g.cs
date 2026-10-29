// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxSphere_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public FxSphere_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecCenter")]
    public RwV3d @Center { get => new RwV3d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fRadius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nNumPlanesPassed")]
    public uint @CountPlanesPassed { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D805 >(805)(Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size,int @notAligned) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D806 >(806)(@size,@notAligned); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D807 >(807)(@data.Pointer); }
    public bool @IsCollision(FxSphere_c? @sphere) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D808 >(808)(Pointer,@sphere?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public float @GetDistToPlane(FxPlane_c? @plane) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D809 >(809)(Pointer,@plane?.Pointer ?? IntPtr.Zero); return __sdkResult; }
}
