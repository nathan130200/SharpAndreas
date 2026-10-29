// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tFontData : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=210;
    public tFontData(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_propValues")]
    public NativeArray<sbyte> @PropValues { get => new NativeArray<sbyte>(Pointer+0,208); }
    [NativeMember("m_spaceValue")]
    public sbyte @SpaceValue { get => SdkMemory.Read<sbyte >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("m_unpropValue")]
    public sbyte @UnpropValue { get => SdkMemory.Read<sbyte >(Pointer+209); set { SdkMemory.Write(Pointer+209,value); } }
}
