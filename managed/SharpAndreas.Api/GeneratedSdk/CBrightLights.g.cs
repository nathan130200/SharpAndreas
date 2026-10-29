// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBrightLights : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CBrightLights(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aBrightLights")]
    public static tBrightLight? @BrightLights { get => new IntPtr(0xC7CB58) == IntPtr.Zero ? null : new tBrightLight(new IntPtr(0xC7CB58)); }
    [NativeMember("NumBrightLights")]
    public static uint @CountBrightLights { get => SdkMemory.Read<uint >(new IntPtr(0xC7C6FC)); set { SdkMemory.Write(new IntPtr(0xC7C6FC),value); } }
    public static void @RenderOutGeometryBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1234 >(1234)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1235 >(1235)(); }
    public static void @RegisterOne(CVector @posn,CVector @top,CVector @right,CVector @at,byte @color,byte @arg5,byte @arg6,byte @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1236 >(1236)(@posn.Pointer,@top.Pointer,@right.Pointer,@at.Pointer,@color,@arg5,@arg6,@arg7); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1237 >(1237)(); }
}
