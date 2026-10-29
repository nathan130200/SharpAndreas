using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpAndreas;

public readonly record struct HudColor(byte R,byte G,byte B,byte A=255)
{
    public uint Argb=>((uint)A<<24)|((uint)R<<16)|((uint)G<<8)|B;
    public static HudColor White=>new(255,255,255);
    public static HudColor Transparent=>new(0,0,0,0);
}
public readonly record struct HudRect(float X,float Y,float Width,float Height);

/// <summary>Reusable CPU canvas with straight-alpha 0xAARRGGBB pixels for a RenderWare texture.</summary>
public sealed class TextureCanvas
{
    private readonly uint[] pixels;
    public int Width {get;}
    public int Height {get;}
    public Span<uint> Pixels=>pixels;
    public TextureCanvas(int width,int height)
    {
        if(width is <1 or >2048 || height is <1 or >2048)throw new ArgumentOutOfRangeException(nameof(width));
        Width=width;Height=height;pixels=new uint[width*height];
    }
    public void Clear(HudColor color)=>pixels.AsSpan().Fill(color.Argb);
    public void FillRectangle(int x,int y,int width,int height,HudColor color)
    {
        if(width<0 || height<0)throw new ArgumentOutOfRangeException(nameof(width));
        int left=Math.Clamp(x,0,Width),top=Math.Clamp(y,0,Height);
        int right=(int)Math.Clamp((long)x+width,0,Width),bottom=(int)Math.Clamp((long)y+height,0,Height);
        for(int row=top;row<bottom;row++)pixels.AsSpan(row*Width+left,Math.Max(0,right-left)).Fill(color.Argb);
    }
}

/// <summary>Mod-owned native RenderWare texture; dispose on the game thread.</summary>
public sealed class HudTexture:IDisposable
{
    internal uint Id;
    internal readonly uint Owner;
    public int Width {get;}
    public int Height {get;}
    internal HudTexture(uint id,uint owner,int width,int height) {Id=id;Owner=owner;Width=width;Height=height;}
    public HudTexture(int width,int height)
    {
        Game.CheckThread();
        if(width is <1 or >2048 || height is <1 or >2048)throw new ArgumentOutOfRangeException(nameof(width));
        Owner=HudRuntime.Owner;Width=width;Height=height;
        var args=new HudRuntime.Args {TextureWidth=width,TextureHeight=height};
        Id=checked((uint)HudRuntime.Call(3,Owner,0,ref args));
    }
    public void Update(TextureCanvas canvas)
    {
        ArgumentNullException.ThrowIfNull(canvas);
        if(canvas.Width!=Width || canvas.Height!=Height)throw new ArgumentException("Canvas and texture sizes must match.",nameof(canvas));
        Update(canvas.Pixels);
    }
    public unsafe void Update(ReadOnlySpan<uint> argbPixels)
    {
        Check();
        if(argbPixels.Length!=Width*Height)throw new ArgumentException("Supply exactly Width*Height straight-alpha ARGB pixels.",nameof(argbPixels));
        fixed(uint* pixels=argbPixels)
        {
            var args=new HudRuntime.Args {Pixels=(IntPtr)pixels,PixelCount=argbPixels.Length};
            HudRuntime.Call(4,Owner,Id,ref args);
        }
    }
    internal void Check()
    {
        Game.CheckThread();ObjectDisposedException.ThrowIf(Id==0,this);
        if(Owner!=HudRuntime.Owner)throw new InvalidOperationException("HUD textures cannot cross mod ownership boundaries.");
    }
    public void Dispose()
    {
        if(Id==0)return;
        Check();var args=new HudRuntime.Args();HudRuntime.Call(5,Owner,Id,ref args);Id=0;
    }
}

