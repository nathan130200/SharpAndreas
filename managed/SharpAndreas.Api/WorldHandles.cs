using System.Numerics;
namespace SharpAndreas;
public enum PickupType {None,InShop,OnStreet,Once,OnceTimeout,OnceTimeoutSlow,Collectable,InShopOutOfStock,Money,MineInactive,MineArmed,NauticalMineInactive,NauticalMineArmed,FloatingPackage,FloatingPackageFloating,OnStreetSlow,AssetRevenue,PropertyLocked,PropertyForSale,PersistentMoney,Snapshot,TwoPlayer,OnceForMission}
public sealed class Pickup:IDisposable
{
    private readonly bool owned;
    private readonly uint owner;
    private bool disposed;
    private readonly Lazy<Sdk.CPickup> native;
    private Pickup(int handle,bool owned)
    {if(handle<0)throw new ArgumentOutOfRangeException(nameof(handle));Handle=handle;this.owned=owned;owner=owned?ModResources.Register(this):0;native=new(()=>new Sdk.CPickup(Info().Data),LazyThreadSafetyMode.ExecutionAndPublication);}
    public int Handle {get;}
    public static Pickup FromHandle(int handle)=>new(handle,false);
    public bool Exists=>!disposed && Scm.Call((ushort)0x09D1,Handle);
    private void Check() {if(owned)ModResources.Check(owner);if(!Exists)throw new InvalidOperationException("Pickup no longer exists.");}
    private GameServices.Args Info() {Check();var args=new GameServices.Args {First=Handle};if(GameServices.Call(1,ref args)==0)throw new InvalidOperationException("Pickup no longer exists.");return args;}
    public Sdk.CPickup Native {get {Check();return native.Value;}}
    public int Model=>Info().First;
    public PickupType Type=>(PickupType)Info().Second;
    public Vector3 Position {get {Check();return Commands.Vector(0x065B,Handle);}}
    /// <summary>Tests and consumes the game's collected-pickup notification.</summary>
    public bool WasCollected {get {if(owned)ModResources.Check(owner);return !disposed && Scm.Call((ushort)0x0214,Handle);}}
    public static async Task<Pickup> CreateAsync(int model,PickupType type,Vector3 position,int? ammo=null,CancellationToken cancellationToken=default)
    {
        Game.CheckThread();_ = TaskRuntime.CurrentOwner;Entity.ValidatePosition(position);if(!Enum.IsDefined(type) || type==PickupType.None)throw new ArgumentOutOfRangeException(nameof(type));if(ammo<0)throw new ArgumentOutOfRangeException(nameof(ammo));
        await Models.RequestAsync(model,cancellationToken);
        try {cancellationToken.ThrowIfCancellationRequested();var result=new ScmVariable(-1);if(ammo is {} count)Scm.Call((ushort)0x032B,model,(int)type,count,position.X,position.Y,position.Z,result);else Scm.Call((ushort)0x0213,model,(int)type,position.X,position.Y,position.Z,result);if(result.Int32<0 || !Scm.Call((ushort)0x09D1,result.Int32))throw new InvalidOperationException("GTA could not create the pickup.");return new(result.Int32,true);}
        finally {Models.MarkAsNoLongerNeeded(model);}
    }
    public void Delete() {if(disposed)return;if(owned)ModResources.Check(owner);if(Exists)Scm.Call((ushort)0x0215,Handle);disposed=true;if(owned)ModResources.Forget(owner,this);}
    public void Dispose() {if(owned)Delete();else disposed=true;}
}
public sealed class Blip:IDisposable
{
    private readonly uint owner;
    private bool disposed;
    internal Blip(int handle) {if(handle<0 || !Scm.Call((ushort)0x075C,handle))throw new InvalidOperationException("GTA could not create the blip.");Handle=handle;owner=ModResources.Register(this);}
    public int Handle {get;}
    public bool Exists=>!disposed && Scm.Call((ushort)0x075C,Handle);
    private void Check() {ModResources.Check(owner);if(!Exists)throw new InvalidOperationException("Blip no longer exists.");}
    public void SetColor(int color) {Check();Scm.Call((ushort)0x0165,Handle,color);}
    public void SetScale(int scale) {if(scale is <1 or >10)throw new ArgumentOutOfRangeException(nameof(scale));Check();Scm.Call((ushort)0x0168,Handle,scale);}
    public void SetDisplay(int display) {if(display is <0 or >3)throw new ArgumentOutOfRangeException(nameof(display));Check();Scm.Call((ushort)0x018B,Handle,display);}
    public void Dispose() {if(disposed)return;ModResources.Check(owner);if(Exists)Scm.Call((ushort)0x0164,Handle);disposed=true;ModResources.Forget(owner,this);}
}
public static class Blips
{
    public static Blip Create(Vector3 position) {Game.CheckThread();_ = TaskRuntime.CurrentOwner;Entity.ValidatePosition(position);return new(Commands.Int(0x018A,position.X,position.Y,position.Z));}
    public static Blip Create(Entity entity) {Game.CheckThread();_ = TaskRuntime.CurrentOwner;ArgumentNullException.ThrowIfNull(entity);if(!entity.Exists)throw new InvalidOperationException("Entity no longer exists.");ushort opcode=entity switch {Char=>0x0187,Vehicle=>0x0186,Prop=>0x0188,_=>throw new ArgumentException("Unsupported entity.",nameof(entity))};return new(Commands.Int(opcode,entity.Handle));}
}
public sealed class Sphere:IDisposable
{
    private readonly uint owner;
    private bool disposed;
    private Sphere(int handle) {if(handle<0)throw new InvalidOperationException("No free sphere slot.");Handle=handle;owner=ModResources.Register(this);}
    public int Handle {get;}
    public static Sphere Create(Vector3 position,float radius) {Game.CheckThread();_ = TaskRuntime.CurrentOwner;Validate(position,radius);return new(Commands.Int(0x03BC,position.X,position.Y,position.Z,radius));}
    public static void Draw(Vector3 position,float diameter) {Validate(position,diameter);Scm.Call((ushort)0x03A1,position.X,position.Y,position.Z,diameter);}
    private static void Validate(Vector3 position,float radius) {Entity.ValidatePosition(position);if(!float.IsFinite(radius)||radius<=0)throw new ArgumentOutOfRangeException(nameof(radius));}
    public void Dispose() {if(disposed)return;ModResources.Check(owner);Scm.Call((ushort)0x03BD,Handle);disposed=true;ModResources.Forget(owner,this);}
}
public sealed class User3DMarker:IDisposable
{
    private readonly uint owner;
    private bool disposed;
    private User3DMarker(int handle) {if(handle<0)throw new InvalidOperationException("No free marker slot.");Handle=handle;owner=ModResources.Register(this);}
    public int Handle {get;}
    /// <param name="hudColorId">Stock HUD color-table index, not an ARGB value.</param>
    public static User3DMarker Create(Vector3 position,int hudColorId=0) {Game.CheckThread();_ = TaskRuntime.CurrentOwner;Entity.ValidatePosition(position);if(hudColorId is <0 or >14)throw new ArgumentOutOfRangeException(nameof(hudColorId));return new(Commands.Int(0x0A40,position.X,position.Y,position.Z,hudColorId));}
    public void Dispose() {if(disposed)return;ModResources.Check(owner);Scm.Call((ushort)0x0A41,Handle);disposed=true;ModResources.Forget(owner,this);}
}
