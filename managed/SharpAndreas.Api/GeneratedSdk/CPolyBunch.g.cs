// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPolyBunch : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=104;
    public CPolyBunch(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_avecPosn")]
    public NativeObjectArray<CVector> @Position { get => new NativeObjectArray<CVector>(Pointer+0,7,12); }
    [NativeMember("m_pNext")]
    public NativePointer<IntPtr> @Next { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+84)); set { SdkMemory.Write(Pointer+84,value.Pointer); } }
    [NativeMember("m_wNumVerts")]
    public ushort @CountVerts { get => SdkMemory.Read<ushort >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_aU")]
    public NativeArray<sbyte> @U { get => new NativeArray<sbyte>(Pointer+90,7); }
    [NativeMember("m_aV")]
    public NativeArray<sbyte> @V { get => new NativeArray<sbyte>(Pointer+97,7); }
}
