using System.Numerics;

namespace SharpAndreas;

public abstract class Entity
{
    protected Entity(int handle)
    {
        if (handle < 0) throw new ArgumentOutOfRangeException(nameof(handle));
        Handle = handle;
    }
    public int Handle { get; }
    protected abstract ScmOpcode ExistsCommand { get; }
    protected abstract ScmOpcode GetPositionCommand { get; }
    protected abstract ScmOpcode SetPositionCommand { get; }
    protected abstract ScmOpcode GetHeadingCommand { get; }
    protected abstract ScmOpcode SetHeadingCommand { get; }
    protected abstract ScmOpcode GetModelCommand { get; }
    protected abstract ScmOpcode DeleteCommand { get; }
    protected abstract ScmOpcode ReleaseCommand { get; }
    public bool Exists => Scm.Call(ExistsCommand, Handle);
    protected void RequireExists()
    {
        if (!Exists) throw new InvalidOperationException($"{GetType().Name} handle {Handle} no longer exists.");
    }
    public Vector3 Position
    {
        get
        {
            RequireExists();
            var x = new ScmVariable(); var y = new ScmVariable(); var z = new ScmVariable();
            Scm.Call(GetPositionCommand, Handle, x, y, z);
            return new(x.Single, y.Single, z.Single);
        }
        set
        {
            ValidatePosition(value); RequireExists();
            Scm.Call(SetPositionCommand, Handle, value.X, value.Y, value.Z);
        }
    }
    public float Heading
    {
        get { RequireExists(); var value = new ScmVariable(); Scm.Call(GetHeadingCommand, Handle, value); return value.Single; }
        set { if (!float.IsFinite(value)) throw new ArgumentOutOfRangeException(nameof(value)); RequireExists(); Scm.Call(SetHeadingCommand, Handle, value); }
    }
    public int Model
    {
        get { RequireExists(); var value = new ScmVariable(); Scm.Call(GetModelCommand, Handle, value); return value.Int32; }
    }
    public virtual void Delete() { if (Exists) Scm.Call(DeleteCommand, Handle); }
    /// <summary>Releases the script claim so GTA can clean up this entity when appropriate; does not delete it immediately.</summary>
    public void MarkAsNoLongerNeeded() { if (Exists) Scm.Call(ReleaseCommand, Handle); }
    internal static void ValidatePosition(Vector3 value)
    {
        if (!float.IsFinite(value.X) || !float.IsFinite(value.Y) || !float.IsFinite(value.Z))
            throw new ArgumentOutOfRangeException(nameof(value), "Position must be finite.");
    }
    public override string ToString() => $"{GetType().Name}({Handle})";
}

/// <summary>SCM character handle. Ped is a synonymous, more specific .NET wrapper.</summary>
public class Char(int handle) : Entity(handle)
{
    public PedTasks Tasks => new(this);
    private readonly Lazy<Sdk.CPed> native = new(
        () => Sdk.CPools.GetPed(handle) ?? throw new InvalidOperationException("Ped no longer exists."),
        LazyThreadSafetyMode.ExecutionAndPublication);
    public Sdk.CPed Native
    {
        get
        {
            RequireExists();
            return native.Value;
        }
    }
    protected override ScmOpcode ExistsCommand => ScmOpcode.DoesCharExist;
    protected override ScmOpcode GetPositionCommand => ScmOpcode.GetCharCoordinates;
    protected override ScmOpcode SetPositionCommand => ScmOpcode.SetCharCoordinates;
    protected override ScmOpcode GetHeadingCommand => ScmOpcode.GetCharHeading;
    protected override ScmOpcode SetHeadingCommand => ScmOpcode.SetCharHeading;
    protected override ScmOpcode GetModelCommand => ScmOpcode.GetCharModel;
    protected override ScmOpcode DeleteCommand => ScmOpcode.DeleteChar;
    protected override ScmOpcode ReleaseCommand => ScmOpcode.MarkCharAsNoLongerNeeded;
    public int Health
    {
        get { RequireExists(); var value = new ScmVariable(); Scm.Call(ScmOpcode.GetCharHealth, Handle, value); return value.Int32; }
        set { if (value < 0) throw new ArgumentOutOfRangeException(nameof(value)); RequireExists(); Scm.Call(ScmOpcode.SetCharHealth, Handle, value); }
    }
    public int Armour
    {
        get { RequireExists(); var value = new ScmVariable(); Scm.Call(ScmOpcode.GetCharArmour, Handle, value); return value.Int32; }
    }
    public void AddArmour(int amount)
    {
        if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
        RequireExists(); Scm.Call(ScmOpcode.AddArmourToChar, Handle, amount);
    }
    public Vehicle? CurrentVehicle
    {
        get
        {
            RequireExists();
            if (!Scm.Call(ScmOpcode.IsCharInAnyCar, Handle)) return null;
            var value = new ScmVariable(-1); Scm.Call(ScmOpcode.StoreCarCharIsIn, Handle, value);
            return value.Int32 < 0 ? null : Vehicle.FromHandle(value.Int32);
        }
    }
    public override void Delete()
    {
        for (int i = 0; i < 2; i++)
            if (new Player(i).Character?.Handle == Handle) throw new InvalidOperationException("Cannot delete a player character.");
        base.Delete();
    }
}

