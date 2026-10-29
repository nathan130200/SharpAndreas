// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class ColDef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public ColDef(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_Area")]
    public CRect @Area { get => new CRect(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("name")]
    public NativeArray<sbyte> @Name { get => new NativeArray<sbyte>(Pointer+16,18); }
    [NativeMember("m_nModelIdStart")]
    public short @ModelIdStart { get => SdkMemory.Read<short >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("m_nModelIdEnd")]
    public short @ModelIdEnd { get => SdkMemory.Read<short >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nRefCount")]
    public ushort @RefCount { get => SdkMemory.Read<ushort >(Pointer+38); set { SdkMemory.Write(Pointer+38,value); } }
    [NativeMember("m_bActive")]
    public bool @Active { get => SdkMemory.Read<bool >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_bCollisionIsRequired")]
    public bool @CollisionIsRequired { get => SdkMemory.Read<bool >(Pointer+41); set { SdkMemory.Write(Pointer+41,value); } }
    [NativeMember("m_bProcedural")]
    public bool @Procedural { get => SdkMemory.Read<bool >(Pointer+42); set { SdkMemory.Write(Pointer+42,value); } }
    [NativeMember("m_bInterior")]
    public bool @Interior { get => SdkMemory.Read<bool >(Pointer+43); set { SdkMemory.Write(Pointer+43,value); } }
}
