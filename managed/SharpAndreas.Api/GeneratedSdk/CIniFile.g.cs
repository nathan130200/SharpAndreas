// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CIniFile : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CIniFile(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("PedNumberMultiplier")]
    public static float @PedNumberMultiplier { get => SdkMemory.Read<float >(new IntPtr(0x8CDF14)); set { SdkMemory.Write(new IntPtr(0x8CDF14),value); } }
    [NativeMember("CarNumberMultiplier")]
    public static float @CarNumberMultiplier { get => SdkMemory.Read<float >(new IntPtr(0x8CDF18)); set { SdkMemory.Write(new IntPtr(0x8CDF18),value); } }
    public static void @LoadIniFile() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2986 >(2986)(); }
}
