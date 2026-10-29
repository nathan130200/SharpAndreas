// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CKeyboardState : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=624;
    public CKeyboardState(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("FKeys")]
    public NativeArray<short> @FKeys { get => new NativeArray<short>(Pointer+0,12); }
    [NativeMember("standardKeys")]
    public NativeArray<short> @StandardKeys { get => new NativeArray<short>(Pointer+24,256); }
    [NativeMember("esc")]
    public short @Esc { get => SdkMemory.Read<short >(Pointer+536); set { SdkMemory.Write(Pointer+536,value); } }
    [NativeMember("insert")]
    public short @Insert { get => SdkMemory.Read<short >(Pointer+538); set { SdkMemory.Write(Pointer+538,value); } }
    [NativeMember("del")]
    public short @Del { get => SdkMemory.Read<short >(Pointer+540); set { SdkMemory.Write(Pointer+540,value); } }
    [NativeMember("home")]
    public short @Home { get => SdkMemory.Read<short >(Pointer+542); set { SdkMemory.Write(Pointer+542,value); } }
    [NativeMember("end")]
    public short @End { get => SdkMemory.Read<short >(Pointer+544); set { SdkMemory.Write(Pointer+544,value); } }
    [NativeMember("pgup")]
    public short @Pgup { get => SdkMemory.Read<short >(Pointer+546); set { SdkMemory.Write(Pointer+546,value); } }
    [NativeMember("pgdn")]
    public short @Pgdn { get => SdkMemory.Read<short >(Pointer+548); set { SdkMemory.Write(Pointer+548,value); } }
    [NativeMember("up")]
    public short @Up { get => SdkMemory.Read<short >(Pointer+550); set { SdkMemory.Write(Pointer+550,value); } }
    [NativeMember("down")]
    public short @Down { get => SdkMemory.Read<short >(Pointer+552); set { SdkMemory.Write(Pointer+552,value); } }
    [NativeMember("left")]
    public short @Left { get => SdkMemory.Read<short >(Pointer+554); set { SdkMemory.Write(Pointer+554,value); } }
    [NativeMember("right")]
    public short @Right { get => SdkMemory.Read<short >(Pointer+556); set { SdkMemory.Write(Pointer+556,value); } }
    [NativeMember("scroll")]
    public short @Scroll { get => SdkMemory.Read<short >(Pointer+558); set { SdkMemory.Write(Pointer+558,value); } }
    [NativeMember("pause")]
    public short @Pause { get => SdkMemory.Read<short >(Pointer+560); set { SdkMemory.Write(Pointer+560,value); } }
    [NativeMember("numlock")]
    public short @Numlock { get => SdkMemory.Read<short >(Pointer+562); set { SdkMemory.Write(Pointer+562,value); } }
    [NativeMember("div")]
    public short @Div { get => SdkMemory.Read<short >(Pointer+564); set { SdkMemory.Write(Pointer+564,value); } }
    [NativeMember("mul")]
    public short @Mul { get => SdkMemory.Read<short >(Pointer+566); set { SdkMemory.Write(Pointer+566,value); } }
    [NativeMember("sub")]
    public short @Sub { get => SdkMemory.Read<short >(Pointer+568); set { SdkMemory.Write(Pointer+568,value); } }
    [NativeMember("add")]
    public short @Add { get => SdkMemory.Read<short >(Pointer+570); set { SdkMemory.Write(Pointer+570,value); } }
    [NativeMember("enter")]
    public short @Enter { get => SdkMemory.Read<short >(Pointer+572); set { SdkMemory.Write(Pointer+572,value); } }
    [NativeMember("decimal")]
    public short @Decimal { get => SdkMemory.Read<short >(Pointer+574); set { SdkMemory.Write(Pointer+574,value); } }
    [NativeMember("num1")]
    public short @Num1 { get => SdkMemory.Read<short >(Pointer+576); set { SdkMemory.Write(Pointer+576,value); } }
    [NativeMember("num2")]
    public short @Num2 { get => SdkMemory.Read<short >(Pointer+578); set { SdkMemory.Write(Pointer+578,value); } }
    [NativeMember("num3")]
    public short @Num3 { get => SdkMemory.Read<short >(Pointer+580); set { SdkMemory.Write(Pointer+580,value); } }
    [NativeMember("num4")]
    public short @Num4 { get => SdkMemory.Read<short >(Pointer+582); set { SdkMemory.Write(Pointer+582,value); } }
    [NativeMember("num5")]
    public short @Num5 { get => SdkMemory.Read<short >(Pointer+584); set { SdkMemory.Write(Pointer+584,value); } }
    [NativeMember("num6")]
    public short @Num6 { get => SdkMemory.Read<short >(Pointer+586); set { SdkMemory.Write(Pointer+586,value); } }
    [NativeMember("num7")]
    public short @Num7 { get => SdkMemory.Read<short >(Pointer+588); set { SdkMemory.Write(Pointer+588,value); } }
    [NativeMember("num8")]
    public short @Num8 { get => SdkMemory.Read<short >(Pointer+590); set { SdkMemory.Write(Pointer+590,value); } }
    [NativeMember("num9")]
    public short @Num9 { get => SdkMemory.Read<short >(Pointer+592); set { SdkMemory.Write(Pointer+592,value); } }
    [NativeMember("num0")]
    public short @Num0 { get => SdkMemory.Read<short >(Pointer+594); set { SdkMemory.Write(Pointer+594,value); } }
    [NativeMember("back")]
    public short @Back { get => SdkMemory.Read<short >(Pointer+596); set { SdkMemory.Write(Pointer+596,value); } }
    [NativeMember("tab")]
    public short @Tab { get => SdkMemory.Read<short >(Pointer+598); set { SdkMemory.Write(Pointer+598,value); } }
    [NativeMember("capslock")]
    public short @Capslock { get => SdkMemory.Read<short >(Pointer+600); set { SdkMemory.Write(Pointer+600,value); } }
    [NativeMember("extenter")]
    public short @Extenter { get => SdkMemory.Read<short >(Pointer+602); set { SdkMemory.Write(Pointer+602,value); } }
    [NativeMember("lshift")]
    public short @Lshift { get => SdkMemory.Read<short >(Pointer+604); set { SdkMemory.Write(Pointer+604,value); } }
    [NativeMember("rshift")]
    public short @Rshift { get => SdkMemory.Read<short >(Pointer+606); set { SdkMemory.Write(Pointer+606,value); } }
    [NativeMember("shift")]
    public short @Shift { get => SdkMemory.Read<short >(Pointer+608); set { SdkMemory.Write(Pointer+608,value); } }
    [NativeMember("lctrl")]
    public short @Lctrl { get => SdkMemory.Read<short >(Pointer+610); set { SdkMemory.Write(Pointer+610,value); } }
    [NativeMember("rctrl")]
    public short @Rctrl { get => SdkMemory.Read<short >(Pointer+612); set { SdkMemory.Write(Pointer+612,value); } }
    [NativeMember("lmenu")]
    public short @Lmenu { get => SdkMemory.Read<short >(Pointer+614); set { SdkMemory.Write(Pointer+614,value); } }
    [NativeMember("rmenu")]
    public short @Rmenu { get => SdkMemory.Read<short >(Pointer+616); set { SdkMemory.Write(Pointer+616,value); } }
    [NativeMember("lwin")]
    public short @Lwin { get => SdkMemory.Read<short >(Pointer+618); set { SdkMemory.Write(Pointer+618,value); } }
    [NativeMember("rwin")]
    public short @Rwin { get => SdkMemory.Read<short >(Pointer+620); set { SdkMemory.Write(Pointer+620,value); } }
    [NativeMember("apps")]
    public short @Apps { get => SdkMemory.Read<short >(Pointer+622); set { SdkMemory.Write(Pointer+622,value); } }
}
