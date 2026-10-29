// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColTrianglePlane : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=10;
    public CColTrianglePlane(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_normal")]
    public CompressedVector @Normal { get => new CompressedVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,6); } }
    [NativeMember("m_nDistance")]
    public ushort @Distance { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nOrientation")]
    public byte @Orientation { get => SdkMemory.Read<byte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @GetNormal(CVector @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D340 >(340)(Pointer,@out.Pointer); }
    public void @Set(CompressedVector? @vertices,CColTriangle @triangle) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D341 >(341)(Pointer,@vertices?.Pointer ?? IntPtr.Zero,@triangle.Pointer); }
}
