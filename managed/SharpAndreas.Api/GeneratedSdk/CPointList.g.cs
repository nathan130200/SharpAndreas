// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPointList : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=316;
    public CPointList(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nCount")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_avCoords")]
    public NativeObjectArray<CVector> @Coordinates { get => new NativeObjectArray<CVector>(Pointer+4,24,12); }
    [NativeMember("m_abUsedCoords")]
    public NativeArray<bool> @UsedCoordinates { get => new NativeArray<bool>(Pointer+292,24); }
    public void @Empty() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2701 >(2701)(Pointer); }
}
