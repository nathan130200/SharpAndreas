# Modding with the SharpAndreas C# API

SharpAndreas runs .NET 10 mods inside the 32-bit GTA San Andreas process. This guide describes the API shipped in this project. See `examples/PassengerRide` for a complete G/F passenger-entry sample, and `examples/HelloCS` for a smaller starting point.

Quick navigation:

- [Installed directory structure and naming rules](#directory-structure-start-here)
- [Create a C# project](#create-a-project) and [write a complete mod](#write-a-mod)
- [TOML files and log formats](#file-formats-logging-loader-options-and-mod-settings)
- [IDs, handles, coordinates and other API value formats](#reading-api-values-and-argument-formats)
- [World queries](#query-entities-in-the-world), [path nodes](#path-nodes), and [tasks/SCM](#ped-tasks-and-scm)
- [Additional game systems](API-SYSTEMS.md), [decision makers](DECISION_MAKERS.md), and [Grove Street race](README.md#grove-street-race-sample)
- [Dependencies, reload and troubleshooting](#dependencies-reload-and-troubleshooting)

## Directory structure: start here

Keep the **source root** (`C:\Projects\gta_sa_clr`) separate from the **game root** (`C:\Games\GTA San Andreas`, containing gta_sa.exe). Build in the source root, then copy the contents of dist into the game root. `[game]` below means the game root.

### Complete installed layout

```text
[game]/
|-- gta_sa.exe
|-- SharpAndreas.asi                    # native x86 plugin
`-- SharpAndreas/
    |-- SharpAndreas.toml               # loader-wide configuration
    |-- plugin.log                     # unified native/.NET/Trace log
    |-- Runtime/                       # deploy the full generated Runtime directory
    |   |-- SharpAndreas.Api.dll
    |   |-- SharpAndreas.Runtime.dll
    |   |-- SharpAndreas.Runtime.deps.json
    |   |-- SharpAndreas.Runtime.runtimeconfig.json
    |   `-- Tomlyn.dll
    |-- Libraries/                     # shared dependencies; kept until GTA exits
    |   `-- SharedTools.dll            # optional example
    `-- Mods/
        |-- MyExample/                 # one independently loaded mod
        |   |-- mod.tml                # REQUIRED entry manifest; TOML syntax, .tml extension
        |   |-- MyExample.dll          # path selected by assembly in mod.tml
        |   |-- MyExample.deps.json    # optional dependency metadata
        |   |-- script.toml            # optional loader-controlled enabled switch
        |   |-- settings.toml          # optional settings loaded by your own code
        |   |-- Libraries/             # private libraries for this mod/context
        |   |   `-- PrivateTools.dll
        |   `-- Assets/                # optional files your own code reads
        |       `-- message.txt
        |-- PassengerRide/
        |   |-- mod.tml
        |   `-- PassengerRide.dll
        |-- NpcHealthBars/
        |   |-- mod.tml
        |   `-- NpcHealthBars.dll
        `-- VehicleHealthText/
            |-- mod.tml
            `-- VehicleHealthText.dll
```

Optional filenames above illustrate placement; not every mod needs them. Runtime contains the host and its dependencies and should be copied as a whole. The host supplies SharpAndreas.Api at runtime; do not install another copy inside each mod. Managed mods stay `.dll` files; only the native loader is an `.asi`.

### Minimum valid mod and its manifest

```text
[game]/SharpAndreas/Mods/MyExample/
|-- mod.tml
`-- MyExample.dll
```

Put this exact file, named **mod.tml**, directly inside MyExample:

```toml
name = "My Example"
version = "1.0.0.0"
assembly = "MyExample.dll"
main-class = "MyMods.MyExample"
```

The extension `.tml` follows the loader's manifest convention; the contents use ordinary TOML. All four values are **quoted strings**, including version. `name = ModName` and `version = 1.0.0.0` are not valid representations of these strings.

| Field | Meaning | Rule |
| --- | --- | --- |
| name | Display/logging name, e.g. My Example. | Required nonempty string; at most 128 characters, no control characters. |
| version | Mod version printed on load/failure; profiler rows omit it. | Required string; at most 64 letters, digits, dots, `-`, `+` or `_`. Four-component versions such as 1.0.0.0 are accepted. |
| assembly | Entry DLL path relative to this mod directory. | Required .dll path contained within the mod directory; absolute paths and paths escaping it are rejected. |
| main-class | Exact fully qualified .NET type to instantiate from that DLL. | Public concrete Mod subclass, no open generic parameters, public parameterless constructor. Name and namespace are case-sensitive. |

The folder name is the stable `context.ModId`. The name field is `context.Name` and `context.ScriptName`; it labels logs and overlays. The implementation class is selected explicitly by main-class. These values **do not have to match**. `[Mod(...)]` has been removed; there is no attribute metadata fallback or class-name discovery fallback.

For the manifest above, the entry class declaration is `namespace MyMods; public sealed class MyExample : Mod`. One instance of that selected class is created for this manifest. Other types in its DLL are not automatically started.

### An entry DLL inside a subfolder

This is also valid:

```text
Mods/MyExample/
|-- mod.tml
|-- bin/
|   |-- Gameplay.dll
|   `-- Gameplay.deps.json
`-- Libraries/
    `-- PrivateTools.dll
```

```toml
name = "Passenger Helper"
version = "2.1.0.0"
assembly = "bin/Gameplay.dll"
main-class = "MyCompany.Gameplay.PassengerEntry"
```

Use forward slashes in double-quoted relative paths, as above. With Windows backslashes, use a TOML literal string such as `assembly = 'bin\Gameplay.dll'`, or escape the backslash in a double-quoted string. An assembly-qualified type name containing a comma is not accepted for main-class; specify just Namespace.ClassName.

### Discovery and common mistakes

The loader inspects each immediate child directory of Mods for mod.tml. It does not search DLLs to guess which class to start. A DLL without a manifest is not a complete mod. `mod.toml` is a different filename and does not replace the required mod.tml.

| Incorrect placement/configuration | Correction |
| --- | --- |
| `[game]/SharpAndreas/MyExample/` | Put the directory inside SharpAndreas/Mods. |
| `Mods/MyExample.dll` | Create a mod directory containing mod.tml and the assembly. |
| `Mods/MyExample/config/mod.tml` | Put the manifest directly in MyExample. |
| assembly names bin/Gameplay.dll, but only MyExample.dll is deployed | Deploy the exact selected DLL path, or correct assembly. |
| main-class is MyMods.Entry, but the class is OtherNamespace.Entry | Set the exact fully qualified type name. |
| name is a bare unquoted word | Quote it as a TOML string. |

Each independent mod gets its own top-level directory and manifest. Libraries under a mod's Libraries directory are dependencies, not additional mods. A helper class may be public; only the manifest-selected entry class is instantiated.

### Private versus shared dependencies

For managed assemblies, resolution checks the mod's root Libraries directory first, then the selected assembly's directory, then the mod root, then dependency metadata, and then SharpAndreas/Libraries. Framework assemblies use the hosted runtime, and SharpAndreas.Api always shares the host identity.

A private library can override a shared version for its mod. Private managed dependencies are loaded into the mod's collectible context. Shared libraries remain in the default context until GTA exits; restart the game after replacing them. Put directly resolved DLLs immediately inside Libraries; arbitrary nested package folders are not automatically searched by name.

Deploy actual dependency DLLs and their dependencies, not .nupkg archives. Keep the entry assembly's matching .deps.json if package resolution needs it. Native dependencies must be x86; private native libraries also belong in the mod's root Libraries directory. Native DLLs are loaded from disk and are not memory-reloadable.

Optional PDBs are debug symbols, not entry assemblies; the loader currently does not supply them to memory-loaded assemblies. The runtimeconfig.json in Runtime configures the host. A mod does not start its own CLR using a separate runtimeconfig.json.

### Mod data and deployment

Read assets relative to context.Directory, which is always the mod directory even when assembly points into bin:

```csharp
string filename = System.IO.Path.Combine(context.Directory, "Assets", "message.txt");
string text = File.ReadAllText(filename); // After creating that asset file.
```

Assembly.Location is empty for memory-loaded assemblies. The loader does not change the process working directory. context.Config already resolves configuration filenames within context.Directory.

Keep development projects separate from installed mod directories. After `dotnet build -c Release`, deploy the compiled DLL, its **mod.tml**, any required dependency metadata, and its private dependencies. Preserve script.toml, settings.toml and saved data when upgrading. Changes to mod.tml or managed DLL/dependency files trigger reload after stabilization; script.toml and settings.toml are not automatic reload triggers.

All supplied examples include a mod.tml that build.ps1 copies into dist. Copying the contents of dist beside gta_sa.exe installs the loader and these samples without rebuilding manifests manually.

## Create a project

The local NuGet feed is `C:\Projects\.nuget`. It contains SharpAndreas.Api.1.1.0.nupkg and its Tomlyn dependency. Create a class library and save the following as MyExample.csproj:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <PlatformTarget>x86</PlatformTarget>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="SharpAndreas.Api" Version="1.1.0" />
  </ItemGroup>
</Project>
```

Save this NuGet.Config beside the project to use the local feed offline:

```xml
<configuration>
  <packageSources>
    <clear />
    <add key="SharpAndreasLocal" value="C:\Projects\.nuget" />
  </packageSources>
</configuration>
```

Add other package sources if you need other packages. Build with `dotnet build -c Release`. The package supplies the API reference and defaults AnyCPU projects to x86; an explicit incompatible target is rejected. The package version identifies the API dependency and is independent of the mod version string in mod.tml.

You can also use a ProjectReference to the API source, as the bundled examples do. The package contains the API only; install the matching ASI and Runtime files in GTA as well.

## Write a mod

This is a complete compilable script. Save it as MyExample.cs beside MyExample.csproj. Later code blocks are API fragments: unless stated otherwise, place them inside a lifecycle method and obtain variables such as ped, car, position and token first.

Save this as MyExample.cs:

```csharp
using SharpAndreas;

namespace MyMods;
public sealed class MyExample : Mod
{
    private Settings settings = new();
    private bool previousF6;

    public override void Start(ModContext context)
    {
        settings = context.Config.Load<Settings>();
        if (!float.IsFinite(settings.Radius) || settings.Radius < 0)
            throw new FormatException("Radius must be a finite, nonnegative number.");
        Log.Info("Ready: press F6.");
    }

    public override async Task RunAsync(ModContext context, CancellationToken token)
    {
        while (true)
        {
            token.ThrowIfCancellationRequested();
            bool pressed = Game.IsKeyDown(0x75); // Windows virtual-key code: F6
            if (pressed && !previousF6)
            {
                var ped = Player.Local.Character;
                if (ped is not null)
                {
                    var cars = World.GetNearbyVehicles(ped.Position, settings.Radius);
                    Log.Info($"Player health: {ped.Health}; nearby vehicles: {cars.Length}");
                }
            }
            previousF6 = pressed;
            await NextFrame(token);
        }
    }

    public override void Stop() => Log.Info("Stopped.");

    public sealed class Settings
    {
        public float Radius { get; set; } = 25f;
    }
}
```

Build using `dotnet build -c Release`. Copy MyExample.dll into:

```text
[game]/SharpAndreas/Mods/MyExample/MyExample.dll
```

Deploy the minimum mod.tml shown above alongside the DLL. The first run creates settings.toml in that folder. The pause menu lists the count of active mod instances. To build the supplied examples and ASI together, run `./build.ps1` in the SharpAndreas source folder and copy the contents of dist beside gta_sa.exe.

## Lifecycle and cleanup

**Game-process lifetime:** Start runs when a mod instance is loaded, including after hot reload. Starting a new game or loading a save currently does **not** stop and restart mods. There is no game-session reset hook yet. Do not assume saved entity handles remain valid after a world reset; reacquire targets and check Exists. Do not keep a mission that owns world entities running across a manual new-game/save transition until this lifecycle is extended.

| Member | Purpose |
| --- | --- |
| Start(ModContext) | Synchronous initialization, configuration and subscriptions. |
| RunAsync(ModContext, CancellationToken) | One tracked async operation for the mod. |
| Tick() | A synchronous callback every eligible game frame. |
| Draw() | Per-rendered-frame callback for HUD commands, independently of the async script loop. |
| Stop() | Cleanup after cancellation, unloading, or a managed script failure. |

RunAsync and Tick can coexist; completing RunAsync does not disable Tick. Keep Start and Tick short. Cleanup belongs in finally blocks and/or Stop. Stop runs once for an instantiated mod even when Start or a later callback throws. A constructor that fails does not produce an instance to stop. Make cleanup tolerate partially initialized state.

Unsubscribe events, dispose your resources and remove only entities your mod owns. Cancellation can run async finally blocks on the game thread before Stop. Stop is synchronous: do not wait on incomplete tasks there.

## Async and thread rules

The loader supplies each mod with a game-thread synchronization context. Ordinary await captures it, so game API calls after an await normally resume on the game thread.

```csharp
await Delay(1000, token); // Inside Mod: suspend this operation for at least one second.
await NextFrame(token);   // Resume on a later eligible game frame.
await Script.Delay(250, token); // Equivalent helper for other classes on the game context.
```

Delay(0) yields a frame. Delay(-1) waits until cancellation. Await Task.Run for background CPU work, then return to the captured context before using GTA:

```csharp
int answer = await Task.Run(() => 6 * 7, token);
var player = Player.Local.Character; // Back on the captured game context.
```

Game APIs, entity properties, SCM commands, world/path queries and task assignment require the game thread. Thread-safe Lazy initialization of Native wrappers does not change that requirement. Avoid Thread.Sleep, blocking waits, Result/Wait on unfinished tasks, async void, and ConfigureAwait(false) before game access. Track and observe additional tasks you start; untracked work can outlive the mod. The scheduler cannot interrupt synchronous user code that blocks or loops forever.

Draw is a rendering callback and is not controlled by TickWhenPaused; check Game.IsPaused inside Draw if your HUD should disappear during pause. By default pause freezes Tick and captured game-thread continuations. Add `[TickWhenPaused]` to the Mod class to opt in. Background I/O already in progress can continue. Start and Stop remain lifecycle operations.

## File formats: logging, loader options and mod settings

Four configuration files serve different purposes:

| File | Resolved location | Who reads it | Typical contents |
| --- | --- | --- | --- |
| mod.tml | `[game]/SharpAndreas/Mods/MyExample/mod.tml` | Loader | Required entry name, version, assembly path and main-class. |
| SharpAndreas.toml | `[game]/SharpAndreas/SharpAndreas.toml` | Loader | Scheduler and reload options. |
| script.toml | `[game]/SharpAndreas/Mods/MyExample/script.toml` | Loader for this mod | The per-mod enabled switch. |
| settings.toml | `[game]/SharpAndreas/Mods/MyExample/settings.toml` | Your code through context.Config | Your mod's own settings. |

These are plain-text **TOML** files, not JSON or INI. Write booleans as true/false, quote strings, use `#` for comments, use `key = value` assignments, and use `[table_name]` for a nested object. `settings.toml` is the default filename for context.Config; you may use another simple filename ending in .toml.

### Unified log format


```csharp
Log.Info("Spawn completed");
Log.Error(new InvalidOperationException("Example diagnostic"));
System.Diagnostics.Trace.WriteLine("Also written to the unified log");
```

Native diagnostics, managed logs and Trace.Write/WriteLine/TraceError output share `[game]/SharpAndreas/plugin.log`. Each line has `[Timestamp] [ScriptName] [message or exception]`. The script name comes from name in mod.tml. `context.Log(...)` and `context.Config` remain bound to that mod; `Log.For<MyExample>()` supplies an explicitly named logger.

For example, Log.Info("Ready") from MyExample produces a line like:

```text
[2026-10-28 18:30:12.345] [My Example] [Ready]
```

The timestamp uses the local system time and includes milliseconds. The middle field is name from mod.tml. It can differ from the folder, DLL and implementation class names. Every Trace.Write call is written immediately as its own log record, even without a newline. Exceptions caught by the loader are reported through Trace.TraceError; .NET has no Trace.WriteError method. All loader-controlled unmanaged entry points and reverse task callbacks catch ordinary managed exceptions, report them, and return ABI-safe results. A broken external TraceListener cannot make diagnostics throw across those boundaries.

Exceptions can contain multiple lines; every output line receives the same timestamp/script/message bracket structure. Native loader diagnostics use Loader as their script name. For a helper that needs a fixed script identity, keep a logger from `Log.For<MyExample>()`.

### Loader-wide SharpAndreas.toml

The shipped format is:

```toml
enabled = true
profiler = false

[scheduler]
max_callbacks_per_frame = 64
budget_milliseconds = 2.0

[hot_reload]
enabled = true
poll_milliseconds = 500
stabilize_milliseconds = 500
```

The top-level enabled controls managed mod loading. `[hot_reload].enabled` controls automatic discovery/replacement while running. Poll is the interval between checks; stabilize is how long file metadata must remain unchanged before a replacement is read. All time fields here are milliseconds.

| Key | Meaning / accepted range |
| --- | --- |
| scheduler.max_callbacks_per_frame | Callback cap for a mod's scheduler pump; 1 through 4096. |
| scheduler.budget_milliseconds | Cooperative scheduler budget per pump; 0.1 through 50. This cannot interrupt a callback that blocks. |
| hot_reload.poll_milliseconds | 50 through 60000. |
| hot_reload.stabilize_milliseconds | 50 through 10000. |

Set profiler = true at the document root, before any table headers, to enable the native performance overlay described below.

Loader settings are read at startup. Restart GTA after editing this file.

### Per-mod script.toml

```toml
# In SharpAndreas/Mods/MyExample/script.toml
enabled = true
```

Set enabled to false to disable this mod when it is next loaded. This is a loader setting, separate from any Enabled property you define in your own settings class. Changing script.toml alone does not trigger automatic reload: restart GTA or redeploy the mod DLL to apply this switch. Do not use script.toml as your own settings filename; reserve it for the loader.

### Your own settings.toml

For the complete MyExample above, the equivalent settings file is simply:

```toml
radius = 25.0
```

For more structured settings, define an ordinary settings class and nested settings objects:

```csharp
public sealed class RideSettings
{
    public float SearchRadius { get; set; } = 10f;
    public int EntryTimeoutMilliseconds { get; set; } = 10000;
    public string WelcomeMessage { get; set; } = "Ready";
    public string[] Messages { get; set; } = ["Entering", "Leaving"];
    public KeySettings Keys { get; set; } = new();
}

public sealed class KeySettings
{
    public int Enter { get; set; } = 71; // G virtual-key code
    public int Exit { get; set; } = 70;  // F virtual-key code
}
```

Its corresponding TOML structure is:

```toml
search_radius = 10.0
entry_timeout_milliseconds = 10000
welcome_message = "Ready"
messages = ["Entering", "Leaving"]

[keys]
enter = 71
exit = 70
```

Keep the scalar settings above `[keys]`: after that header, assignments belong to the Keys table until another table starts. Do not wrap this whole file in `[MyExample]`; Load<RideSettings> expects RideSettings at the document root.

Property names convert from PascalCase to snake_case. A nested Keys object becomes the `[keys]` table. A string array becomes a TOML array. Numeric key codes are integers; the C# spelling 0x47 and decimal 71 represent the same value.

```csharp
// Inside Start, with the ModContext parameter named context:
RideSettings settings = context.Config.Load<RideSettings>();
if (!float.IsFinite(settings.SearchRadius) || settings.SearchRadius < 0 || settings.EntryTimeoutMilliseconds < 0)
    throw new FormatException("Invalid radius or entry timeout in settings.toml.");
```

Load creates a missing file from the class defaults, or deserializes an existing file. Save explicitly writes current values; editing an in-memory object does not save it automatically. An invalid TOML file throws a configuration error, which will disable the mod if it escapes Start. Keep filenames directly inside the mod directory: `"custom.toml"` is accepted; `"subdir/custom.toml"` is rejected by context.Config. There is no automatic live settings reload; call Load again from your code or reload the mod.

Use public settings properties with defaults and a public parameterless constructor:

```csharp
RideSettings settings = context.Config.Load<RideSettings>();
context.Config.Save(settings);
RideSettings other = context.Config.Load<RideSettings>("other.toml");
```

Configuration uses snake_case TOML names, lives in the mod directory, creates missing files and saves atomically. Validate settings before using them as game inputs. Loader-level options live in SharpAndreas/SharpAndreas.toml.

## Reading API values and argument formats

| Value / notation | Meaning | Example |
| --- | --- | --- |
| Model ID (`int`) | A model definition, shared by every instance using that model. | Vehicle model 411 is infernus. |
| Entity handle (`int`) | A particular live pool entry, including its generation. | car.Handle identifies one vehicle instance; its number is not a model ID. |
| Weapon ID (`WeaponType` / int) | The gameplay weapon type. | Pistol is 22; its model ID is 346. |
| Player index (`int`) | A player slot, not a ped handle. | Player.Local.Index is 0; Player.Local.Character is its current Ped. |
| PathNodeId | An area/index pair identifying a node in loaded path data. | `new PathNodeId(area, index)`. |
| `Vector3` | World X, Y and Z coordinates, using GTA world units. | `new Vector3(100f, 200f, 15f)`; Z is height. |
| Radius (`float`) | An inclusive 3D distance. | 10f includes an entity exactly 10 units away. Negative/NaN/infinite radii are rejected by world/path queries. |
| Heading (`float`) | Degrees in GTA's heading convention, not radians. | Path headings: 0 north, 90 west, 180 south, 270 east. |
| Duration / timeout (`int`) | Usually milliseconds; read the method's contract. | Delay(1000) is one second. Delay(-1) waits for cancellation. |
| Key code (`int`) | A Windows virtual-key code, not a gamepad action or text character. | G = 0x47 / 71; F = 0x46 / 70; F6 = 0x75 / 117. |
| Nullable value (`Ped?`, `PathNode?`, `float?`) | A result may be absent; test it before use. | `if (node is { } found) ...`. |
| Array (`Vehicle[]`) | A snapshot; zero matches produce an empty array. | GetNearbyVehicles(...).Length can be zero. |

A record struct such as PedInfo or VehicleInfo is a value snapshot with named fields exposed as properties. Reading it does not spawn anything. Modifying a copied record does not change GTA or the original catalogue. An entity wrapper such as Ped or Vehicle refers to a live object; setting its supported properties can change GTA.

The `?` annotation on a reference indicates it may be null; on a value such as PathNode it creates a nullable value type. Use checks or pattern matching instead of assuming a query always succeeds. Do not interchange model IDs, handles, weapon IDs and player indices simply because some are all represented as int.

## Entities and models

`Player` represents a player slot; `Player.Local.Character` is its current Ped and can be null during loading. `Char` is a character-handle wrapper; Ped derives from Char. Vehicle, Train, Trailer, Plane, Helicopter and Prop wrap their respective game entities.

```csharp
var ped = Player.Local.Character;
if (ped is not null)
{
    var position = ped.Position;
    int health = ped.Health;
    Vehicle? current = ped.CurrentVehicle;
}
```

An Entity has Handle, Exists, Position, Heading and Model. Additional operations depend on its type. Handles identify engine-owned pool entries; check Exists when retaining a wrapper across frames. A wrapper does not keep an entity alive.

```csharp
Vehicle car = await Vehicle.CreateAsync(411, position, token);
Ped actor = await Ped.CreateAsync(7, position, PedType.CivilianMale, token);
Prop prop = await Prop.CreateAsync(1337, position, token);
```

Use appropriate model IDs for each entity type. Creation streams models cooperatively. Specialized vehicles have typed factories; trains use Train.CreateMissionAsync rather than generic car creation. Delete removes an entity explicitly. MarkAsNoLongerNeeded releases the script claim so GTA can clean it up when appropriate. For streaming requests, use Models.RequestAsync followed by Models.MarkAsNoLongerNeeded when finished; there is no Release alias.

Store created entities in fields and clean them up safely when your mod ends, for example `if (createdCar?.Exists == true) createdCar.Delete();`. Do not delete the player's ped or delete/release ambient entities solely because a query returned them.

## Metadata catalogues

```csharp
var weapon = WeaponInfo.Get(WeaponType.Pistol); // Id 22, ModelId 346
var models = WeaponInfo.GetByModelId(364);      // Shared/secondary model matches
PedInfo skin = PedInfo.Get(7);
VehicleInfo car = VehicleInfo.Get(411);
```

WeaponInfo covers weapon IDs, fire types, slots and model IDs/names. PedInfo and VehicleInfo are readonly record structs covering model declarations and associated metadata. PedInfo includes PedType and a PedStats behavior profile; VehicleInfo includes VehicleKind, class and HandlingId.

All/Get/TryGet expose cached catalogues. PedInfo.TryGet and VehicleInfo.TryGet also accept model names, ignoring case. Use PedInfo.GetByPedType and VehicleInfo.GetByKind for categories. These are generated snapshots of the scanned data files, not live entity state; a spawned ped's faction or a vehicle's runtime handling may differ. Regeneration tools and source hashes are documented in README.md.

## Query entities in the world

```csharp
Ped[] peds = World.GetAllPeds();
Vehicle[] vehicles = World.GetNearbyVehicles(position, 50f);
Prop? closest = World.GetClosestProp(position, 20f);
```

All three types support GetAll*, GetNearby* and GetClosest*. Nearby uses an inclusive 3D radius. Closest returns null when no match exists. Queries include currently instantiated pool entities; ped results include the player. Vehicles preserve specialized wrapper types. Props are dynamic CObject entities, excluding static map buildings.

Results are snapshots and create managed wrappers. They do not spawn or claim entities. Retain a result when appropriate rather than repeatedly scanning unchanged data, and check Exists before later use.

## Path nodes

```csharp
PathNode? node = Paths.GetClosestVehicleNode(position, 100f);
PathNode? walk = Paths.GetClosestPedNode(position, 50f);
PathNode? second = Paths.GetNthClosestVehicleNode(position, 1, 100f);
if (walk is { } found)
{
    PathNode[] links = found.GetLinkedNodes();
    float? heading = found.Heading;
}
```

Nth rank is zero-based. Nodes expose an area/index Id, Type, Position, nullable Heading/HeadingTarget, Width, LinkCount and Flags. Paths.GetNode(id) and GetLinkedNodes(id) inspect loaded IDs. Missing nodes return null; absent loaded links return an empty array.

Queries inspect loaded path areas without forcing streaming. They exclude switched-off and water nodes by default; vehicle queries accept includeWater, and both categories accept includeSwitchedOff. Heading follows an eligible linked node, in GTA degrees (0 north, 90 west). It is a link direction rather than a lane-aware vehicle placement orientation. Re-query IDs after streaming changes.

## Ped tasks and SCM

```csharp
ped.Tasks.StandStill(1000);
ped.Tasks.GoTo(destination, MoveState.Walk);
new TaskSequence().StandStill(500).GoTo(destination).Perform(ped);
```

Sequences contain at most eight stock task commands. Use TaskOpcode for additional task commands:

```csharp
ped.Tasks.Invoke(TaskOpcode.TASK_ENTER_CAR_AS_PASSENGER, car, 10000, 0);
ped.Tasks.Invoke(TaskOpcode.TASK_LEAVE_CAR, car);
```

The Invoke call above expands to the stock TASK_ENTER_CAR_AS_PASSENGER argument order:

| Argument | Example | Meaning |
| --- | --- | --- |
| TaskOpcode | TASK_ENTER_CAR_AS_PASSENGER | The stock task to issue. |
| ped (supplied automatically by ped.Tasks.Invoke) | ped.Handle | The character receiving the task. |
| vehicle | car | The live vehicle handle, supplied through the wrapper. |
| time | 10000 | Entry timeout in milliseconds. |
| seat | 0 | Passenger index; zero is the front passenger, not the driver. |

For TASK_LEAVE_CAR the only explicit argument is the current vehicle. Never pass a vehicle model ID where a task expects a vehicle handle. Passenger indices run from zero through passenger capacity minus one. `GET_MAXIMUM_NUMBER_OF_PASSENGERS` (0x01EA) supplies capacity, and `IS_CAR_PASSENGER_SEAT_FREE` (0x0431) checks each index.

The passenger seat argument above is zero-based. Check capacity and availability before requesting one; PassengerRide demonstrates this with stock SCM commands. Issuing a task does not await its completion: observe game state on subsequent frames. GTA can reject, interrupt or time out a task.

Scm.Call accepts a named ScmOpcode or a stock numeric opcode, typed numeric/string arguments, entities, and output variables:

```csharp
var health = new ScmVariable();
Scm.Call(ScmOpcode.GetCharHealth, ped, health);
Log.Info($"Health: {health.Int32}");
```

SCM argument conversion follows this format:

| C# value | Sent to the interpreter |
| --- | --- |
| int | A 32-bit integer literal. |
| bool | Integer 1 or 0. |
| float | A single-precision floating-point literal; use an f suffix, e.g. 1.25f. |
| Entity wrapper | The entity's handle. |
| ScmVariable | A numeric local variable usable for input/output. |
| string | An ASCII variable-length string argument. |
| ScmArgument.Label("GXTKEY") | An ASCII fixed-width eight-character label; at most eight characters. |

Argument order and types must match the particular opcode. These conversions do not look up a command's parameter signature. An opcode getter may write output variables while leaving its condition flag false; for a condition opcode, the returned bool is the result you need. For example, `Scm.Call(0x0431, car, seat)` tests whether that passenger seat is free.

Use Single for float outputs and Int32 for integer outputs. Scm.Call returns the SCM condition flag; ordinary getters need not set it true. It is not a general success indicator. Interpreter commands that suspend or alter the temporary script's control flow are blocked. Use await Delay instead of SCM WAIT. This bridge executes stock commands, not arbitrary CLEO extension opcodes.

## Native and managed task classes

NativeTasks.StandStill/Wander create native PedTask objects. Assigning transfers ownership to GTA:

```csharp
using var task = NativeTasks.StandStill(1000);
ped.Tasks.Assign(task);
```

Dispose deletes an unassigned owned task; it does not delete a task already transferred to GTA. Clone before assigning the same task state again. Tasks cannot cross mod ownership boundaries.

Implement ManagedSimpleTask.ProcessPed and CloneState for a custom native-facing simple task. ManagedComplexTask provides CreateFirstSubTask, CreateNextSubTask and ControlSubTask for a task tree. AsyncPedTask provides an ExecuteAsync(Ped, CancellationToken) body; use Script.Delay/NextFrame there. Return/complete when the task is done and honor cancellation. Native callbacks are disabled before a mod unloads, and callback exceptions are reported to the owning mod.

## HUD drawing: direct game primitives and RenderWare textures

Override Draw for visible draw commands. Do not issue them from Tick, RunAsync or a background task. Draw is called from the render hook once per rendered frame; font/render states are restored after each mod even when its Draw fails.

### Direct game HUD API

```csharp
public override void Draw()
{
    if (Game.IsPaused) return;
    Hud.DrawRectangle(new HudRect(20, 20, 180, 30), new HudColor(0, 0, 0, 160));
    Hud.DrawText("Hello from SharpAndreas", new System.Numerics.Vector2(25, 24), HudColor.White);
}
```

HudRect contains screen-pixel X, Y, Width and Height; X/Y start at the upper-left. Hud.ScreenSize returns the current resolution. HudColor is R/G/B/A bytes from 0 through 255; alpha 0 is transparent, 255 opaque. Text uses the game's subtitle font and supported game character set, with its normal formatting codes. Scale defaults to 1 and is resolution-adjusted by the native font wrapper; it is not a point-size value.

Hud.TryProject(worldPosition, out screenPosition) projects a current 3D position. TryProjectHead(ped, out screenPosition) uses the current head bone. TryProjectAboveVehicle(vehicle, out screenPosition, offset) uses the vehicle position and model collision-box height, plus the nonnegative vertical offset. They return false for unavailable/out-of-view targets. Projection is a visibility/frustum test, not a wall-occlusion test.

### RenderWare texture path

```csharp
var canvas = new TextureCanvas(64, 8);
canvas.Clear(new HudColor(0, 0, 0, 180));
canvas.FillRectangle(1, 1, 46, 6, new HudColor(70, 220, 80));
var texture = new HudTexture(64, 8); // Allocate in Start/RunAsync on the game thread.
texture.Update(canvas);           // Upload after painting.
// In Draw: Hud.DrawTexture(texture, new HudRect(x, y, 64, 8));
// In Stop or a game-thread finally block: texture.Dispose();
```

TextureCanvas is a CPU canvas with reusable storage. Paint it using Clear/FillRectangle, or write Pixels directly. A pixel is a uint in straight-alpha **0xAARRGGBB** format; rows are top-to-bottom, indexed as y * Width + x. HudTexture.Update also accepts ReadOnlySpan<uint> containing exactly Width * Height pixels. The native upload handles raster stride and stores the image in a real RenderWare texture. This path uses CPU painting plus texture upload, not a separate GPU render-target camera.

Canvas painting can run on a worker if no other thread touches that canvas concurrently. Await painting before uploading. Creating, uploading, drawing and disposing HudTexture require the game thread and owning mod context. Dimensions must be 1 through 2048 and supported by the graphics device. Reuse textures and upload changed images; do not allocate a new texture every Draw. Text or complex shapes from another renderer can be uploaded in the same ARGB pixel format.

Textures belong to their mod and cannot cross ownership boundaries. Explicit Dispose releases them; the host also releases leftover textures after Stop, failures and reload. Project moving targets each Draw using the current camera/bones, while sampling health and repainting only as needed. This avoids coupling screen coordinates to a slower script tick. Rendering appearance, device-reset behavior and flicker still require validation in GTA.

### Two independent HUD examples

| Mod directory | Entry class | Rendering route | Behavior |
| --- | --- | --- | --- |
| Mods/NpcHealthBars | SharpAndreas.Examples.NpcHealthBars | Reusable RenderWare textures | Health bars above nearby NPC head bones; sample health every 250 ms, project and draw every rendered frame. |
| Mods/VehicleHealthText | SharpAndreas.Examples.VehicleHealthText | Game font API | Health percentage above the closest car within 50 world units; refresh selection/health every 200 ms and project every rendered frame. |

Both have their own mod.tml. NPC health is normalized against 100; vehicle health uses stock 1000 = 100%. Percentages are clamped to 0 through 100. The examples hide their drawing while paused and stop using targets that no longer exist. NPC textures are disposed when targets leave the sample and when the mod ends.

## Native profiler overlay

Enable the top-level option in SharpAndreas/SharpAndreas.toml and restart GTA:

```toml
enabled = true
profiler = true
```

Do not put profiler inside [scheduler] or [hot_reload]. The C++ ASI draws the profiler using Plugin-SDK's **drawHudEvent**. It refreshes text every 250 ms and lists loaded mod names (without versions) with:

| Display | Meaning |
| --- | --- |
| CLR heap MiB | Approximate shared managed heap from GC.GetTotalMemory(false); no forced collection. |
| U | Smoothed update/pump/Tick time in milliseconds. |
| D | Smoothed mod Draw time in milliseconds. |
| A | Main-thread bytes allocated during the latest update plus Draw, expressed in KiB. |
| Sum | Cumulative measured main-thread allocations for this loaded instance, in MiB. |

Allocations are not the amount of memory a mod currently retains. AssemblyLoadContexts share the CLR heap, so retained bytes cannot be attributed accurately per context. Background-thread allocations and native/GPU memory are not included in per-mod A/Sum. Timings include native API work performed by the measured managed callbacks and are CPU wall-clock measurements, not GPU timings. Values reset when that mod instance is reloaded. The profiler is disabled by default.

## Groups and gangs

Player.Local.Group exposes the recruitment group; Player.Local.Gang wraps it. Gang.Create(name, leader, faction) creates a custom group/faction association, and Add/Remove manage members. Dispose your owned Gang to restore tracked faction types and release its owned group. PedGroup supports a leader and up to seven followers.

GTA has ten native gang factions. Custom Gang instances reuse one of them; they do not add new engine faction slots. The player's inferred gang faction can be unknown, and assigning NPC members preserves the player's special ped type.

## Advanced SDK access

Typed Plugin-SDK wrappers live in SharpAndreas.Sdk. Entity Native getters use thread-safe Lazy caching, so repeated access on the same entity wrapper reuses its SDK wrapper:

```csharp
SharpAndreas.Sdk.CPed native = ped.Native;
float health = native.Health;
```

Native views borrow engine memory and require the game thread. Keep their lifetimes within the native entity's lifetime. Fields use C# names such as Position, Type and Health; NativeMember metadata records original SDK names. NativeSize remains publicly accessible and hidden from IntelliSense. Use SDK-COVERAGE.json to check unbound declarations and unsupported callback ABIs. Native ABI misuse can terminate GTA; AssemblyLoadContext does not isolate native memory faults.

## Dependencies, reload and troubleshooting

Each mod gets a collectible AssemblyLoadContext. Managed DLLs are loaded from memory so rebuilding/replacing the selected DLL or editing mod.tml can trigger a reload: cancel old work, call Stop, request unload, then load the replacement. Cleanup external references and subscriptions so the old context can be collected.

Place private dependency DLLs in MyExample/Libraries or alongside the selected assembly, and keep its dependency metadata when needed. Shared dependencies go in SharpAndreas/Libraries and remain in the default context until GTA exits. Private Libraries can override shared versions; SharpAndreas.Api always uses the host identity. Native dependencies must be x86 and load from disk.

If a mod does not load, read plugin.log. Check the required mod.tml, its quoted string fields, the selected assembly path and fully qualified main-class, net10.0/x86 targeting, dependency placement and TOML syntax. Managed failures usually disable only the owning mod and invoke cleanup; fatal native/process exceptions cannot be contained by an assembly load context. Pause-menu rendering and gameplay task behavior require testing in a supported GTA executable; the automated host uses a simulated game backend.

## Additional game systems and complete race example

[API-SYSTEMS.md](API-SYSTEMS.md) explains the high-level World/Zone/Pickup, Car/Boat/Player, Paths, Blips, Camera, Sound, Sphere, User3DMarker, Shopping, Skip, Streaming, StatType, Weather, Txd/Sprite and AudioStream3D APIs. It includes formats, ownership, example calls and the distinction between stock commands and optional BASS audio. [DECISION_MAKERS.md](DECISION_MAKERS.md) explains event policies, template/load differences and response weights.

The complete `examples/GroveStreetRace` project demonstrates an async mission with eight NPC drivers, twelve spectators, a countdown, checkpoints, ranking, timeout and cleanup, finishing at Grove Street. F9 starts and F10 aborts. Its mod.tml selects `SharpAndreas.Examples.GroveStreetRace`; its configurable settings are in race.toml. See the README race section for gameplay prerequisites. The sample sets Game.IsOnMission while owning the race, then clears it on every completion/failure/cancellation path. It declines to start if another mission is already active.

```toml
# Mods/GroveStreetRace/race.toml (created from defaults on first start)
npc_racers = 8
spectators = 12
countdown_milliseconds = 3000
time_limit_seconds = 180
update_milliseconds = 50
checkpoint_radius = 12.0
ai_speed = 26.0
start_key = 120 # F9, Windows virtual-key code
abort_key = 121 # F10
```

The API's TOML serializer writes these public settings using snake_case. Changing race.toml takes effect when the mod loads again; that settings file alone is not a hot-reload trigger. Rebuild/touch the mod DLL or restart GTA after editing settings. Simulated tests cover race pass/abort/unload, mission-flag clearing and owned entity cleanup. Actual race geometry and opponent-driving quality need in-game QA.
