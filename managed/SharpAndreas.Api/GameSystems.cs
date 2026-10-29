using System.Numerics;
namespace SharpAndreas;
internal static class Commands
{
    internal static int Int(ushort opcode,params ScmArgument[] input) {var value=new ScmVariable();Scm.Call(opcode,[..input,value]);return value.Int32;}
    internal static float Float(ushort opcode,params ScmArgument[] input) {var value=new ScmVariable();Scm.Call(opcode,[..input,value]);return value.Single;}
    internal static Vector3 Vector(ushort opcode,params ScmArgument[] input) {var x=new ScmVariable();var y=new ScmVariable();var z=new ScmVariable();Scm.Call(opcode,[..input,x,y,z]);return new(x.Single,y.Single,z.Single);}
    internal static void Finite(float value) {if(!float.IsFinite(value))throw new ArgumentOutOfRangeException(nameof(value));}
    internal static void Name(string name) {ArgumentException.ThrowIfNullOrWhiteSpace(name);if(name.Length>63 || name.Any(c=>c>127 || c=='\0'))throw new ArgumentException("Use an ASCII resource name of at most 63 characters.",nameof(name));}
}
public sealed partial class Player
{
    public int Money=>Commands.Int(0x010B,Index);
    public void AddMoney(int amount)=>Scm.Call((ushort)0x0109,Index,amount);
    public int WantedLevel {get=>Commands.Int(0x01C0,Index);set {if(value is <0 or >6)throw new ArgumentOutOfRangeException(nameof(value));Scm.Call((ushort)0x010D,Index,value);}}
    public void ClearWantedLevel()=>Scm.Call((ushort)0x0110,Index);
    public bool IsControlEnabled=>Scm.Call((ushort)0x09E7,Index);
}
public partial class Vehicle
{
    public float Speed {get {RequireExists();return Commands.Float(0x02E3,Handle);}}
    public Vector3 Velocity {get {RequireExists();return Commands.Vector(0x06A2,Handle);}}
    public int PassengerCount {get {RequireExists();return Commands.Int(0x01E9,Handle);}}
    public int PassengerCapacity {get {RequireExists();return Commands.Int(0x01EA,Handle);}}
    public bool IsPassengerSeatFree(int seat) {RequireExists();if(seat<0 || seat>=PassengerCapacity)throw new ArgumentOutOfRangeException(nameof(seat));return Scm.Call((ushort)0x0431,Handle,seat);}
    public void Repair() {RequireExists();Scm.Call((ushort)0x0A30,Handle);}
    public void SetForwardSpeed(float speed) {Commands.Finite(speed);RequireExists();Scm.Call((ushort)0x04BA,Handle,speed);}
    public void SetEngineRunning(bool enabled) {RequireExists();Scm.Call((ushort)0x0918,Handle,enabled);}
    public void SetColors(int primary,int secondary) {if(primary is <0 or >255 || secondary is <0 or >255)throw new ArgumentOutOfRangeException(nameof(primary));RequireExists();Scm.Call((ushort)0x0229,Handle,primary,secondary);}
}
public static partial class World
{
    /// <summary>Ground collision query. Stream collision first when querying far from the player.</summary>
    public static float GetGroundHeight(Vector3 position) {Entity.ValidatePosition(position);return Commands.Float(0x02CE,position.X,position.Y,position.Z);}
    public static Zone? GetZone(Vector3 position)=>Zone.At(position);
}
public static partial class Paths
{
    public static void SetVehicleRoadsEnabled(Vector3 minimum,Vector3 maximum,bool enabled)=>Switch(enabled?(ushort)0x01E7:(ushort)0x01E8,minimum,maximum);
    public static void SetPedRoadsEnabled(Vector3 minimum,Vector3 maximum,bool enabled)=>Switch(enabled?(ushort)0x022A:(ushort)0x022B,minimum,maximum);
    public static void RestoreVehicleRoads(Vector3 minimum,Vector3 maximum)=>Switch(0x091D,minimum,maximum);
    public static void RestorePedRoads(Vector3 minimum,Vector3 maximum)=>Switch(0x091E,minimum,maximum);
    private static void Switch(ushort opcode,Vector3 minimum,Vector3 maximum) {Entity.ValidatePosition(minimum);Entity.ValidatePosition(maximum);if(minimum.X>maximum.X || minimum.Y>maximum.Y || minimum.Z>maximum.Z)throw new ArgumentException("Minimum must not exceed maximum.");Scm.Call(opcode,minimum.X,minimum.Y,minimum.Z,maximum.X,maximum.Y,maximum.Z);}
}
public enum CameraSwitch {Interpolate=1,JumpCut=2}
public static class Camera
{
    public static Vector3 Position=>Commands.Vector(0x068D);
    public static Vector3 Target=>Commands.Vector(0x068E);
    public static void SetFixed(Vector3 position,Vector3 up) {Entity.ValidatePosition(position);Entity.ValidatePosition(up);Scm.Call((ushort)0x015F,position.X,position.Y,position.Z,up.X,up.Y,up.Z);}
    public static void LookAt(Vector3 target,CameraSwitch transition=CameraSwitch.JumpCut) {Entity.ValidatePosition(target);if(!Enum.IsDefined(transition))throw new ArgumentOutOfRangeException(nameof(transition));Scm.Call((ushort)0x0160,target.X,target.Y,target.Z,(int)transition);}
    public static void Restore(bool jumpCut=false)=>Scm.Call(jumpCut?(ushort)0x02EB:(ushort)0x015A);
    public static void SetBehindPlayer()=>Scm.Call((ushort)0x0373);
    public static void Shake(int strength) {if(strength is <0 or >255)throw new ArgumentOutOfRangeException(nameof(strength));Scm.Call((ushort)0x0003,strength);}
    public static void Fade(int milliseconds,bool fadeIn) {if(milliseconds<0)throw new ArgumentOutOfRangeException(nameof(milliseconds));Scm.Call((ushort)0x016A,milliseconds,fadeIn);}
    public static void SetFadeColor(HudColor color)=>Scm.Call((ushort)0x0169,(int)color.R,(int)color.G,(int)color.B);
}
public static class Sound
{
    /// <summary>Plays a stock scripted game sound ID, not an arbitrary audio file.</summary>
    public static void PlayAt(int soundId,Vector3 position) {if(soundId<0)throw new ArgumentOutOfRangeException(nameof(soundId));Entity.ValidatePosition(position);Scm.Call((ushort)0x018C,position.X,position.Y,position.Z,soundId);}
}
/// <summary>Global game shopping state; another script may replace the loaded shop.</summary>
public static class Shopping
{
    public static void Load(string section) {Commands.Name(section);Scm.Call((ushort)0x075E,section);}
    public static int ItemCount=>Commands.Int(0x075F);
    public static int GetItem(int index) {if(index<0 || index>=ItemCount)throw new ArgumentOutOfRangeException(nameof(index));return Commands.Int(0x0760,index);}
    public static int GetPrice(int item)=>Commands.Int(0x0761,item);
    public static void Buy(int item)=>Scm.Call((ushort)0x0790,item);
    public static bool HasBought(int item)=>Scm.Call((ushort)0x0942,item);
    public static void Clear()=>Scm.Call((ushort)0x087C);
}
/// <summary>Global skip destination used by the game's trip-skip system. Always clear your own setup.</summary>
public static class Skip
{
    public static void SetDestination(Vector3 position,float heading,bool afterMission=false) {Entity.ValidatePosition(position);Commands.Finite(heading);Scm.Call(afterMission?(ushort)0x09AF:(ushort)0x0950,position.X,position.Y,position.Z,heading);}
    public static bool IsWaitingForScript=>Scm.Call((ushort)0x0A36);
    public static void Clear()=>Scm.Call((ushort)0x0951);
}
public static class Streaming
{
    public static Task RequestModelAsync(int model,CancellationToken cancellationToken=default)=>Models.RequestAsync(model,cancellationToken);
    public static void MarkModelAsNoLongerNeeded(int model)=>Models.MarkAsNoLongerNeeded(model);
    public static async Task RequestAnimationAsync(string name,CancellationToken cancellationToken=default)
    {Commands.Name(name);cancellationToken.ThrowIfCancellationRequested();Scm.Call((ushort)0x04ED,name);try {while(!Scm.Call((ushort)0x04EE,name))await Script.NextFrame(cancellationToken);cancellationToken.ThrowIfCancellationRequested();}catch {Scm.Call((ushort)0x04EF,name);throw;}}
    public static bool HasAnimationLoaded(string name) {Commands.Name(name);return Scm.Call((ushort)0x04EE,name);}
    public static void RemoveAnimation(string name) {Commands.Name(name);Scm.Call((ushort)0x04EF,name);}
    public static void RequestIpl(string name) {Commands.Name(name);Scm.Call((ushort)0x0776,name);}
    public static void RemoveIpl(string name,bool discreetly=false) {Commands.Name(name);Scm.Call(discreetly?(ushort)0x0778:(ushort)0x0777,name);}
    public static void RequestCollision(Vector2 position) {Commands.Finite(position.X);Commands.Finite(position.Y);Scm.Call((ushort)0x04E4,position.X,position.Y);}
    public static async Task RequestCarRecordingAsync(int id,CancellationToken cancellationToken=default)
    {if(id<0)throw new ArgumentOutOfRangeException(nameof(id));cancellationToken.ThrowIfCancellationRequested();Scm.Call((ushort)0x07C0,id);try {while(!Scm.Call((ushort)0x07C1,id))await Script.NextFrame(cancellationToken);cancellationToken.ThrowIfCancellationRequested();}catch {RemoveCarRecording(id);throw;}}
    public static void RemoveCarRecording(int id) {if(id<0)throw new ArgumentOutOfRangeException(nameof(id));Scm.Call((ushort)0x0873,id);}
}
public enum WeatherType {ExtraSunnyLosSantos=0,SunnyLosSantos,ExtraSunnySmogLosSantos,SunnySmogLosSantos,CloudyLosSantos,SunnySanFierro,ExtraSunnySanFierro,CloudySanFierro,RainySanFierro,FoggySanFierro,SunnyLasVenturas,ExtraSunnyLasVenturas,CloudyLasVenturas,ExtraSunnyCountryside,SunnyCountryside,CloudyCountryside,RainyCountryside,ExtraSunnyDesert,SunnyDesert,SandstormDesert,Underwater,ExtraColors1,ExtraColors2}
public readonly record struct WeatherState(WeatherType Current,WeatherType Next,int ForcedType,float Rain,float Interpolation);
public static class Weather
{
    public static WeatherState State {get {var args=new GameServices.Args();GameServices.Call(4,ref args);return new((WeatherType)args.First,(WeatherType)args.Second,args.Third,args.X,args.Y);}}
    public static void Force(WeatherType type,bool immediately=false) {if(!Enum.IsDefined(type))throw new ArgumentOutOfRangeException(nameof(type));Scm.Call(immediately?(ushort)0x01B6:(ushort)0x01B5,(int)type);}
    public static void Release()=>Scm.Call((ushort)0x01B7);
    public static void SetHeatHaze(bool enabled)=>Scm.Call((ushort)0x08FD,enabled);
    public static void SetAppropriateNow()=>Scm.Call((ushort)0x0915);
}
