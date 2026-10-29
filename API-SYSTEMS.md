# Additional game systems

These high-level services cover common operations in the areas below. They are a curated API, not a promise to implement every method or extension opcode in CLEO Redux's `sa.d.ts`. More advanced declared SDK functionality is available under `SharpAndreas.Sdk`, subject to `SDK-COVERAGE.json` omissions. All game operations run on the game thread. An awaited API resumes on that thread when called from an ordinary mod callback; do not use ConfigureAwait(false) before accessing GTA.

## World, zones and pickups

`World` queries all, nearby or closest peds, vehicles, props and pickups. Query names follow `GetAllPickups()`, `GetNearbyPickups(center, radius)` and `GetClosestPickup(center, radius)`. Results are snapshots of currently instantiated game pools, not ownership claims. Pickups use their own handle table and are not Entity subclasses. `World.GetGroundHeight(position)` queries loaded ground collision; request collision before querying a distant area and allow the engine time to stream it.

```csharp
var player = Player.Local.Character;
if (player is not null)
{
    Zone? zone = World.GetZone(player.Position);
    Log.Info($"Zone: {zone?.Label}, level: {zone?.Level}");
    Pickup? closest = World.GetClosestPickup(player.Position, 30f);
}
```

`Zone.At(position)` reads the smallest applicable navigation zone. `Zone.Find("GANTON")` looks up an ASCII game zone label, at most eight characters. It is not a display-name search. A Zone snapshot has Label, TextKey (the GXT key), Minimum, Maximum, Type, Level and Contains(point). Native exposes a thread-safe lazily cached CZone wrapper. Zone.Type is the engine navigation/map-zone type, not CLEO's unrelated business/residential classification. This API does not invent new entries in GTA's fixed zone arrays or imply that changing a label creates gang territory.

```csharp
Pickup pickup = await Pickup.CreateAsync(
    model: 346, type: PickupType.Once,
    position: player!.Position + new Vector3(2, 0, 0),
    ammo: 50, cancellationToken: token);
```

Keep owned pickups in your mod fields and call Dispose/Delete in Stop when possible. A created pickup exposes Handle, Exists, Model, Type, Position, WasCollected and lazy Native (CPickup). WasCollected consumes GTA's collection notification; do not poll it in two places expecting the same result. A respawning street pickup may still exist while waiting for regeneration. FromHandle creates a borrowed wrapper: disposing that wrapper does not delete someone else's pickup; explicit Delete does. Query results are borrowed too. Pickup creation streams the model cooperatively, then relinquishes the model claim. Loader-owned resource cleanup removes created pickups after Stop on failure/unload.

## Player, cars and boats

Player adds Money, AddMoney, WantedLevel (0–6), ClearWantedLevel and IsControlEnabled. Existing Character, Group, Gang and SetControl remain available. Player slot indices are distinct from ped handles.

Vehicle adds Speed, Velocity, PassengerCount/PassengerCapacity, IsPassengerSeatFree, Repair, SetForwardSpeed, SetEngineRunning and SetColors. Values follow the game's native command units; do not assume Speed is km/h. Colors use game palette indices, not RGB. Passenger seat indices are zero-based and exclude the driver. Train keeps its train-specific writable Speed.

Car is the automobile subtype (CAutomobile); it does not pretend a bike, aircraft or boat has automobile memory layout. Boat is a Vehicle with CBoat Native, Anchor, GoTo, SetCruiseSpeed and Stop. Boat.CreateAsync validates the resulting vehicle subtype, as the other specialized vehicle factories do. Vehicle.FromHandle and world queries choose Car/Boat/Train/Trailer/Plane/Helicopter where applicable. Native getters use thread-safe Lazy caching; validate Exists before retaining a wrapper across frames or world changes.

## Paths, camera and sound

Existing closest/nth pedestrian and car path nodes include loaded-node snapshots and nullable headings derived from links. Paths additionally supports SetVehicleRoadsEnabled, SetPedRoadsEnabled, RestoreVehicleRoads and RestorePedRoads over an ordered Minimum/Maximum 3D box. These switches alter shared game state; restore your own changes when finished. They do not create paths or stream every node region automatically.

