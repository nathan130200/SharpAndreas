// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class C_PcSave : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public C_PcSave(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("nErrorCode")]
    public eSaveStatus @ErrorCode { get => SdkMemory.Read<eSaveStatus >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    public void @PopulateSlotInfo() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D211 >(211)(Pointer); }
    public bool @DeleteSlot(int @slot) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D212 >(212)(Pointer,@slot); return __sdkResult != 0; }
    public bool @SaveSlot(int @slot) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D213 >(213)(Pointer,@slot); return __sdkResult != 0; }
    public static void @SetSaveDirectory(NativePointer<sbyte> @path) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D214 >(214)(@path.Pointer); }
}
