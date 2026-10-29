// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CHudColours : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CHudColours(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_aColours")]
    public NativeObjectArray<CHudColour> @Colours { get => new NativeObjectArray<CHudColour>(Pointer+0,15,4); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2980 >(2980)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2981 >(2981)(Pointer); }
    public void @SetRGBAValue(byte @color,byte @red,byte @green,byte @blue,byte @alpha) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2982 >(2982)(Pointer,@color,@red,@green,@blue,@alpha); }
    public uint @GetIntColour(byte @color) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2983 >(2983)(Pointer,@color); return __sdkResult; }
    public CRGBA @GetRGB(byte @color,byte @alpha) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CRGBA >(4); try { SdkBindings.Get<GeneratedDelegates.D2984 >(2984)(Pointer,@color,@alpha,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CRGBA @GetRGBA(byte @color) { Game.CheckThread(); var result=NativeObject.AllocateStorage<CRGBA >(4); try { SdkBindings.Get<GeneratedDelegates.D2985 >(2985)(Pointer,@color,result.Pointer); return result; } catch { result.Dispose(); throw; } }
}
