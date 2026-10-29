// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxPrtMult_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public FxPrtMult_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_color")]
    public RwRGBAReal @Color { get => new RwRGBAReal(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("field_14")]
    public float @Field14 { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fLife")]
    public float @Life { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D802 >(802)(Pointer); }
    public void @InitializeAt(float @red,float @green,float @blue,float @alpha,float @size,float @arg5,float @lastFactor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D803 >(803)(Pointer,@red,@green,@blue,@alpha,@size,@arg5,@lastFactor); }
    public void @SetUp(float @red,float @green,float @blue,float @alpha,float @size,float @arg5,float @lastFactor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D804 >(804)(Pointer,@red,@green,@blue,@alpha,@size,@arg5,@lastFactor); }
}
