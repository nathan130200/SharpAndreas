// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexFacial : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CTaskComplexFacial(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bNotPlayer")]
    public bool @NotPlayer { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_bStarted")]
    public bool @Started { get => SdkMemory.Read<bool >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_bIsAborting")]
    public bool @IsAborting { get => SdkMemory.Read<bool >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nFacialExpression1")]
    public eFacialExpression @FacialExpression1 { get => SdkMemory.Read<eFacialExpression >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nDuration1")]
    public int @Duration1 { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nFacialExpression2")]
    public eFacialExpression @FacialExpression2 { get => SdkMemory.Read<eFacialExpression >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nDuration2")]
    public int @Duration2 { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4016 >(4016)(Pointer); }
}
