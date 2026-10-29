// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tCarGenPlateText : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public tCarGenPlateText(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCarGenId")]
    public int @CarGenId { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_szPlateText")]
    public NativeArray<sbyte> @PlateText { get => new NativeArray<sbyte>(Pointer+4,12); }
}
