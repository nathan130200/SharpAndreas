namespace SharpAndreas;
/// <summary>A mod-owned RenderWare texture dictionary. Textures keep their own references after dictionary disposal.</summary>
public sealed class Txd:IDisposable
{
    private uint id;
    private readonly uint owner;
    private Txd(uint id) {this.id=id;owner=ModResources.Register(this);}
    public static async Task<Txd> LoadAsync(string file,CancellationToken cancellationToken=default)
    {
        Game.CheckThread();_ = TaskRuntime.CurrentOwner;using var cancellation=CancellationTokenSource.CreateLinkedTokenSource(cancellationToken,ModContext.Current!.CancellationToken);
        var bytes=await File.ReadAllBytesAsync(Path.GetFullPath(file),cancellation.Token);cancellation.Token.ThrowIfCancellationRequested();return Load(bytes);
    }
    private static unsafe Txd Load(byte[] bytes)
    {if(bytes.Length==0)throw new InvalidDataException("Empty TXD file.");fixed(byte* pointer=bytes) {var args=new HudRuntime.Args {Pixels=(IntPtr)pointer,PixelCount=bytes.Length};return new(checked((uint)HudRuntime.Call(16,HudRuntime.Owner,0,ref args)));}}
    public unsafe HudTexture GetTexture(string name)
    {
        Check();ArgumentException.ThrowIfNullOrWhiteSpace(name);if(name.Length>32 || name.Any(c=>c>127 || c=='\0'))throw new ArgumentException("Use an ASCII texture name of at most 32 characters.",nameof(name));
        fixed(char* text=name) {var args=new HudRuntime.Args {Text=(IntPtr)text};uint texture=checked((uint)HudRuntime.Call(17,owner,id,ref args));return new(texture,owner,args.TextureWidth,args.TextureHeight);}
    }
    private void Check() {ModResources.Check(owner);ObjectDisposedException.ThrowIf(id==0,this);}
    public void Dispose() {if(id==0)return;Check();var args=new HudRuntime.Args();HudRuntime.Call(18,owner,id,ref args);id=0;ModResources.Forget(owner,this);}
}
/// <summary>A reusable 2D sprite backed by a mod-owned RenderWare texture.</summary>
public sealed class Sprite(HudTexture texture)
{
    public HudTexture Texture {get;}=texture??throw new ArgumentNullException(nameof(texture));
    public void Draw(HudRect rectangle,HudColor? tint=null)=>Hud.DrawTexture(Texture,rectangle,tint);
}