Camera has Position/Target, SetFixed(position, up), LookAt(target, transition), Restore, SetBehindPlayer, Shake, Fade and SetFadeColor. SetFixed's final vector is passed to the stock camera command as its up-offset parameters; it is not an Euler rotation. Camera changes are global, so a competing game script can overwrite them. Restore the normal camera in your cleanup if you took control of it.

Sound.PlayAt(soundId, position) plays a stock scripted game sound. For an arbitrary positional audio file, use AudioStream3D below. These are separate facilities with different IDs/resources.

## Radar blips, spheres and 3D markers

Blips.Create(position) creates a coordinate blip; Blips.Create(entity) supports peds, vehicles and props. The returned Blip has Exists and SetColor/SetScale/SetDisplay, and implements IDisposable. Color is the stock radar color value; display is the stock 0–3 display mode, not an ARGB pixel color.

Sphere.Create(position, radius) owns a persistent stock marker sphere. Dispose removes it. Sphere.Draw(position, diameter) issues the stock per-frame drawing command; note its **diameter** parameter. User3DMarker.Create(position, hudColorId) creates the yellow-entry-marker style native marker with a stock HUD color index, then Dispose removes it. These engine resources have small global capacities; do not allocate a new persistent marker every Tick. These wrappers do not expose CLEO-only sphere recoloring or opaque extension handles.

Blips, persistent spheres, user markers, created pickups, loaded TXDs, audio streams and decision makers are tracked by the current mod. The loader attempts disposal after Stop, including after a managed failure. You should still dispose resources early and clean up entities that refer to them. Handles cannot be transferred between mod ownership contexts. No finalizer calls into the game from a GC thread.

## Shopping, skip, weather and statistics

Shopping.Load(section) selects a stock shop section. ItemCount/GetItem(index)/GetPrice(item)/Buy(item)/HasBought(item)/Clear operate on that shared shop state. GetItem takes a zero-based index; the returned item identifier is then passed to the other methods. Buy uses the game's stock purchase behavior. These operations are not a transaction and should not be mixed with a concurrently active game shop interface.

Skip.SetDestination(position, heading, afterMission) configures the global trip-skip destination; Clear removes it. IsWaitingForScript reads the stock wait state. This minimal facade does not promise a complete cutscene/mission skip state machine or silently invoke CLEO extensions.

Weather.State is a snapshot of Current, Next, ForcedType (-1 means no forced type), Rain and Interpolation. Force(type, immediately) chooses a typed WeatherType, Release relinquishes the forced weather, SetHeatHaze changes heat haze and SetAppropriateNow chooses region-appropriate weather. GTA/weather scripts share this global state. Rain is the engine intensity, not a percentage string.

StatType contains all **305 explicit identifiers** in the installed SDK's eStats enum, retaining gaps and numeric values. Stat.GetInt/GetFloat, SetInt/SetFloat and IncrementInt/IncrementFloat use the stock stat commands. Select the matching integer or floating storage type for that particular statistic; an enum value alone is not storage-type metadata. Increment methods accept showMessage=false. Statistics affect game progress/save state and are not automatically rolled back by mod cleanup. Regenerate identifiers with `python tools/generate_stats.py --sdk D:/plugin-sdk`.

## Streaming

Streaming.RequestModelAsync and RequestAnimationAsync wait cooperatively using NextFrame. RequestCarRecordingAsync does the same for a stock car recording ID. Pass your mod cancellation token. RemoveAnimation and RemoveCarRecording relinquish requests when finished; MarkModelAsNoLongerNeeded relinquishes a model. Cancellation while waiting removes the animation/recording request made by that operation. Engine streaming state is global, so coordinate resource ownership when several scripts share a resource.

RequestIpl(name), RemoveIpl(name, discreetly) and RequestCollision(positionXY) issue stock requests; they do not synchronously load all game data or return a promise that distant collision is already ready. IPL names are ASCII resource names rather than filesystem paths. No helper calls the blocking LoadAllModelsNow command to implement its async wait.

