// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCollisionEventScanner : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CCollisionEventScanner(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bAlreadyHitByCar")]
    public bool @AlreadyHitByCar { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    public void @ScanForCollisionEvents(CPed? @victim,CEventGroup? @eventGroup) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1299 >(1299)(Pointer,@victim?.Pointer ?? IntPtr.Zero,@eventGroup?.Pointer ?? IntPtr.Zero); }
}
