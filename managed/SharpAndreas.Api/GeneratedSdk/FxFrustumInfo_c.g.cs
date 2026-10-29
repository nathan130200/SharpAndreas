// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxFrustumInfo_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=84;
    public FxFrustumInfo_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_sphere")]
    public FxSphere_c @Sphere { get => new FxSphere_c(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,20); } }
    [NativeMember("m_planes")]
    public NativeObjectArray<FxPlane_c> @Planes { get => new NativeObjectArray<FxPlane_c>(Pointer+20,4,16); }
    public bool @IsCollision(FxSphere_c? @sphere) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4525 >(4525)(Pointer,@sphere?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
}