## TXD textures and sprites

```csharp
dictionary = await Txd.LoadAsync(Path.Combine(context.Directory, "hud.txd"), token);
texture = dictionary.GetTexture("my_bar");
sprite = new Sprite(texture);
// In Mod.Draw:
sprite.Draw(new HudRect(20, 20, 128, 32), HudColor.White);
// In Stop, dispose texture and dictionary.
```

Txd.LoadAsync reads the file asynchronously into memory, then creates a private engine texture-dictionary slot on the game thread. Native parsing and GPU/resource creation are synchronous game-thread work; prepare small assets outside your frame loop. GetTexture requires an existing ASCII RenderWare texture name of at most 32 characters. It returns a normal HudTexture with its own native reference. It remains valid after the dictionary is disposed, until that texture is disposed or the mod is unloaded. Sprite borrows its HudTexture and does not own/dispose it.

Draw sprites only inside Mod.Draw, in screen pixels. This uses RenderWare directly rather than the game's shared SCM sprite-number slots or CLEO extension opcodes. It is separate from TextureCanvas, which uploads pixels you generate yourself. After Stop, the loader releases remaining HUD texture references and texture dictionaries; do not retain them in external/shared static objects.

## AudioStream3D

This optional facility uses **x86 BASS 2.4** for local positional audio. Put a compatible `bass.dll` in `SharpAndreas/Libraries`. The package does not bundle that third-party binary; obtain it from [Un4seen](https://www.un4seen.com/) and follow its licensing terms. An absent DLL, wrong architecture, unavailable audio device, unsupported codec or failed native stream allocation produces a managed exception. The normal mod fault boundary logs it and runs Stop if you do not handle it.

```csharp
audio = await AudioStream3D.LoadAsync(
    Path.Combine(context.Directory, "engine-mono.wav"), token);
audio.AttachTo(vehicle, new Vector3(0, 0, 1));
audio.SetDistance(minimum: 3f, maximum: 80f);
audio.Volume = 0.6f;
audio.Play();
// Stop: audio?.Dispose();
```

LoadAsync reads local file bytes asynchronously and retains its unmanaged memory buffer until the native stream is freed. Prefer mono WAV/OGG/MP3; 3D playback requires mono, and the BASS mono flag downmixes supported compressed formats but does not make every stereo format compatible. Stream header/decoder creation still occurs synchronously on the game thread; there is no forced full-file pre-scan. Large assets require proportionally large buffers.

Position sets a fixed world-space source and detaches any entity. AttachTo follows a ped, vehicle or prop, using a world-axis offset; it is not rotated as a bone/local-space offset. Detach keeps the last position. If the attached entity disappears, the stream stops and detaches. Play(restart), Pause, Stop, Volume (0–1) and SetDistance control the stream. Stop stops playback while retaining the stream; Dispose frees it and its memory. The loader also disposes owned streams after Stop.

The listener follows Camera.Position/Target. GTA (X,Y,Z) is converted to BASS (X,Z,Y). Maximum distance is the point where attenuation stops decreasing, not a guaranteed hard mute boundary. The BASS device/listener is shared with any other plugin using that same DLL/device. SharpAndreas does not globally free or reset another plugin's device. Audio playback is independent of the mod Tick pause rule; explicitly Pause/Play if that is your intended pause behavior.

See the official [stream memory/mono documentation](https://www.un4seen.com/doc/bass/BASS_StreamCreateFile.html) and [3D distance documentation](https://www.un4seen.com/doc/bass/BASS_ChannelSet3DAttributes.html). Integration tests check missing-dependency handling and wrapper ownership. Actual sound output, spatialization and coexistence with other audio plugins require in-game/device QA.

## Decision makers

Read [DECISION_MAKERS.md](DECISION_MAKERS.md) before using DecisionMakerChar or DecisionMakerGroup. It explains event-response selection, source-relationship weights, mission-slot limits, template versus file-load types, cleanup and why scripted tasks may override apparent decision-maker behavior.
