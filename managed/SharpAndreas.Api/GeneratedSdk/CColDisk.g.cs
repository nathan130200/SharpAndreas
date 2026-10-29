// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColDisk : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CColDisk(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecStart")]
    public CVector @Start { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fStartRadius")]
    public float @StartRadius { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nMaterial")]
    public byte @Material { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nPiece")]
    public byte @Piece { get => SdkMemory.Read<byte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("m_nLighting")]
    public byte @Lighting { get => SdkMemory.Read<byte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_vecEnd")]
    public CVector @End { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_fEndRadius")]
    public float @EndRadius { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    public void @Set(float @startRadius,CVector @start,CVector @end,float @endRadius,byte @material,byte @pieceType,byte @lighting) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D342 >(342)(Pointer,@startRadius,@start.Pointer,@end.Pointer,@endRadius,@material,@pieceType,@lighting); }
}
