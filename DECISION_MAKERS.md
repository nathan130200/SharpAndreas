# Ped and group decision makers

Decision makers are GTA's event-response policies. A ped receives an event (for example a threat, damage or a nearby disturbance), and the engine consults a decision table to choose an eligible task. Assigning a decision maker does not immediately order the ped to perform that task. Use `ped.Tasks` for an explicit instruction such as walking, driving or attacking.

`DecisionMakerChar` controls an individual ped's event responses. `DecisionMakerGroup` controls decisions made for a native `PedGroup`. A group policy is not a substitute for assigning suitable policies to its individual members, and creating a group decision maker does not create a ped group.

## Copy versus load

```csharp
using var policy = DecisionMakerChar.Copy(DecisionMakerCharTemplate.RandomNormal);
policy.AssignTo(ped);
// Keep policy alive while the ped uses it.
// Before disposing policy, delete your ped or assign a built-in policy:
DecisionMakerChar.AssignTemplate(ped, DecisionMakerCharTemplate.RandomNormal);
```

`Copy(template)` allocates an editable policy based on a built-in table. Instance `Copy()` duplicates an existing owned policy. `Load(type)` asks the stock script command to load one of GTA's predefined mission decision files. Neither method accepts an arbitrary filename. Character load types are Empty, Normal, Tough, Weak, Steal and Mission; the group load type is MissionNormal. The installed game's `data/Decision` directory contains the underlying `.ped` and `.grp` files. Editing those files affects global game behavior and is not necessary to use this API.

Template values, load-file types and returned script handles are three distinct concepts. Separate enums prevent passing a file type where a template is expected. Character templates occupy the stock encoded range 65536–65543; group templates use 65544–65545. These encoded script values are not the native manager's table indices. The wrapper resolves owned handles before editing responses.

For a policy you do not intend to edit, `AssignTemplate` uses the built-in table without allocating a mission slot:

```csharp
DecisionMakerGroup.AssignTemplate(group, DecisionMakerGroupTemplate.RandomPassive);
using var customGroup = DecisionMakerGroup.Copy(DecisionMakerGroupTemplate.RandomPassive);
customGroup.AssignTo(group);
// Reassign to a built-in template before customGroup is disposed.
```

GTA has 20 decision-maker slots: ten built-in entries and ten mission entries. Other game scripts and mods compete for these mission entries. Allocation can fail; creating one policy per ped will exhaust this small pool quickly. Share a policy among your own compatible peds when appropriate, and dispose it after its final user is removed or reassigned. The loader tracks owned policies and attempts disposal after Stop on failure, unload or hot reload. Explicitly clean up assigned entities in Stop before that automatic resource pass.

## Editing event responses

`ClearEventResponses(eventType)` clears a copied policy's responses for that event. `AddEventResponse(eventType, taskType, weights, onFoot, inVehicle)` adds a candidate response. Event and task IDs use the SDK enums `SharpAndreas.Sdk.eEventType` and `eTaskType`; they are **native event/task IDs**, not SCM opcode numbers. Valid enum membership does not establish that a task is meaningful as a response to every event.

```csharp
var weights = new DecisionResponseWeights(
    Neutral: 0, Player: 100, Friend: 0, Enemy: 100);
// Choose event/task values supported by the particular behavior you are testing:
policy.ClearEventResponses(eventType);
policy.AddEventResponse(eventType, taskType, weights,
    onFoot: true, inVehicle: false);
```

The installed Plugin-SDK describes four source relationships: neutral, player, friend and enemy. SharpAndreas calls the native `CDecisionMakerTypes.AddEventResponse` with these named fields directly. It does not inherit CLEO's ambiguous respect/hate/like/dislike parameter names or assume their ordering. Weights are bytes (0–255), and are relative selection weights rather than fixed percentages. If eligible responses have weights 20 and 80 for the same relationship, the conceptual selection proportions are 20/100 and 80/100. A zero weight excludes that candidate for that relationship. `onFoot` and `inVehicle` select eligible contexts; enable at least one.

Each event table holds at most six unique response tasks. The wrapper leaves duplicate replacement and capacity behavior to GTA's native implementation; clear the event and add your intended small response set rather than accumulating changes every frame. It does not edit built-in tables through this API.

## Why a ped may appear to ignore a policy

- No matching event reached the ped, or the event source had a different relationship than expected.
- The response is disabled for its current vehicle/on-foot context or has zero weight.
- The selected task is inappropriate for that event, lacks a valid target, or cannot start in the current situation.
- Another event has higher priority, an existing task cannot be interrupted, or a scripted/mission task is controlling the ped.
- Group coordination and individual policies produce different choices.

The API does not promise that setting a policy overrides mission scripts or forces an immediate reaction. Test one event and one response at a time using a disposable mission ped. First verify that the same action works as an explicit ped task, then verify that the event actually occurs. Built-in template names describe their intended role; they do not constitute a complete behavioral specification.

The handle transport, ownership and native bindings are checked by the build and simulated host. Actual event priorities, candidate-task suitability, probability outcomes, duplicate handling and interactions with game scripts still require in-game QA. Unknown behavior is left explicit rather than replaced with invented guarantees.

## Sources

Implementation follows the installed Plugin-SDK `CDecision.h`, `CDecisionMakerTypes.h` and the stock script command identifiers. Public source references: [Plugin-SDK](https://github.com/DK22Pac/plugin-sdk), [gta-reversed script handle types](https://github.com/gta-reversed/gta-reversed/blob/master/source/game_sa/Scripts/TheScripts.h), and [character decision-maker load/assignment handlers](https://github.com/gta-reversed/gta-reversed/blob/master/source/game_sa/Scripts/Commands/CharacterCommands.cpp). CLEO Redux's local `sa.d.ts` was used to identify useful API areas; its API design and undocumented extension behavior are not treated as specifications.
