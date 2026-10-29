// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedTaskPair : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public CPedTaskPair(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pTask")]
    public CTask? @Task { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CTask(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("field_8")]
    public int @Field8 { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @Flush() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3253 >(3253)(Pointer); }
}
