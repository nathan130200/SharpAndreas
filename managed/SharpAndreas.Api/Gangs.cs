namespace SharpAndreas;

public enum GangFaction { Ballas=0,GroveStreet=1,Vagos=2,Rifa=3,DaNangBoys=4,Mafia=5,Triads=6,Aztecas=7,Unused1=8,Unused2=9 }

/// <summary>A real GTA ped group: at most seven followers plus a leader, with eight engine group slots.</summary>
public sealed class PedGroup:IDisposable
{
    private readonly bool owned;
    private bool disposed;
    public int Handle {get;}
    private PedGroup(int handle,bool owned) { if(handle<0)throw new ArgumentOutOfRangeException(nameof(handle));Handle=handle;this.owned=owned; }
    public static PedGroup FromHandle(int handle)=>new(handle,false);
    public bool Exists=>!disposed && Scm.Call((ushort)0x07FD,Handle);
    private void Check() { if(!Exists)throw new InvalidOperationException("Ped group no longer exists."); }
    public static PedGroup Create(Ped leader)
    {
        ArgumentNullException.ThrowIfNull(leader);if(!leader.Exists)throw new InvalidOperationException("Leader no longer exists.");
        var value=new ScmVariable(-1);Scm.Call((ushort)0x062F,0,value);
        if(value.Int32<0)throw new InvalidOperationException("GTA has no free ped group slots.");
        var group=new PedGroup(value.Int32,true);
        try {group.SetLeader(leader);return group;} catch {group.Dispose();throw;}
    }
    public Ped? Leader
    {
        get {Check();var value=new ScmVariable(-1);Scm.Call((ushort)0x084F,Handle,value);return value.Int32>=0 && Scm.Call(ScmOpcode.DoesCharExist,value.Int32)?new(value.Int32):null;}
    }
    public int MemberCount
    {
        get {Check();var leaders=new ScmVariable();var members=new ScmVariable();Scm.Call((ushort)0x07F6,Handle,leaders,members);return leaders.Int32+members.Int32;}
    }
    public void SetLeader(Ped ped) {Check();if(!ped.Exists)throw new InvalidOperationException("Ped no longer exists.");Scm.Call((ushort)0x0630,Handle,ped);}
    public bool Contains(Char ped) {Check();return ped.Exists && (Scm.Call((ushort)0x06EE,ped,Handle) || Scm.Call((ushort)0x06EF,ped,Handle));}
    public void Add(Ped ped)
    {
        Check();if(!ped.Exists)throw new InvalidOperationException("Ped no longer exists.");
        if(Contains(ped))return;if(MemberCount>=8)throw new InvalidOperationException("Ped group is full.");
        Scm.Call((ushort)0x0631,Handle,ped);
        if(!Contains(ped))throw new InvalidOperationException("GTA rejected group membership.");
    }
    public void Remove(Char ped) {Check();if(Contains(ped))Scm.Call((ushort)0x06C9,ped);}
    public void Dispose() {if(disposed)return;if(owned && Exists)Scm.Call((ushort)0x0632,Handle);disposed=true;}
}

/// <summary>A custom gang combines a native faction with a ped group. It does not expand GTA's ten faction slots.</summary>
public sealed class Gang:IDisposable
{
    private static readonly Dictionary<int,WeakReference<Gang>> registered=[];
    private readonly Dictionary<int,int> originalPedTypes=[];
    private readonly bool ownsGroup;
    private bool disposed;
    public string Name {get;}
    public GangFaction? Faction {get;}
    public PedGroup Group {get;}
    private Gang(string name,GangFaction? faction,PedGroup group,bool ownsGroup) {Name=name;Faction=faction;Group=group;this.ownsGroup=ownsGroup;}
    public static Gang ForPlayer(Player player)
    {
        var group=player.Group;
        if(registered.TryGetValue(group.Handle,out var weak) && weak.TryGetTarget(out var known) && !known.disposed)return known;
        return new("Player "+player.Index+" Gang",null,group,false);
    }
    public static Gang Create(string name,Ped leader,GangFaction faction=GangFaction.Unused2)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);ArgumentNullException.ThrowIfNull(leader);ValidateFaction(faction);
        PedGroup? group=null;bool owned=true;
        for(int i=0;i<2;i++) {var player=new Player(i);if(player.Character?.Handle==leader.Handle) {group=player.Group;owned=false;break;}}
        group??=PedGroup.Create(leader);
        var result=new Gang(name,faction,group,owned);
        try {result.AssignFaction(leader);registered[group.Handle]=new(result);return result;}
        catch {if(owned)group.Dispose();throw;}
    }
    private static void ValidateFaction(GangFaction faction) {if(!Enum.IsDefined(faction))throw new ArgumentOutOfRangeException(nameof(faction));}
    public static GangFaction? GetFaction(Char ped)
    {
        int type=ped.Native.PedType;
        return type is >=7 and <=16?(GangFaction)(type-7):null;
    }
    private void AssignFaction(Ped ped)
    {
        if(Faction is not { } faction)return;
        int type=ped.Native.PedType;
        if(type<2)return; // Preserve player ped type: changing it breaks player control/engine identity.
        originalPedTypes.TryAdd(ped.Handle,type);
        ped.Native.PedType=7+(int)faction;
    }
    public void Add(Ped ped)
    {
        ObjectDisposedException.ThrowIf(disposed,this);
        Group.Add(ped);
        try {AssignFaction(ped);} catch {Group.Remove(ped);throw;}
    }
    public void Remove(Ped ped)
    {
        ObjectDisposedException.ThrowIf(disposed,this);Group.Remove(ped);Restore(ped);
    }
    private void Restore(Ped ped)
    {
        if(originalPedTypes.Remove(ped.Handle,out int original) && ped.Exists && Faction is { } faction && ped.Native.PedType==7+(int)faction)ped.Native.PedType=original;
    }
    public static void SetWeapons(GangFaction faction,int weapon1,int weapon2,int weapon3)
    {
        ValidateFaction(faction);if(weapon1 is <0 or >46 || weapon2 is <0 or >46 || weapon3 is <0 or >46)throw new ArgumentOutOfRangeException(nameof(weapon1));
        Sdk.CGangs.SetGangWeapons((short)faction,weapon1,weapon2,weapon3);
    }
    public void Dispose()
    {
        if(disposed)return;
        foreach(int handle in originalPedTypes.Keys.ToArray())
        {
            var ped=new Ped(handle);
            try {if(!ownsGroup && Group.Exists && ped.Exists)Group.Remove(ped);} finally {Restore(ped);}
        }
        if(ownsGroup)Group.Dispose();
        if(registered.TryGetValue(Group.Handle,out var weak) && weak.TryGetTarget(out var current) && ReferenceEquals(current,this))registered.Remove(Group.Handle);
        disposed=true;
    }
}