public sealed class Ped(int handle) : Char(handle)
{
    public static async Task<Ped> CreateAsync(int model, Vector3 position, PedType type = PedType.CivilianMale, CancellationToken cancellationToken = default)
    {
        Entity.ValidatePosition(position);
        if ((int)type is < 4 or > 31) throw new ArgumentOutOfRangeException(nameof(type));
        await Models.RequestAsync(model, cancellationToken);
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = new ScmVariable(-1);
            Scm.Call(ScmOpcode.CreateChar, (int)type, model, position.X, position.Y, position.Z, value);
            var result = new Ped(value.Int32);
            if (!result.Exists) throw new InvalidOperationException("GTA could not create the ped.");
            return result;
        }
        finally { Models.MarkAsNoLongerNeeded(model); }
    }
}

public enum PedType
{
    Player1 = 0, Player2 = 1, NetworkPlayer = 2, UnusedPlayer = 3,
    CivilianMale = 4, CivilianFemale = 5, Cop = 6,
    Ballas = 7, Grove = 8, Vagos = 9, Rifa = 10, DaNangBoys = 11,
    Mafia = 12, Triads = 13, Forellis = 14, Sindaccos = 15, Gang10 = 16,
    Dealer = 17, Medic = 18, Fireman = 19, Criminal = 20, Bum = 21,
    Prostitute = 22, Special = 23, Mission1 = 24, Mission2 = 25,
    Mission3 = 26, Mission4 = 27, Mission5 = 28, Mission6 = 29, Mission7 = 30, Mission8 = 31
}

/// <summary>A player slot (0 or 1), distinct from its current ped's SCM handle.</summary>
public sealed partial class Player
{
    public Player(int index = 0)
    {
        if (index is < 0 or > 1) throw new ArgumentOutOfRangeException(nameof(index));
        Index = index;
    }
    public int Index { get; }
    public static Player Local { get; } = new(0);
    public bool IsPlaying => Scm.Call(ScmOpcode.IsPlayerPlaying, Index);
    public Ped? Character
    {
        get
        {
            if (!IsPlaying) return null;
            var value = new ScmVariable(-1); Scm.Call(ScmOpcode.GetPlayerChar, Index, value);
            if (value.Int32 < 0) return null;
            var ped = new Ped(value.Int32);
            return ped.Exists ? ped : null;
        }
    }
    public void SetControl(bool enabled) => Scm.Call(ScmOpcode.SetPlayerControl, Index, enabled);
    public PedGroup Group
    {
        get { if(!IsPlaying)throw new InvalidOperationException("Player is not active.");var value=new ScmVariable(-1); Scm.Call(ScmOpcode.GetPlayerGroup,Index,value); return PedGroup.FromHandle(value.Int32); }
    }
    public Gang Gang => SharpAndreas.Gang.ForPlayer(this);
}

