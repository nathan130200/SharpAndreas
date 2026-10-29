// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScriptAttachedAnimGroup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public tScriptAttachedAnimGroup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nModelID")]
    public int @ModelID { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_IfpName")]
    public NativeArray<sbyte> @IfpName { get => new NativeArray<sbyte>(Pointer+4,16); }
}
