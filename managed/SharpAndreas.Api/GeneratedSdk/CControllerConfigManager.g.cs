// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CControllerConfigManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4836;
    public CControllerConfigManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public sbyte @Field0 { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_1")]
    public sbyte @Field1 { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("field_2")]
    public sbyte @Field2 { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("field_3")]
    public sbyte @Field3 { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_prevPadState")]
    public DIJOYSTATE2 @PrevPadState { get => new DIJOYSTATE2(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,272); } }
    [NativeMember("m_currPadState")]
    public DIJOYSTATE2 @CurrPadState { get => new DIJOYSTATE2(Pointer+276); set { SdkMemory.Copy(value.Pointer,Pointer+276,272); } }
    [NativeMember("m_aszEventNames")]
    public NativeArray<sbyte> @EventNames { get => new NativeArray<sbyte>(Pointer+548,2360); }
    [NativeMember("field_B5C")]
    public NativeArray<sbyte> @FieldB5C { get => new NativeArray<sbyte>(Pointer+2908,17); }
    [NativeMember("_pad1")]
    public NativeArray<sbyte> @Pad1 { get => new NativeArray<sbyte>(Pointer+2925,3); }
    [NativeMember("m_actions")]
    public NativeObjectArray<CControllerAction> @Actions { get => new NativeObjectArray<CControllerAction>(Pointer+2928,59,32); }
    [NativeMember("field_12D0")]
    public NativeArray<sbyte> @Field12D0 { get => new NativeArray<sbyte>(Pointer+4816,16); }
    [NativeMember("field_12E0")]
    public sbyte @Field12E0 { get => SdkMemory.Read<sbyte >(Pointer+4832); set { SdkMemory.Write(Pointer+4832,value); } }
    [NativeMember("_pad2")]
    public NativeArray<sbyte> @Pad2 { get => new NativeArray<sbyte>(Pointer+4833,3); }
    public void @SaveSettings(int @file) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2274 >(2274)(Pointer,@file); }
    public bool @LoadSettings(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2275 >(2275)(Pointer,@file); return __sdkResult != 0; }
    public bool @GetIsKeyboardKeyDown(RsKeyCodes @key) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2276 >(2276)(Pointer,(int)@key); return __sdkResult != 0; }
    public bool @GetIsKeyboardKeyJustDown(RsKeyCodes @key) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2277 >(2277)(Pointer,(int)@key); return __sdkResult != 0; }
    public void @ResetSettingOrder(e_ControllerAction @action) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2278 >(2278)(Pointer,(int)@action); }
}
