using System.Numerics;
using System.Runtime.InteropServices;

namespace SharpAndreas;

public enum AbortPriority { Leisure = 0, Urgent = 1, Immediate = 2 }
public enum PrimaryTaskSlot { PhysicalResponse, EventResponseTemporary, EventResponseNonTemporary, Primary, Default }
public enum SecondaryTaskSlot { Attack, Duck, Say, Facial, PartialAnimation, IK }
public enum MoveState { Still = 1, Walk = 4, Run = 6, Sprint = 7 }

/// <summary>Single-owner native task. Assigning transfers ownership to GTA; Dispose never deletes a game-owned task.</summary>
public abstract class PedTask : IDisposable
{
    internal uint NativeId, OwnerId;
    internal bool Transferred, Disposed;
    protected abstract int Kind { get; }
    protected virtual int[] Parameters => [];
    internal uint Materialize()
    {
        Game.CheckThread();
        ObjectDisposedException.ThrowIf(Disposed, this);
        if (Transferred) throw new InvalidOperationException("This task already belongs to GTA. Clone it before reuse.");
        if (NativeId == 0) TaskRuntime.Create(this, Kind, Parameters);
        if (OwnerId != TaskRuntime.CurrentOwner) throw new InvalidOperationException("Tasks cannot cross script ownership boundaries.");
        return NativeId;
    }
    internal uint Transfer() { uint id = Materialize(); Transferred = true; return id; }
    public PedTask Clone()
    {
        uint id = Materialize();
        uint clone = (uint)TaskRuntime.Call(9, OwnerId, id);
        if (clone == 0) throw new InvalidOperationException("Native task clone failed.");
        var result = TaskRuntime.Find(clone) ?? new BuiltinTask(-1, []);
        result.NativeId = clone; result.OwnerId = OwnerId; result.Transferred = false;
        return result;
    }
    public void Dispose()
    {
        if (Disposed) return;
        Game.CheckThread();
        if (NativeId != 0 && !Transferred) { TaskRuntime.Call(3, OwnerId, NativeId); TaskRuntime.Forget(NativeId); }
        Disposed = true;
    }
    internal sealed class BuiltinTask(int kind, int[] values) : PedTask
    {
        protected override int Kind => kind;
        protected override int[] Parameters => values;
    }
}

public abstract class ManagedSimpleTask : PedTask
{
    protected sealed override int Kind => 10;
    public virtual int TaskType => 200; // SDK TASK_NONE; override only with a deliberate task type.
    protected sealed override int[] Parameters => [TaskType];
    public abstract bool ProcessPed(Ped ped);
    public virtual bool SetPedPosition(Ped ped) => false;
    public virtual bool MakeAbortable(Ped ped, AbortPriority priority, IntPtr nativeEvent) => true;
    public virtual void StopTimer(IntPtr nativeEvent) { }
    public virtual void OnDeleted() { }
    public abstract ManagedSimpleTask CloneState();
}

public abstract class ManagedComplexTask : PedTask
{
    protected sealed override int Kind => 11;
    public virtual int TaskType => 200;
    protected sealed override int[] Parameters => [TaskType];
    public abstract PedTask? CreateFirstSubTask(Ped ped);
    public abstract PedTask? CreateNextSubTask(Ped ped);
    public virtual TaskControl ControlSubTask(Ped ped) => TaskControl.Continue;
    public virtual bool MakeAbortable(Ped ped, AbortPriority priority, IntPtr nativeEvent) => true;
    public virtual void StopTimer(IntPtr nativeEvent) { }
    public virtual void OnDeleted() { }
    public abstract ManagedComplexTask CloneState();
}

