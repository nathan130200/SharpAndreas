// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class DecisionChances : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public DecisionChances(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("toNeutral")]
    public byte @ToNeutral { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("toPlayer")]
    public byte @ToPlayer { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("toFriend")]
    public byte @ToFriend { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("toEnemy")]
    public byte @ToEnemy { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1256 >(1256)(Pointer); }
    public void @InitializeAt(byte @toNeutral,byte @toPlayer,byte @toFriend,byte @toEnemy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1257 >(1257)(Pointer,@toNeutral,@toPlayer,@toFriend,@toEnemy); }
}
