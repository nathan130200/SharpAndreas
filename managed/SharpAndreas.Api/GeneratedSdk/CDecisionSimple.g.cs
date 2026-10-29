// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDecisionSimple : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=52;
    public CDecisionSimple(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_anTasks")]
    public NativeArray<int> @Tasks { get => new NativeArray<int>(Pointer+0,6); }
    [NativeMember("m_afChances")]
    public NativeArray<float> @Chances { get => new NativeArray<float>(Pointer+24,6); }
    [NativeMember("m_nCount")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    public void @Set(NativePointer<int> @taskTypes,NativePointer<byte> @chances,int @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2485 >(2485)(Pointer,@taskTypes.Pointer,@chances.Pointer,@count); }
    public void @MakeDecision(int @taskType,NativePointer<short> @outTaskType,NativePointer<int> @outDecisionIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2486 >(2486)(Pointer,@taskType,@outTaskType.Pointer,@outDecisionIndex.Pointer); }
    public void @SetDefault() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2487 >(2487)(Pointer); }
}