/// <summary>A native simple task whose work is a TAP operation pumped on the script's game context.</summary>
public abstract class AsyncPedTask:ManagedSimpleTask
{
    private CancellationTokenSource? cancellation;
    private Task? work;
    protected abstract Task ExecuteAsync(Ped ped,CancellationToken cancellationToken);
    public sealed override bool ProcessPed(Ped ped)
    {
        if(work is null)
        {
            cancellation=CancellationTokenSource.CreateLinkedTokenSource(ModContext.Current!.CancellationToken);
            work=ExecuteAsync(ped,cancellation.Token) ?? throw new InvalidOperationException("ExecuteAsync returned null.");
        }
        if(work.IsFaulted) System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw(work.Exception!.GetBaseException());
        return work.IsCompleted;
    }
    public override bool MakeAbortable(Ped ped,AbortPriority priority,IntPtr nativeEvent) { cancellation?.Cancel(); return true; }
    public override void OnDeleted()
    {
        try { cancellation?.Cancel(); }
        finally { cancellation?.Dispose(); }
        if(work?.IsFaulted==true) TaskRuntime.ReportFault(OwnerId,work.Exception!.GetBaseException());
    }
}

public readonly struct TaskControl
{
    internal readonly int Action;
    internal readonly PedTask? Task;
    private TaskControl(int action, PedTask? task = null) { Action = action; Task = task; }
    public static TaskControl Continue => new(-1);
    public static TaskControl Finish => new(0);
    public static TaskControl Replace(PedTask task) => new(1, task ?? throw new ArgumentNullException(nameof(task)));
}

public static class NativeTasks
{
    public static PedTask StandStill(int milliseconds, bool loop = false, bool idleStance = true, float blend = 8)
    {
        if (milliseconds < -1 || !float.IsFinite(blend) || blend < 0) throw new ArgumentOutOfRangeException(nameof(milliseconds));
        return new PedTask.BuiltinTask(0, [milliseconds, loop ? 1 : 0, idleStance ? 1 : 0, BitConverter.SingleToInt32Bits(blend)]);
    }
    public static PedTask Wander(MoveState movement = MoveState.Walk, byte direction = 0, bool sensibly = true)
    {
        if (!Enum.IsDefined(movement) || direction > 7) throw new ArgumentOutOfRangeException(nameof(movement));
        return new PedTask.BuiltinTask(1, [(int)movement, direction, sensibly ? 1 : 0]);
    }
}

public sealed class PedTasks
{
    private readonly Char ped;
    internal PedTasks(Char ped) => this.ped = ped;
    private void Check() { if (!ped.Exists) throw new InvalidOperationException("Ped no longer exists."); }
    public void Assign(PedTask task, PrimaryTaskSlot slot = PrimaryTaskSlot.Primary) => Assign(task, (int)slot, false);
    public void AssignSecondary(PedTask task, SecondaryTaskSlot slot) => Assign(task, (int)slot, true);
    private void Assign(PedTask task, int slot, bool secondary)
    {
        ArgumentNullException.ThrowIfNull(task); Check();
        if (slot < 0 || slot >= (secondary ? 6 : 5)) throw new ArgumentOutOfRangeException(nameof(slot));
        uint id = task.Materialize();
        if (TaskRuntime.Call(2, task.OwnerId, id, ped.Handle, [slot, secondary ? 1 : 0]) == IntPtr.Zero)
            throw new InvalidOperationException("GTA rejected task assignment.");
        task.Transferred = true;
    }
    public void Clear(bool immediately = false) { Check(); Scm.Call((ushort)(immediately ? 0x0792 : 0x0687), ped); }
    public void Invoke(ScmOpcode opcode, params ScmArgument[] arguments)
    {
        Check(); var all = new ScmArgument[arguments.Length + 1]; all[0] = ped;
        arguments.CopyTo(all, 1); Scm.Call(opcode, all);
    }
    public void Invoke(TaskOpcode opcode, params ScmArgument[] arguments) => Invoke((ScmOpcode)opcode, arguments);
    public void StandStill(int milliseconds) => Invoke((ScmOpcode)0x05BA, milliseconds);
    public void Pause(int milliseconds) => Invoke((ScmOpcode)0x05B9, milliseconds);
    public void GoTo(Vector3 position, MoveState movement = MoveState.Walk, int timeout = -1)
    {
        Entity.ValidatePosition(position);
        if (!Enum.IsDefined(movement) || timeout < -1) throw new ArgumentOutOfRangeException(nameof(movement));
        Invoke((ScmOpcode)0x05D3, position.X, position.Y, position.Z, (int)movement, timeout);
    }
    public void Wander() => Invoke((ScmOpcode)0x05DE);
    public void HandsUp(int milliseconds) => Invoke((ScmOpcode)0x05C4, milliseconds);
    public int SequenceProgress { get { Check(); var value = new ScmVariable(-1); Scm.Call((ushort)0x0646, ped, value); return value.Int32; } }
}

