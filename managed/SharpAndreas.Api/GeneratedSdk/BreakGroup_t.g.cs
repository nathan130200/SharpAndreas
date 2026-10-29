// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class BreakGroup_t : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=116;
    public BreakGroup_t(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_mat")]
    public RwMatrixTag @Mat { get => new RwMatrixTag(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,64); } }
    [NativeMember("m_vel")]
    public RwV3d @Velocity { get => new RwV3d(Pointer+64); set { SdkMemory.Copy(value.Pointer,Pointer+64,12); } }
    [NativeMember("m_atRest")]
    public byte @AtRest { get => SdkMemory.Read<byte >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("m_numTris")]
    public ushort @CountTris { get => SdkMemory.Read<ushort >(Pointer+78); set { SdkMemory.Write(Pointer+78,value); } }
    [NativeMember("m_tris")]
    public BreakTri_t? @Tris { get => SdkMemory.Read<IntPtr>(Pointer+80) == IntPtr.Zero ? null : new BreakTri_t(SdkMemory.Read<IntPtr>(Pointer+80)); set { SdkMemory.Write(Pointer+80,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+84) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+84)); set { SdkMemory.Write(Pointer+84,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_restAxisId")]
    public byte @RestAxisId { get => SdkMemory.Read<byte >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_restHeight")]
    public float @RestHeight { get => SdkMemory.Read<float >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_spinSpeed")]
    public float @SpinSpeed { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_spinAxis")]
    public RwV3d @SpinAxis { get => new RwV3d(Pointer+100); set { SdkMemory.Copy(value.Pointer,Pointer+100,12); } }
    [NativeMember("m_timer")]
    public int @Timer { get => SdkMemory.Read<int >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
}
