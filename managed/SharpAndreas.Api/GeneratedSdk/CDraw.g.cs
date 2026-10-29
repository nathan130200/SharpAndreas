// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDraw : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CDraw(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_fFOV")]
    public static float @FOV { get => SdkMemory.Read<float >(new IntPtr(0x8D5038)); set { SdkMemory.Write(new IntPtr(0x8D5038),value); } }
    [NativeMember("ms_fLODDistance")]
    public static float @LODDistance { get => SdkMemory.Read<float >(new IntPtr(0xC3EF98)); set { SdkMemory.Write(new IntPtr(0xC3EF98),value); } }
    [NativeMember("ms_fFarClipZ")]
    public static float @FarClipZ { get => SdkMemory.Read<float >(new IntPtr(0xC3EF9C)); set { SdkMemory.Write(new IntPtr(0xC3EF9C),value); } }
    [NativeMember("ms_fNearClipZ")]
    public static float @NearClipZ { get => SdkMemory.Read<float >(new IntPtr(0xC3EFA0)); set { SdkMemory.Write(new IntPtr(0xC3EFA0),value); } }
    [NativeMember("ms_fAspectRatio")]
    public static float @AspectRatio { get => SdkMemory.Read<float >(new IntPtr(0xC3EFA4)); set { SdkMemory.Write(new IntPtr(0xC3EFA4),value); } }
    [NativeMember("FadeRed")]
    public static byte @FadeRed { get => SdkMemory.Read<byte >(new IntPtr(0xC3EFA8)); set { SdkMemory.Write(new IntPtr(0xC3EFA8),value); } }
    [NativeMember("FadeGreen")]
    public static byte @FadeGreen { get => SdkMemory.Read<byte >(new IntPtr(0xC3EFA9)); set { SdkMemory.Write(new IntPtr(0xC3EFA9),value); } }
    [NativeMember("FadeBlue")]
    public static byte @FadeBlue { get => SdkMemory.Read<byte >(new IntPtr(0xC3EFAA)); set { SdkMemory.Write(new IntPtr(0xC3EFAA),value); } }
    [NativeMember("FadeValue")]
    public static byte @FadeValue { get => SdkMemory.Read<byte >(new IntPtr(0xC3EFAB)); set { SdkMemory.Write(new IntPtr(0xC3EFAB),value); } }
    public static void @SetFOV(float @fovValue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2488 >(2488)(@fovValue); }
    public static float @CalculateAspectRatio() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2489 >(2489)(); return __sdkResult; }
}
