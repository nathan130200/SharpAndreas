// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CNodeAddress : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CNodeAddress(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("Region")]
    public ushort @Region { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("Index")]
    public ushort @Index { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D760 >(760)(Pointer); }
    public void @InitializeAt(short @areaId,short @nodeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D761 >(761)(Pointer,@areaId,@nodeId); }
    public void @Set(short @areaId,short @nodeId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D762 >(762)(Pointer,@areaId,@nodeId); }
    public bool @IsEmpty() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D763 >(763)(Pointer); return __sdkResult != 0; }
    public void @Clear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D764 >(764)(Pointer); }
    public bool @Operator_operator__(CNodeAddress @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D765 >(765)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator____901b1fa7(CNodeAddress @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D766 >(766)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
}
