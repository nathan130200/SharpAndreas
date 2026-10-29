// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class BreakObject_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public BreakObject_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_smashed")]
    public byte @Smashed { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_active")]
    public byte @Active { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("m_produceSparks")]
    public byte @ProduceSparks { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_drawLast")]
    public byte @DrawLast { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_numGroups")]
    public int @CountGroups { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_groups")]
    public BreakGroup_t? @Groups { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new BreakGroup_t(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_age")]
    public int @Age { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_groundZ")]
    public float @GroundZ { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_groundNormal")]
    public RwV3d @GroundNormal { get => new RwV3d(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
}
