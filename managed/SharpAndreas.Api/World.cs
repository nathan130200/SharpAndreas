using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpAndreas;

/// <summary>Game-thread snapshots of instantiated peds, vehicles and dynamic props in GTA's pools.</summary>
public static partial class World
{
    [StructLayout(LayoutKind.Sequential)]
    private struct Query { public int Type,Flags; public float X,Y,Z,Radius; }
    [StructLayout(LayoutKind.Sequential)]
    private struct Entry { public int Handle,Kind; public double DistanceSquared; }
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private unsafe delegate int QueryCallback(Query* query,Entry* output,int capacity);
    private static QueryCallback callback=null!;
    internal static void Bind(IntPtr pointer) => callback=Marshal.GetDelegateForFunctionPointer<QueryCallback>(pointer);

    public static Pickup[] GetAllPickups()=>Convert(Read(3),entry=>Pickup.FromHandle(entry.Handle));
    public static Pickup[] GetNearbyPickups(Vector3 center,float radius)=>Convert(Read(3,center,radius),entry=>Pickup.FromHandle(entry.Handle));
    public static Pickup? GetClosestPickup(Vector3 center,float radius=float.MaxValue) {var entries=Read(3,center,radius,true);return entries.Length==0?null:Pickup.FromHandle(entries[0].Handle);}
    public static Ped[] GetAllPeds() => Convert(Read(0),entry=>new Ped(entry.Handle));
    public static Vehicle[] GetAllVehicles() => Convert(Read(1),CreateVehicle);
    public static Prop[] GetAllProps() => Convert(Read(2),entry=>new Prop(entry.Handle));
    /// <summary>Returns peds within an inclusive 3D radius, including the player if in range.</summary>
    public static Ped[] GetNearbyPeds(Vector3 center,float radius) => Convert(Read(0,center,radius),entry=>new Ped(entry.Handle));
    public static Vehicle[] GetNearbyVehicles(Vector3 center,float radius) => Convert(Read(1,center,radius),CreateVehicle);
    public static Prop[] GetNearbyProps(Vector3 center,float radius) => Convert(Read(2,center,radius),entry=>new Prop(entry.Handle));
    public static Ped? GetClosestPed(Vector3 center,float radius=float.MaxValue)
    {
        var entries=Read(0,center,radius,true);
        return entries.Length==0?null:new Ped(entries[0].Handle);
    }
    public static Vehicle? GetClosestVehicle(Vector3 center,float radius=float.MaxValue)
    {
        var entries=Read(1,center,radius,true);
        return entries.Length==0?null:CreateVehicle(entries[0]);
    }
    public static Prop? GetClosestProp(Vector3 center,float radius=float.MaxValue)
    {
        var entries=Read(2,center,radius,true);
        return entries.Length==0?null:new Prop(entries[0].Handle);
    }
    private static Vehicle CreateVehicle(Entry entry) => (VehicleKind)entry.Kind switch
    {
        VehicleKind.Boat=>new Boat(entry.Handle),
        VehicleKind.Automobile=>new Car(entry.Handle),
        VehicleKind.Train=>new Train(entry.Handle),
        VehicleKind.Trailer=>new Trailer(entry.Handle),
        VehicleKind.Plane=>new Plane(entry.Handle),
        VehicleKind.Helicopter=>new Helicopter(entry.Handle),
        _=>new Vehicle(entry.Handle)
    };
    private static T[] Convert<T>(Entry[] entries,Func<Entry,T> create)
    {
        if(entries.Length==0)return Array.Empty<T>();
        var result=new T[entries.Length];
        for(int i=0;i<entries.Length;i++)result[i]=create(entries[i]);
        return result;
    }
    private static unsafe Entry[] Read(int type,Vector3? center=null,float radius=0,bool nearest=false)
    {
        Game.CheckThread();
        if(center is {} position)Entity.ValidatePosition(position);
        if(!float.IsFinite(radius) || radius<0)throw new ArgumentOutOfRangeException(nameof(radius));
        var query=new Query {Type=type,Flags=(center.HasValue?1:0)|(nearest?2:0),
            X=center?.X??0,Y=center?.Y??0,Z=center?.Z??0,Radius=radius};
        int count=callback(&query,null,0);
        if(count<0)throw new InvalidOperationException($"World query failed ({count}).");
        if(count==0)return Array.Empty<Entry>();
        var entries=new Entry[count];
        fixed(Entry* output=entries)
        {
            int written=callback(&query,output,entries.Length);
            // No game processing or managed user callbacks run between count and copy.
            if(written<0 || written>entries.Length)throw new InvalidOperationException("Entity pool changed during world query.");
            if(written!=entries.Length)Array.Resize(ref entries,written);
        }
        return entries;
    }
}
