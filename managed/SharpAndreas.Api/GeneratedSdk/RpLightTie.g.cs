// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RpLightTie : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public RpLightTie(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("lightInWorldSector")]
    public RwLLLink @LightInWorldSector { get => new RwLLLink(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("light")]
    public RpLight? @Light { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new RpLight(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("WorldSectorInLight")]
    public RwLLLink @WorldSectorInLight { get => new RwLLLink(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,8); } }
    [NativeMember("sect")]
    public RpWorldSector? @Sect { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new RpWorldSector(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
}
