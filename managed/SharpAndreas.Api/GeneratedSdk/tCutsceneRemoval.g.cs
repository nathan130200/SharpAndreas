// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tCutsceneRemoval : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public tCutsceneRemoval(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_szObjectName")]
    public NativeArray<sbyte> @ObjectName { get => new NativeArray<sbyte>(Pointer+12,32); }
}
