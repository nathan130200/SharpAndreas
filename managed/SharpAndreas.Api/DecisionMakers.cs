namespace SharpAndreas;
public enum DecisionMakerCharTemplate {Gang=65536,Cop,RandomNormal,RandomTough,RandomWeak,Fireman,Empty,Indoors}
public enum DecisionMakerGroupTemplate {RandomAggressive=65544,RandomPassive}
public enum DecisionMakerCharType {Empty,Normal,Tough,Weak,Steal,Mission}
public enum DecisionMakerGroupType {MissionNormal}
/// <summary>Relative response weights for the relationship of an event's source to the deciding ped.</summary>
public readonly record struct DecisionResponseWeights(byte Neutral,byte Player,byte Friend,byte Enemy);
/// <summary>Owned event-response policy. Dispose after its assigned peds/groups are deleted or reassigned.</summary>
public abstract class DecisionMaker:IDisposable
{
    private readonly uint owner;
    private bool disposed;
    protected DecisionMaker(int handle) {if(handle<0)throw new InvalidOperationException("No free decision maker slot.");Handle=handle;owner=ModResources.Register(this);}
    public int Handle {get;}
    public bool Exists {get {ModResources.Check(owner);return !disposed && Scm.Call((ushort)0x09F2,Handle);}}
    protected void Check() {if(!Exists)throw new InvalidOperationException("Decision maker no longer exists.");}
    protected static int Create(ushort command,int source) {Game.CheckThread();_ = TaskRuntime.CurrentOwner;var result=new ScmVariable(-1);Scm.Call(command,source,result);if(result.Int32<0 || !Scm.Call((ushort)0x09F2,result.Int32))throw new InvalidOperationException("GTA could not allocate a decision maker.");return result.Int32;}
    public void ClearEventResponses(Sdk.eEventType eventType)
    {Check();ValidateEvent(eventType);var args=new GameServices.Args {First=Handle,Second=(int)eventType};GameServices.Call(6,ref args);}
    public void AddEventResponse(Sdk.eEventType eventType,Sdk.eTaskType taskType,DecisionResponseWeights weights,bool onFoot=true,bool inVehicle=true)
    {
        Check();ValidateEvent(eventType);if(!Enum.IsDefined(taskType) || (int)taskType<0)throw new ArgumentOutOfRangeException(nameof(taskType));
        if(!onFoot && !inVehicle)throw new ArgumentException("Enable at least one response context.");
        var args=new GameServices.Args {First=Handle,Second=(int)eventType,Third=(int)taskType,Fourth=(onFoot?1:0)|(inVehicle?2:0),X=weights.Neutral,Y=weights.Player,Z=weights.Friend,W=weights.Enemy};GameServices.Call(5,ref args);
    }
    private static void ValidateEvent(Sdk.eEventType value) {if(!Enum.IsDefined(value) || (int)value<0 || (int)value>=96)throw new ArgumentOutOfRangeException(nameof(value));}
    public void Dispose() {if(disposed)return;ModResources.Check(owner);if(Exists)Scm.Call((ushort)0x065C,Handle);disposed=true;ModResources.Forget(owner,this);}
}
public sealed class DecisionMakerChar:DecisionMaker
{
    private DecisionMakerChar(int handle):base(handle) {}
    public static DecisionMakerChar Copy(DecisionMakerCharTemplate template) {if(!Enum.IsDefined(template))throw new ArgumentOutOfRangeException(nameof(template));return new(Create(0x07E5,(int)template));}
    public DecisionMakerChar Copy() {Check();return new(Create(0x07E5,Handle));}
    public static DecisionMakerChar Load(DecisionMakerCharType type) {if(!Enum.IsDefined(type))throw new ArgumentOutOfRangeException(nameof(type));return new(Create(0x060A,(int)type));}
    public void AssignTo(Char ped) {ArgumentNullException.ThrowIfNull(ped);Check();if(!ped.Exists)throw new InvalidOperationException("Ped no longer exists.");Scm.Call((ushort)0x060B,ped,Handle);}
    public static void AssignTemplate(Char ped,DecisionMakerCharTemplate template) {ArgumentNullException.ThrowIfNull(ped);if(!Enum.IsDefined(template))throw new ArgumentOutOfRangeException(nameof(template));if(!ped.Exists)throw new InvalidOperationException("Ped no longer exists.");Scm.Call((ushort)0x060B,ped,(int)template);}
}
public sealed class DecisionMakerGroup:DecisionMaker
{
    private DecisionMakerGroup(int handle):base(handle) {}
    public static DecisionMakerGroup Copy(DecisionMakerGroupTemplate template) {if(!Enum.IsDefined(template))throw new ArgumentOutOfRangeException(nameof(template));return new(Create(0x07E6,(int)template));}
    public DecisionMakerGroup Copy() {Check();return new(Create(0x07E6,Handle));}
    public static DecisionMakerGroup Load(DecisionMakerGroupType type=DecisionMakerGroupType.MissionNormal) {if(!Enum.IsDefined(type))throw new ArgumentOutOfRangeException(nameof(type));return new(Create(0x06AE,(int)type));}
    public void AssignTo(PedGroup group) {ArgumentNullException.ThrowIfNull(group);Check();if(!group.Exists)throw new InvalidOperationException("Group no longer exists.");Scm.Call((ushort)0x06AD,group.Handle,Handle);}
    public static void AssignTemplate(PedGroup group,DecisionMakerGroupTemplate template) {ArgumentNullException.ThrowIfNull(group);if(!Enum.IsDefined(template))throw new ArgumentOutOfRangeException(nameof(template));if(!group.Exists)throw new InvalidOperationException("Group no longer exists.");Scm.Call((ushort)0x06AD,group.Handle,(int)template);}
}
