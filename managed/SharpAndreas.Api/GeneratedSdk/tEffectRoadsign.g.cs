// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tEffectRoadsign : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public tEffectRoadsign(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecSize")]
    public RwV2d @Size { get => new RwV2d(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("m_afRotation")]
    public NativeArray<float> @Rotation { get => new NativeArray<float>(Pointer+8,3); }
    [NativeMember("m_nFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_pText")]
    public NativePointer<sbyte> @Text { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("m_pAtomic")]
    public RpAtomic? @Atomic { get => SdkMemory.Read<IntPtr>(Pointer+28) == IntPtr.Zero ? null : new RpAtomic(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value?.Pointer ?? IntPtr.Zero); } }
}
