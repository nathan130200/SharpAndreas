// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColBox : CBox
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CColBox(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nMaterial")]
    public byte @Material { get => SdkMemory.Read<byte >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+25); set { SdkMemory.Write(Pointer+25,value); } }
    [NativeMember("m_nLighting")]
    public byte @Lighting { get => SdkMemory.Read<byte >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nLight")]
    public byte @Light { get => SdkMemory.Read<byte >(Pointer+27); set { SdkMemory.Write(Pointer+27,value); } }
    public void @Set(CVector @sup,CVector @inf,byte @material,byte @flags,byte @lighting) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D322 >(322)(Pointer,@sup.Pointer,@inf.Pointer,@material,@flags,@lighting); }
    public void @AssignNative(CColBox @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D323 >(323)(Pointer,@right.Pointer); }
}
