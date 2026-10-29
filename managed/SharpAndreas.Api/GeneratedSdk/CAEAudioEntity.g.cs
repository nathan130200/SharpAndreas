// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAEAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public CAEAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_tempSound")]
    public CAESound @TempSound { get => new CAESound(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,116); } }
    public void @UpdateParameters(CAESound? @sound,short @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D249 >(249)(Pointer,@sound?.Pointer ?? IntPtr.Zero,@arg2); }
}
