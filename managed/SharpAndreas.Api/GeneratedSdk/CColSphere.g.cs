// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColSphere : CSphere
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CColSphere(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nMaterial")]
    public byte @Material { get => SdkMemory.Read<byte >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+17); set { SdkMemory.Write(Pointer+17,value); } }
    [NativeMember("m_nLighting")]
    public byte @Lighting { get => SdkMemory.Read<byte >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_nLight")]
    public byte @Light { get => SdkMemory.Read<byte >(Pointer+19); set { SdkMemory.Write(Pointer+19,value); } }
    public void @Set(float @radius,CVector @center,byte @material,byte @flags,byte @lighting) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D320 >(320)(Pointer,@radius,@center.Pointer,@material,@flags,@lighting); }
    public bool @IntersectRay(CVector @rayStart,CVector @rayEnd,CVector @intPoint1,CVector @intPoint2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D321 >(321)(Pointer,@rayStart.Pointer,@rayEnd.Pointer,@intPoint1.Pointer,@intPoint2.Pointer); return __sdkResult != 0; }
}
