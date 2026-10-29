using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpAndreas;

public enum PathNodeType { Vehicle=0, Pedestrian=1 }
[Flags]
public enum PathNodeFlags { None=0, SwitchedOff=1, Water=2, DeadEnd=4, DontWander=8 }
public readonly record struct PathNodeId(int Area,int Index);

/// <summary>A snapshot of a loaded path node. Heading points toward HeadingTarget, in GTA degrees.</summary>
public readonly record struct PathNode(PathNodeId Id,PathNodeType Type,Vector3 Position,
    float? Heading,PathNodeId? HeadingTarget,float Width,int LinkCount,PathNodeFlags Flags)
{
    public bool IsSwitchedOff => (Flags&PathNodeFlags.SwitchedOff)!=0;
    public bool IsWater => (Flags&PathNodeFlags.Water)!=0;
    public PathNode[] GetLinkedNodes() => Paths.GetLinkedNodes(Id);
}

/// <summary>Game-thread queries over loaded path areas. Does not force synchronous streaming.</summary>
public static partial class Paths
{
    [StructLayout(LayoutKind.Sequential)]
    private struct Query {public int Operation,Type,Nth,Area,Index,Flags;public float X,Y,Z,Radius;}
    [StructLayout(LayoutKind.Sequential)]
    private struct Result
    {
        public int Area,Index,Type,Flags,Links;
        public float X,Y,Z,Heading,Width;
        public int HeadingArea,HeadingIndex;
        public readonly PathNode ToNode() => new(new(Area,Index),(PathNodeType)Type,new(X,Y,Z),
            float.IsFinite(Heading)?Heading:null,HeadingArea>=0?new PathNodeId(HeadingArea,HeadingIndex):null,
            Width,Links,(PathNodeFlags)Flags);
    }
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private unsafe delegate int QueryCallback(Query* query,Result* output,int capacity);
    private static QueryCallback callback=null!;
    internal static void Bind(IntPtr pointer) => callback=Marshal.GetDelegateForFunctionPointer<QueryCallback>(pointer);

    public static PathNode? GetClosestPedNode(Vector3 center,float radius=float.MaxValue,bool includeSwitchedOff=false)
        => Find(center,0,PathNodeType.Pedestrian,radius,includeSwitchedOff,false);
    public static PathNode? GetClosestVehicleNode(Vector3 center,float radius=float.MaxValue,bool includeSwitchedOff=false,bool includeWater=false)
        => Find(center,0,PathNodeType.Vehicle,radius,includeSwitchedOff,includeWater);
    /// <summary>Rank is zero-based: zero selects the closest loaded eligible node.</summary>
    public static PathNode? GetNthClosestPedNode(Vector3 center,int rank,float radius=float.MaxValue,bool includeSwitchedOff=false)
        => Find(center,rank,PathNodeType.Pedestrian,radius,includeSwitchedOff,false);
    /// <summary>Rank is zero-based: zero selects the closest loaded eligible node.</summary>
    public static PathNode? GetNthClosestVehicleNode(Vector3 center,int rank,float radius=float.MaxValue,bool includeSwitchedOff=false,bool includeWater=false)
        => Find(center,rank,PathNodeType.Vehicle,radius,includeSwitchedOff,includeWater);
    public static unsafe PathNode? GetNode(PathNodeId id)
    {
        Game.CheckThread();Validate(id);
        var query=new Query {Operation=1,Area=id.Area,Index=id.Index};
        return Read(query);
    }
    /// <summary>Returns only links whose target area and node are currently loaded.</summary>
    public static unsafe PathNode[] GetLinkedNodes(PathNodeId id)
    {
        Game.CheckThread();Validate(id);
        var query=new Query {Operation=2,Area=id.Area,Index=id.Index};
        // The native path-node link count is a four-bit field.
        Result* output=stackalloc Result[15];
        int count=callback(&query,output,15);
        if(count<0 || count>15)throw new InvalidOperationException($"Path links query failed ({count}).");
        if(count==0)return Array.Empty<PathNode>();
        var result=new PathNode[count];
        for(int i=0;i<count;i++)result[i]=output[i].ToNode();
        return result;
    }
    private static PathNode? Find(Vector3 center,int rank,PathNodeType type,float radius,bool includeSwitchedOff,bool includeWater)
    {
        Game.CheckThread();Entity.ValidatePosition(center);
        if(rank<0)throw new ArgumentOutOfRangeException(nameof(rank));
        if(!float.IsFinite(radius) || radius<0)throw new ArgumentOutOfRangeException(nameof(radius));
        return Read(new Query {Type=(int)type,Nth=rank,X=center.X,Y=center.Y,Z=center.Z,Radius=radius,
            Flags=(includeSwitchedOff?1:0)|(includeWater?2:0)});
    }
    private static unsafe PathNode? Read(Query query)
    {
        Result result=default;
        int count=callback(&query,&result,1);
        return count switch {0=>null,1=>result.ToNode(),_=>throw new InvalidOperationException($"Path query failed ({count}).")};
    }
    private static void Validate(PathNodeId id)
    {
        if(id.Area is <0 or >=72 || id.Index is <0 or >=65535)throw new ArgumentOutOfRangeException(nameof(id));
    }
}
