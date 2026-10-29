// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CColLine : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CColLine(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecStart")]
    public CVector @Start { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_fStartSize")]
    public float @StartSize { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_vecEnd")]
    public CVector @End { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_fEndSize")]
    public float @EndSize { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt(CVector @start,CVector @end) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D324 >(324)(Pointer,@start.Pointer,@end.Pointer); }
    public void @Set(CVector @start,CVector @end) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D325 >(325)(Pointer,@start.Pointer,@end.Pointer); }
}
