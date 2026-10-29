// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLoadedCarGroup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=46;
    public CLoadedCarGroup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_members")]
    public NativeArray<short> @Members { get => new NativeArray<short>(Pointer+0,22); }
    [NativeMember("field_2C")]
    public short @Field2C { get => SdkMemory.Read<short >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    public void @SortBasedOnUsage() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3025 >(3025)(Pointer); }
    public int @RemoveMember(int @modelindex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3026 >(3026)(Pointer,@modelindex); return __sdkResult; }
    public int @PickRandomCar(bool @arg1,bool @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3027 >(3027)(Pointer,(@arg1 ? 1 : 0),(@arg2 ? 1 : 0)); return __sdkResult; }
    public int @PickLeastUsedModel(int @minRefs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3028 >(3028)(Pointer,@minRefs); return __sdkResult; }
    public int @GetMember(int @count) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3029 >(3029)(Pointer,@count); return __sdkResult; }
    public uint @CountMembers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3030 >(3030)(Pointer); return __sdkResult; }
    public void @Clear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3031 >(3031)(Pointer); }
    public void @AddMember(int @member) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3032 >(3032)(Pointer,@member); }
}
