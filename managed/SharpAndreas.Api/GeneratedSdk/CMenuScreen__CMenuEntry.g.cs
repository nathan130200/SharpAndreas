// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMenuScreen__CMenuEntry : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=18;
    public CMenuScreen__CMenuEntry(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nAction")]
    public byte @Action { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_EntryName")]
    public NativeArray<sbyte> @EntryName { get => new NativeArray<sbyte>(Pointer+1,8); }
    [NativeMember("m_nSaveSlot")]
    public byte @SaveSlot { get => SdkMemory.Read<byte >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_nTargetMenu")]
    public sbyte @TargetMenu { get => SdkMemory.Read<sbyte >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("pad")]
    public byte @Pad { get => SdkMemory.Read<byte >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_nX")]
    public ushort @X { get => SdkMemory.Read<ushort >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nY")]
    public ushort @Y { get => SdkMemory.Read<ushort >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nAlign")]
    public byte @Align { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
