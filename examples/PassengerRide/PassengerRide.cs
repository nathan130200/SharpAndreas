using System.Diagnostics;
using System.Numerics;
using SharpAndreas;

public sealed class PassengerRide : Mod
{
    private const float SearchRadius = 10f;
    private const int EntryTimeoutMilliseconds = 10000;
    private bool previousG, previousF;
    private Vehicle? entering;
    private int enteringPed = -1;
    private long entryStarted;

    public override async Task RunAsync(ModContext context, CancellationToken cancellationToken)
    {
        previousG = Game.IsKeyDown(0x47);
        previousF = Game.IsKeyDown(0x46);
        Log.Info("PassengerRide ready: G enters a nearby passenger seat; F exits.");
        try
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                UpdateInput();
                await NextFrame(cancellationToken); // Poll each game frame without blocking GTA.
            }
        }
        finally
        {
            // Ambient vehicles and their engine-owned tasks are not owned by this mod.
            entering = null;
            Log.Info("PassengerRide stopped.");
        }
    }

    private void UpdateInput()
    {
        bool g = Game.IsKeyDown(0x47), f = Game.IsKeyDown(0x46);
        bool enterPressed = g && !previousG, exitPressed = f && !previousF;
        previousG = g;
        previousF = f;

        if (entering is not null && Stopwatch.GetElapsedTime(entryStarted).TotalMilliseconds >= EntryTimeoutMilliseconds)
            entering = null;

        // Leave cutscenes, wasted/arrested states and disabled player controls alone.
        if (!enterPressed && !exitPressed && entering is null) return;
        var ped = Player.Local.Character;
        if (ped is null || ped.Health <= 0 || !Scm.Call(0x09E7, Player.Local.Index))
        {
            entering = null;
            return;
        }

        var current = ped.CurrentVehicle;
        if (current is not null)
        {
            entering = null;
            if (exitPressed)
            {
                ped.Tasks.Invoke(TaskOpcode.TASK_LEAVE_CAR, current);
                Log.Info($"Leaving vehicle {current.Handle}.");
            }
            return;
        }

        if (entering is not null && (enteringPed != ped.Handle || !entering.Exists)) entering = null;
        if (!enterPressed || exitPressed || entering is not null) return;

        Vector3 position = ped.Position;
        var candidates = World.GetNearbyVehicles(position, SearchRadius)
            .Where(vehicle => vehicle.Exists && vehicle.Kind is VehicleKind.Automobile or VehicleKind.MonsterTruck)
            .OrderBy(vehicle => Vector3.DistanceSquared(position, vehicle.Position));

        foreach (var vehicle in candidates)
        {
            if (vehicle.Health <= 0) continue;
            var capacity = new ScmVariable();
            Scm.Call(0x01EA, vehicle, capacity); // GET_MAXIMUM_NUMBER_OF_PASSENGERS
            for (int seat = 0; seat < capacity.Int32; seat++)
            {
                // Passenger indices start at zero; the driver's seat is never requested.
                if (!Scm.Call(0x0431, vehicle, seat)) continue; // IS_CAR_PASSENGER_SEAT_FREE
                ped.Tasks.Invoke(TaskOpcode.TASK_ENTER_CAR_AS_PASSENGER, vehicle, EntryTimeoutMilliseconds, seat);
                entering = vehicle;
                enteringPed = ped.Handle;
                entryStarted = Stopwatch.GetTimestamp();
                Log.Info($"Entering vehicle {vehicle.Handle} as passenger (seat {seat}).");
                return;
            }
        }
        Game.ShowHelp("No nearby car has a free passenger seat.");
    }
}