/// <summary>Records task descriptions in managed memory; compiles/assigns atomically on Perform.</summary>
public sealed class TaskSequence
{
    private readonly List<(ScmOpcode Opcode, ScmArgument[] Arguments)> tasks = [];
    public bool Repeat { get; set; }
    public TaskSequence Add(ScmOpcode opcode, params ScmArgument[] arguments)
    {
        if (!SdkTaskOpcodes.IsTask((ushort)opcode)) throw new ArgumentException("Only SDK TASK_* opcodes belong in sequences.", nameof(opcode));
        if (tasks.Count>=8) throw new InvalidOperationException("Stock GTA SA sequences contain at most eight tasks.");
        tasks.Add((opcode, arguments.ToArray())); return this;
    }
    public TaskSequence Add(TaskOpcode opcode, params ScmArgument[] arguments) => Add((ScmOpcode)opcode,arguments);
    public TaskSequence StandStill(int milliseconds) => Add((ScmOpcode)0x05BA, milliseconds);
    public TaskSequence GoTo(Vector3 position, MoveState movement = MoveState.Walk, int timeout = -1)
    { Entity.ValidatePosition(position); return Add((ScmOpcode)0x05D3, position.X, position.Y, position.Z, (int)movement, timeout); }
    public void Perform(Char ped)
    {
        if (tasks.Count == 0) throw new InvalidOperationException("Sequence is empty.");
        if (!ped.Exists) throw new InvalidOperationException("Ped no longer exists.");
        var sequence = new ScmVariable(-1);
        bool open = false;
        try
        {
            Scm.Call((ushort)0x0615, sequence); open = true;
            foreach (var task in tasks)
            {
                var all = new ScmArgument[task.Arguments.Length + 1]; all[0] = -1;
                task.Arguments.CopyTo(all,1); Scm.Call(task.Opcode,all);
            }
            Scm.Call((ushort)0x0616, sequence); open = false;
            Scm.Call((ushort)0x0643, sequence, Repeat);
            Scm.Call((ushort)0x0618, ped, sequence);
        }
        finally
        {
            try { if (open && sequence.Int32 >= 0) Scm.Call((ushort)0x0616, sequence); }
            finally { if (sequence.Int32 >= 0) Scm.Call((ushort)0x061B, sequence); }
        }
    }
}