public partial class Vehicle(int handle) : Entity(handle)
{
    private readonly Lazy<Sdk.CVehicle> native = new(
        () => Sdk.CPools.GetVehicle(handle) ?? throw new InvalidOperationException("Vehicle no longer exists."),
        LazyThreadSafetyMode.ExecutionAndPublication);
    public Sdk.CVehicle Native
    {
        get
        {
            RequireExists();
            return native.Value;
        }
    }
    public VehicleKind Kind { get { RequireExists(); return (VehicleKind)(int)Native.VehicleSubClass; } }
    protected void RequireKind(VehicleKind kind) { RequireExists(); if(Kind!=kind) throw new InvalidOperationException($"Vehicle {Handle} is {Kind}, expected {kind}."); }
    public static Vehicle FromHandle(int handle)
    {
        var value=new Vehicle(handle);
        return value.Kind switch { VehicleKind.Boat=>new Boat(handle), VehicleKind.Automobile=>new Car(handle), VehicleKind.Train=>new Train(handle), VehicleKind.Trailer=>new Trailer(handle), VehicleKind.Plane=>new Plane(handle), VehicleKind.Helicopter=>new Helicopter(handle), _=>value };
    }
    protected override ScmOpcode ExistsCommand => ScmOpcode.DoesVehicleExist;
    protected override ScmOpcode GetPositionCommand => ScmOpcode.GetCarCoordinates;
    protected override ScmOpcode SetPositionCommand => ScmOpcode.SetCarCoordinates;
    protected override ScmOpcode GetHeadingCommand => ScmOpcode.GetCarHeading;
    protected override ScmOpcode SetHeadingCommand => ScmOpcode.SetCarHeading;
    protected override ScmOpcode GetModelCommand => ScmOpcode.GetCarModel;
    protected override ScmOpcode DeleteCommand => ScmOpcode.DeleteCar;
    protected override ScmOpcode ReleaseCommand => ScmOpcode.MarkCarAsNoLongerNeeded;
    public int Health
    {
        get { RequireExists(); var value = new ScmVariable(); Scm.Call(ScmOpcode.GetCarHealth, Handle, value); return value.Int32; }
        set { if (value < 0) throw new ArgumentOutOfRangeException(nameof(value)); RequireExists(); Scm.Call(ScmOpcode.SetCarHealth, Handle, value); }
    }
    public static async Task<Vehicle> CreateAsync(int model, Vector3 position, CancellationToken cancellationToken = default)
    {
        ValidatePosition(position);
        await Models.RequestAsync(model, cancellationToken);
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = new ScmVariable(-1);
            Scm.Call(ScmOpcode.CreateCar, model, position.X, position.Y, position.Z, value);
            var result = FromHandle(value.Int32);
            if (!result.Exists) throw new InvalidOperationException("GTA could not create the vehicle.");
            return result;
        }
        finally { Models.MarkAsNoLongerNeeded(model); }
    }
}

public sealed class Prop(int handle) : Entity(handle)
{
    private readonly Lazy<Sdk.CObject> native = new(
        () => Sdk.CPools.GetObject(handle) ?? throw new InvalidOperationException("Object no longer exists."),
        LazyThreadSafetyMode.ExecutionAndPublication);
    public Sdk.CObject Native
    {
        get
        {
            RequireExists();
            return native.Value;
        }
    }
    protected override ScmOpcode ExistsCommand => ScmOpcode.DoesObjectExist;
    protected override ScmOpcode GetPositionCommand => ScmOpcode.GetObjectCoordinates;
    protected override ScmOpcode SetPositionCommand => ScmOpcode.SetObjectCoordinates;
    protected override ScmOpcode GetHeadingCommand => ScmOpcode.GetObjectHeading;
    protected override ScmOpcode SetHeadingCommand => ScmOpcode.SetObjectHeading;
    protected override ScmOpcode GetModelCommand => ScmOpcode.GetObjectModel;
    protected override ScmOpcode DeleteCommand => ScmOpcode.DeleteObject;
    protected override ScmOpcode ReleaseCommand => ScmOpcode.MarkObjectAsNoLongerNeeded;
    public static async Task<Prop> CreateAsync(int model, Vector3 position, CancellationToken cancellationToken = default)
    {
        ValidatePosition(position);
        await Models.RequestAsync(model, cancellationToken);
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            var value = new ScmVariable(-1);
            Scm.Call(ScmOpcode.CreateObject, model, position.X, position.Y, position.Z, value);
            var result = new Prop(value.Int32);
            if (!result.Exists) throw new InvalidOperationException("GTA could not create the object.");
            return result;
        }
        finally { Models.MarkAsNoLongerNeeded(model); }
    }
}

public static class Models
{
    /// <summary>Requests streaming, yielding frames until the model is loaded. Release the request when finished.</summary>
    public static async Task RequestAsync(int model, CancellationToken cancellationToken = default)
    {
        if (model < 0) throw new ArgumentOutOfRangeException(nameof(model));
        cancellationToken.ThrowIfCancellationRequested();
        Scm.Call(ScmOpcode.RequestModel, model);
        try
        {
            while (!Scm.Call(ScmOpcode.HasModelLoaded, model)) await Script.NextFrame(cancellationToken);
        }
        catch { MarkAsNoLongerNeeded(model); throw; }
    }
    /// <summary>Releases this script's streaming request; GTA may unload the model when no longer used.</summary>
    public static void MarkAsNoLongerNeeded(int model)
    {
        if (model < 0) throw new ArgumentOutOfRangeException(nameof(model));
        Scm.Call(ScmOpcode.MarkModelAsNoLongerNeeded, model);
    }
}
