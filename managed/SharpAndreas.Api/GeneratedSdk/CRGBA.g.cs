// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRGBA : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CRGBA(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("r")]
    public byte @R { get => SdkMemory.Read<byte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("g")]
    public byte @G { get => SdkMemory.Read<byte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("b")]
    public byte @B { get => SdkMemory.Read<byte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("a")]
    public byte @A { get => SdkMemory.Read<byte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    public void @InitializeAt(byte @red,byte @green,byte @blue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D98 >(98)(Pointer,@red,@green,@blue); }
    public void @InitializeAt(byte @red,byte @green,byte @blue,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D99 >(99)(Pointer,@red,@green,@blue,@alpha); }
    public void @InitializeAt(CRGBA @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D100 >(100)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(uint @intValue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D101 >(101)(Pointer,@intValue); }
    public void @InitializeAt(RwRGBA @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D102 >(102)(Pointer,@rhs.Pointer); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D103 >(103)(Pointer); }
    public void @Set(byte @red,byte @green,byte @blue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D104 >(104)(Pointer,@red,@green,@blue); }
    public void @Set(byte @red,byte @green,byte @blue,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D105 >(105)(Pointer,@red,@green,@blue,@alpha); }
    public void @Set(uint @intValue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D106 >(106)(Pointer,@intValue); }
    public void @Set(CRGBA @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D107 >(107)(Pointer,@rhs.Pointer); }
    public void @Set(CRGBA @rhs,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D108 >(108)(Pointer,@rhs.Pointer,@alpha); }
    public void @Set(RwRGBA @rwcolor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D109 >(109)(Pointer,@rwcolor.Pointer); }
    public CRGBA @ToRGB() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CRGBA >(4); try { SdkBindings.Get<GeneratedDelegates.D110 >(110)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public uint @ToInt() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D111 >(111)(Pointer); return __sdkResult; }
    public uint @ToIntARGB() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D112 >(112)(Pointer); return __sdkResult; }
    public RwRGBA @ToRwRGBA() { Game.CheckThread(); var result=NativeObject.AllocateStorage<RwRGBA >(4); try { SdkBindings.Get<GeneratedDelegates.D113 >(113)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @FromRwRGBA(RwRGBA @rwcolor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D114 >(114)(Pointer,@rwcolor.Pointer); }
    public void @FromARGB(uint @intValue) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D115 >(115)(Pointer,@intValue); }
    public void @Invert() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D116 >(116)(Pointer); }
    public CRGBA @Inverted() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CRGBA >(4); try { SdkBindings.Get<GeneratedDelegates.D117 >(117)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @Operator_operator__(CRGBA @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D118 >(118)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public CRGBA @AssignNative(CRGBA @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D119 >(119)(Pointer,@rhs.Pointer); return new CRGBA(__sdkResult); }
    public void @AddAssignNative(CRGBA @right) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D120 >(120)(Pointer,@right.Pointer); }
}