internal static class TaskRuntime
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate IntPtr Bridge(int op, uint owner, uint task, int arg, IntPtr data, int count);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate IntPtr Callback(uint task, int eventId, int ped, int arg, IntPtr data);
    private sealed record Host(ModContext Context, Action<Action> Invoke, Action<Exception> Fault);
    private static readonly Dictionary<uint, Host> hosts = [];
    private static readonly Dictionary<uint, PedTask> states = [];
    private static readonly Callback callback = Dispatch;
    private static Bridge bridge = null!;
    private static uint nextOwner;
    internal static uint CurrentOwner => ModContext.Current?.TaskOwner ?? throw new InvalidOperationException("Task operations require an active script context.");
    internal static void Bind(IntPtr pointer) => bridge = Marshal.GetDelegateForFunctionPointer<Bridge>(pointer);
    internal static void Begin(ModContext context, Action<Action> invoke, Action<Exception> fault)
    {
        uint owner = checked(++nextOwner);
        if (bridge(0,owner,0,0,Marshal.GetFunctionPointerForDelegate(callback),0) == IntPtr.Zero) throw new InvalidOperationException("Cannot register native task owner.");
        context.TaskOwner = owner; hosts.Add(owner, new(context,invoke,fault));
    }
    internal static IntPtr Call(int operation, uint owner, uint task = 0, int argument = 0, int[]? data = null)
    {
        Game.CheckThread();
        if (data is null || data.Length == 0) return bridge(operation,owner,task,argument,IntPtr.Zero,0);
        var pinned = GCHandle.Alloc(data,GCHandleType.Pinned);
        try { return bridge(operation,owner,task,argument,pinned.AddrOfPinnedObject(),data.Length); }
        finally { pinned.Free(); }
    }
    internal static void Create(PedTask task, int kind, int[] parameters)
    {
        uint owner = CurrentOwner;
        uint id = (uint)Call(1,owner,argument:kind,data:parameters);
        if (id == 0) throw new InvalidOperationException("Native task creation failed.");
        task.OwnerId=owner; task.NativeId=id;
        if (task is ManagedSimpleTask or ManagedComplexTask) states.Add(id,task);
    }
    internal static PedTask? Find(uint id) => states.GetValueOrDefault(id);
    internal static void Forget(uint id) => states.Remove(id);
    internal static void ReportFault(uint owner,Exception exception) { if(hosts.TryGetValue(owner,out var host)) host.Fault(exception); }
    internal static void End(uint owner)
    {
        Call(4,owner);
        foreach (var id in states.Where(pair => pair.Value.OwnerId==owner).Select(pair=>pair.Key).ToArray()) states.Remove(id);
        hosts.Remove(owner);
    }
    private static IntPtr Dispatch(uint id, int eventId, int pedHandle, int argument, IntPtr data)
    {
        Host? host=null;
        IntPtr result = IntPtr.Zero;
        try
        {
            if (!states.TryGetValue(id,out var task) || !hosts.TryGetValue(task.OwnerId,out host)) return IntPtr.Zero;
            Game.CheckThread();
            host.Invoke(() =>
            {
                var ped = pedHandle >= 0 ? new Ped(pedHandle) : null;
                bool flag = false;
                if (eventId == 4)
                {
                    PedTask copy = task is ManagedSimpleTask simple ? simple.CloneState() : ((ManagedComplexTask)task).CloneState();
                    if (copy is null || ReferenceEquals(copy,task) || copy.NativeId!=0 || copy.Disposed) throw new InvalidOperationException("CloneState must return a fresh task instance.");
                    copy.OwnerId=task.OwnerId; copy.NativeId=(uint)data; copy.Transferred=true;
                    states.Add(copy.NativeId,copy); result=(IntPtr)1; return;
                }
                if (task is ManagedSimpleTask s)
                {
                    switch(eventId)
                    {
                        case 0: flag=s.ProcessPed(ped!); break;
                        case 1: flag=s.SetPedPosition(ped!); break;
                        case 2: flag=s.MakeAbortable(ped!, (AbortPriority)argument,data); break;
                        case 3: s.StopTimer(data); break;
                        case 5: try { s.OnDeleted(); } finally { states.Remove(id); } break;
                    }
                }
                else if (task is ManagedComplexTask c)
                {
                    switch(eventId)
                    {
                        case 2: flag=c.MakeAbortable(ped!, (AbortPriority)argument,data); break;
                        case 3: c.StopTimer(data); break;
                        case 5: try { c.OnDeleted(); } finally { states.Remove(id); } break;
                        case 6: result=(IntPtr)(c.CreateFirstSubTask(ped!)?.Transfer() ?? 0); return;
                        case 7: result=(IntPtr)(c.CreateNextSubTask(ped!)?.Transfer() ?? 0); return;
                        case 8:
                            var control=c.ControlSubTask(ped!);
                            result=control.Action==-1 ? new IntPtr(-1) : control.Action==0 ? IntPtr.Zero : (IntPtr)control.Task!.Transfer(); return;
                    }
                }
                result=flag ? (IntPtr)1 : IntPtr.Zero;
            });
        }
        catch (Exception ex)
        {
            try {host?.Fault(ex);}catch { }
            Log.ReportException(host?.Context.Name??"Loader","Managed task callback failed",ex);
            result=eventId==0?(IntPtr)1:IntPtr.Zero;
        }
        return result;
    }
}