/// <summary>Drawing is permitted only inside Mod.Draw; coordinates are current screen pixels.</summary>
public static class Hud
{
    public static Vector2 ScreenSize
    {
        get {Game.CheckThread();var args=new HudRuntime.Args();HudRuntime.Call(0,0,0,ref args);return new(args.Width,args.Height);}
    }
    public static void DrawRectangle(HudRect rectangle,HudColor color)
    {
        HudRuntime.CheckDraw();Validate(rectangle);
        var args=new HudRuntime.Args {X=rectangle.X,Y=rectangle.Y,Width=rectangle.Width,Height=rectangle.Height,Color=color.Argb};
        HudRuntime.Call(6,HudRuntime.Owner,0,ref args);
    }
    public static unsafe void DrawText(string text,Vector2 position,HudColor color,float scale=1)
    {
        HudRuntime.CheckDraw();ArgumentNullException.ThrowIfNull(text);
        if(text.Length>1024 || text.Contains('\0'))throw new ArgumentException("Text must contain at most 1024 characters and no NUL.",nameof(text));
        if(!float.IsFinite(position.X) || !float.IsFinite(position.Y) || !float.IsFinite(scale) || scale<=0 || scale>10)throw new ArgumentOutOfRangeException(nameof(scale));
        fixed(char* value=text)
        {
            var args=new HudRuntime.Args {X=position.X,Y=position.Y,Scale=scale,Color=color.Argb,Text=(IntPtr)value};
            HudRuntime.Call(7,HudRuntime.Owner,0,ref args);
        }
    }
    public static void DrawTexture(HudTexture texture,HudRect rectangle,HudColor? tint=null)
    {
        HudRuntime.CheckDraw();ArgumentNullException.ThrowIfNull(texture);texture.Check();Validate(rectangle);
        var args=new HudRuntime.Args {X=rectangle.X,Y=rectangle.Y,Width=rectangle.Width,Height=rectangle.Height,Color=(tint??HudColor.White).Argb};
        HudRuntime.Call(8,texture.Owner,texture.Id,ref args);
    }
    public static bool TryProject(Vector3 worldPosition,out Vector2 screenPosition)
    {
        Game.CheckThread();Entity.ValidatePosition(worldPosition);
        var args=new HudRuntime.Args {X=worldPosition.X,Y=worldPosition.Y,Z=worldPosition.Z,Ped=-1};
        bool visible=HudRuntime.Call(9,HudRuntime.Owner,0,ref args)!=0;
        screenPosition=visible?new(args.X,args.Y):default;return visible;
    }
    public static bool TryProjectHead(Char ped,out Vector2 screenPosition)
    {
        Game.CheckThread();ArgumentNullException.ThrowIfNull(ped);
        if(!ped.Exists) {screenPosition=default;return false;}
        var args=new HudRuntime.Args {Ped=ped.Handle,Bone=8};
        bool visible=HudRuntime.Call(9,HudRuntime.Owner,0,ref args)!=0;
        screenPosition=visible?new(args.X,args.Y):default;return visible;
    }
    public static bool TryProjectAboveVehicle(Vehicle vehicle,out Vector2 screenPosition,float offset=0.25f)
    {
        Game.CheckThread();ArgumentNullException.ThrowIfNull(vehicle);
        if(!float.IsFinite(offset) || offset<0)throw new ArgumentOutOfRangeException(nameof(offset));
        if(!vehicle.Exists) {screenPosition=default;return false;}
        var args=new HudRuntime.Args {Ped=vehicle.Handle,Bone=-1,Scale=offset};
        bool visible=HudRuntime.Call(9,HudRuntime.Owner,0,ref args)!=0;
        screenPosition=visible?new(args.X,args.Y):default;return visible;
    }
    private static void Validate(HudRect value)
    {
        if(!float.IsFinite(value.X) || !float.IsFinite(value.Y) || !float.IsFinite(value.Width) || !float.IsFinite(value.Height) || value.Width<0 || value.Height<0)
            throw new ArgumentOutOfRangeException(nameof(value));
    }
}

internal static class HudRuntime
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Args
    {
        public float X,Y,Width,Height,Z,Scale;
        public uint Color;
        public IntPtr Text,Pixels;
        public int PixelCount,TextureWidth,TextureHeight,Ped,Bone;
    }
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private unsafe delegate int Bridge(int operation,uint owner,uint texture,Args* args);
    private static Bridge bridge=null!;
    private static uint drawing;
    internal static uint Owner {get {Game.CheckThread();return ModContext.Current?.TaskOwner??throw new InvalidOperationException("HUD resources require a running mod context.");}}
    internal static void Bind(IntPtr pointer)=>bridge=Marshal.GetDelegateForFunctionPointer<Bridge>(pointer);
    internal static unsafe int Call(int operation,uint owner,uint texture,ref Args args)
    {
        Game.CheckThread();fixed(Args* pointer=&args)
        {
            int result=bridge(operation,owner,texture,pointer);
            if(result<0)throw new InvalidOperationException($"Native HUD operation {operation} failed ({result}).");
            return result;
        }
    }
    internal static unsafe void SetProfiler(string text)
    {
        fixed(char* value=text) {var args=new Args {Text=(IntPtr)value};Call(12,0,0,ref args);}
    }
    internal static bool Begin(uint owner)
    {
        var args=new Args();if(Call(1,owner,0,ref args)==0)return false;
        drawing=owner;return true;
    }
    internal static void End(uint owner)
    {
        try {var args=new Args();Call(2,owner,0,ref args);}finally {drawing=0;}
    }
    internal static void Release(uint owner) {var args=new Args();Call(10,owner,0,ref args);}
    internal static void CheckDraw()
    {
        if(drawing==0 || drawing!=Owner)throw new InvalidOperationException("Issue HUD draw commands from Mod.Draw.");
    }
}
