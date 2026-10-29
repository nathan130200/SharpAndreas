// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CLines : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CLines(System.IntPtr pointer) : base(pointer) {}
    public static void @RenderLineNoClipping(float @startX,float @startY,float @startZ,float @endX,float @endY,float @endZ,uint @startColor,uint @endColor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3022 >(3022)(@startX,@startY,@startZ,@endX,@endY,@endZ,@startColor,@endColor); }
    public static void @RenderLineWithClipping(float @startX,float @startY,float @startZ,float @endX,float @endY,float @endZ,uint @startColor,uint @endColor) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3023 >(3023)(@startX,@startY,@startZ,@endX,@endY,@endZ,@startColor,@endColor); }
    public static void @ImmediateLine2D(int @startX,int @startY,int @endX,int @endY,byte @startR,byte @startG,byte @startB,byte @startA,byte @endR,byte @endG,byte @endB,byte @endA) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3024 >(3024)(@startX,@startY,@endX,@endY,@startR,@startG,@startB,@startA,@endR,@endG,@endB,@endA); }
}
