using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
namespace SharpAndreas;
internal static unsafe class GameServices
{
    [StructLayout(LayoutKind.Sequential)] internal struct Args {internal int First,Second,Third,Fourth;internal float X,Y,Z,W;internal IntPtr Data;internal int Count;internal IntPtr Text;}
    [StructLayout(LayoutKind.Sequential)] internal struct ZoneData {internal fixed byte Label[8];internal fixed byte TextKey[8];internal Vector3 Minimum,Maximum;internal int Type,Level;internal IntPtr Native;}
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate int Callback(int operation,ref Args args);
    private static Callback callback=null!;
    internal static void Bind(IntPtr pointer)=>callback=Marshal.GetDelegateForFunctionPointer<Callback>(pointer);
    internal static int Call(int operation,ref Args args) {Game.CheckThread();int result=callback(operation,ref args);if(result<0)throw new InvalidOperationException($"Game service {operation} failed ({result}).");return result;}
    internal static Zone? FindZone(Vector3 position,string? label)
    {
        Entity.ValidatePosition(position);ZoneData data=default;
        var args=new Args {X=position.X,Y=position.Y,Z=position.Z,Data=(IntPtr)(&data)};
        fixed(char* text=label) {args.Text=(IntPtr)text;if(Call(label is null?2:3,ref args)==0)return null;}
        return new Zone(Read(data.Label),Read(data.TextKey),data.Minimum,data.Maximum,data.Type,(ZoneLevel)data.Level,data.Native);
    }
    private static string Read(byte* value) {int length=0;while(length<8 && value[length]!=0)length++;return Encoding.ASCII.GetString(value,length);}
}
public enum ZoneLevel {Countryside,LosSantos,SanFierro,LasVenturas}
/// <summary>A snapshot of an engine navigation zone, not a newly allocated territory.</summary>
public sealed class Zone
{
    private readonly Lazy<Sdk.CZone> native;
    internal Zone(string label,string textKey,Vector3 minimum,Vector3 maximum,int type,ZoneLevel level,IntPtr pointer)
    {Label=label;TextKey=textKey;Minimum=minimum;Maximum=maximum;Type=type;Level=level;native=new(()=>pointer!=IntPtr.Zero?new Sdk.CZone(pointer):throw new InvalidOperationException("Zone native pointer unavailable."),LazyThreadSafetyMode.ExecutionAndPublication);}
    public string Label {get;}
    public string TextKey {get;}
    public Vector3 Minimum {get;}
    public Vector3 Maximum {get;}
    public int Type {get;}
    public ZoneLevel Level {get;}
    public Sdk.CZone Native {get {Game.CheckThread();return native.Value;}}
    public bool Contains(Vector3 point) {Entity.ValidatePosition(point);return point.X>=Minimum.X && point.X<=Maximum.X && point.Y>=Minimum.Y && point.Y<=Maximum.Y && point.Z>=Minimum.Z && point.Z<=Maximum.Z;}
    public static Zone? At(Vector3 position)=>GameServices.FindZone(position,null);
    public static Zone? Find(string label)
    {ArgumentException.ThrowIfNullOrWhiteSpace(label);if(label.Length>8 || label.Any(c=>c>127 || c=='\0'))throw new ArgumentException("Use an ASCII zone label of at most eight characters.",nameof(label));return GameServices.FindZone(default,label.ToUpperInvariant());}
}
internal static class ModResources
{
    private static readonly Dictionary<uint,HashSet<IDisposable>> resources=[];
    internal static uint Register(IDisposable resource)
    {Game.CheckThread();uint owner=TaskRuntime.CurrentOwner;if(!resources.TryGetValue(owner,out var set))resources.Add(owner,set=[]);set.Add(resource);return owner;}
    internal static void Check(uint owner) {Game.CheckThread();if(owner!=TaskRuntime.CurrentOwner)throw new InvalidOperationException("Resources cannot cross mod contexts.");}
    internal static void Forget(uint owner,IDisposable resource) {if(resources.TryGetValue(owner,out var set)){set.Remove(resource);if(set.Count==0)resources.Remove(owner);}}
    internal static void End(uint owner) {if(!resources.Remove(owner,out var set))return;foreach(var resource in set.ToArray())try {resource.Dispose();}catch(Exception ex){Log.ReportException(ModContext.Current?.Name??"Loader","Resource cleanup failed",ex);}}
}
