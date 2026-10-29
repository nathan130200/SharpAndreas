$ErrorActionPreference='Stop'
Set-Location (Split-Path $PSScriptRoot)
$projectRoot=(Get-Location).Path
$testBase=Join-Path $projectRoot 'build/integration'
if(Test-Path $testBase) {
    $resolved=(Resolve-Path $testBase).Path
    if(!$resolved.StartsWith($projectRoot+'\build\',[StringComparison]::OrdinalIgnoreCase)) {throw 'Unexpected test output path'}
    Remove-Item -LiteralPath $resolved -Recurse -Force
}
New-Item -ItemType Directory -Force $testBase | Out-Null
Copy-Item 'dist/SharpAndreas' $testBase -Recurse
$testRoot=Join-Path $testBase 'SharpAndreas'
function WriteManifest([string]$folder,[string]$name,[string]$version,[string]$assembly,[string]$mainClass) {
    # Inputs below are fixture-owned identifiers with no TOML escape characters.
    @"
name = "$name"
version = "$version"
assembly = "$assembly"
main-class = "$mainClass"
"@ | Set-Content (Join-Path $folder 'mod.tml')
}
function BuildFixture([string]$project,[string]$name,[string[]]$extra=@()) {
    & dotnet build $project -c Release -o "$testRoot/Mods/$name" "-p:ModName=$name" @extra
    if($LASTEXITCODE) {throw "Fixture build failed: $name"}
    $displayName=$name
    $version='1.0.0'
    if($name -eq 'PausedOptIn') {$displayName='Pause opt-in';$version='1.2.3'}
    WriteManifest "$testRoot/Mods/$name" $displayName $version "$name.dll" $name
}
foreach($name in @('FaultMod','StartFault')) {BuildFixture 'tests/FaultMod' $name}
Set-Content "$testRoot/Mods/StartFault/start.fail" 'fail'
foreach($marker in @('A','B')) {BuildFixture 'tests/IsolationMod' "Isolation$marker" @("-p:Marker=$marker")}
New-Item -ItemType Directory -Force "$testRoot/Mods/IsolationA/Libraries" | Out-Null
Move-Item -LiteralPath "$testRoot/Mods/IsolationA/PrivateDependency.dll" -Destination "$testRoot/Mods/IsolationA/Libraries/PrivateDependency.dll"
Move-Item -LiteralPath "$testRoot/Mods/IsolationB/PrivateDependency.dll" -Destination "$testRoot/Libraries/PrivateDependency.dll"
foreach($name in @('AsyncHealthy','AsyncFault','AsyncPending','AsyncZero','AsyncVoidFault')) {BuildFixture 'tests/AsyncMod' $name}
foreach($name in @('TaskHealthy','TaskFault','MalformedConfig')) {BuildFixture 'tests/TaskMod' $name}
foreach($name in @('ServicesHealthy','ServicesFault')) {BuildFixture 'tests/ServicesMod' $name}
foreach($name in @('HudHealthy','HudFault','HudStartFault','HudLeak')) {BuildFixture 'tests/HudMod' $name}
foreach($name in @('PausedDefault','PausedOptIn')) {BuildFixture 'tests/PauseMod' $name}
BuildFixture 'tests/HotReload' 'HotReload' @('-p:Revision=1')
& dotnet build 'tests/HotReload' -c Release -o 'build/hot-replacement' '-p:Revision=2'
if($LASTEXITCODE) {throw 'Hot-reload replacement build failed'}
New-Item -ItemType Directory -Force "$testRoot/snapshots" | Out-Null
Copy-Item 'build/hot-replacement/HotReload.dll' "$testRoot/snapshots/replacement.dll"
WriteManifest "$testRoot/snapshots" 'HotReload' '2.0.0' 'HotReload.dll' 'HotReload'
Move-Item -LiteralPath "$testRoot/snapshots/mod.tml" -Destination "$testRoot/snapshots/replacement.mod.tml"
& dotnet build 'tests/ManifestMod' -c Release -o "$testRoot/Mods/ManifestFolder/bin" '-p:Marker=N'
if($LASTEXITCODE) {throw 'Manifest fixture build failed'}
New-Item -ItemType Directory -Force "$testRoot/Mods/ManifestFolder/Libraries" | Out-Null
Move-Item -LiteralPath "$testRoot/Mods/ManifestFolder/bin/PrivateDependency.dll" -Destination "$testRoot/Mods/ManifestFolder/Libraries/PrivateDependency.dll"
WriteManifest "$testRoot/Mods/ManifestFolder" 'Friendly Name' '4.3.2.1' 'bin/Entry.dll' 'ManifestSample.ActualMod'
WriteManifest "$testRoot/snapshots" 'Friendly Name' '4.3.2.2' 'bin/Entry.dll' 'ManifestSample.ActualMod'
Move-Item -LiteralPath "$testRoot/snapshots/mod.tml" -Destination "$testRoot/snapshots/manifest-only.mod.tml"
New-Item -ItemType Directory -Force "$testRoot/Mods/BadImage","$testRoot/Mods/WrongClass" | Out-Null
Set-Content "$testRoot/Mods/BadImage/BadImage.dll" 'invalid assembly'
Copy-Item "$testRoot/Mods/HelloCS/HelloCS.dll" "$testRoot/Mods/WrongClass/WrongClass.dll"
WriteManifest "$testRoot/Mods/BadImage" 'BadImage' '1.0.0.0' 'BadImage.dll' 'BadImage'
WriteManifest "$testRoot/Mods/WrongClass" 'WrongClass' '1.0.0.0' 'WrongClass.dll' 'Missing.Namespace.Entry'
foreach($name in @('MissingFields','UnsafeAssembly','NoManifest','InvalidManifest')) {New-Item -ItemType Directory -Force "$testRoot/Mods/$name" | Out-Null}
Set-Content "$testRoot/Mods/MissingFields/mod.tml" 'name = "Missing Fields"','version = "1.0.0.0"'
WriteManifest "$testRoot/Mods/UnsafeAssembly" 'Unsafe Path' '1.0.0.0' '../../outside.dll' 'HelloCS'
Set-Content "$testRoot/Mods/InvalidManifest/mod.tml" 'name = ['
Copy-Item "$testRoot/Mods/HelloCS/HelloCS.dll" "$testRoot/Mods/NoManifest/HelloCS.dll"
@'
npc_racers = 8
spectators = 12
countdown_milliseconds = 0
time_limit_seconds = 180
update_milliseconds = 0
checkpoint_radius = 12.0
ai_speed = 26.0
start_key = 120
abort_key = 121
'@ | Set-Content "$testRoot/Mods/GroveStreetRace/race.toml"
@'
enabled = true
profiler = true
[scheduler]
max_callbacks_per_frame = 64
budget_milliseconds = 2.0
[hot_reload]
enabled = true
poll_milliseconds = 50
stabilize_milliseconds = 50
'@ | Set-Content "$testRoot/SharpAndreas.toml"
& 'build/vs2022/Release/HostCheck.exe' $testRoot
if($LASTEXITCODE) {throw "Native hosting check failed: $LASTEXITCODE"}
$log=Get-Content "$testRoot/plugin.log" -Raw
$expected=@('WORLD ZONE BOAT DECISIONS SERVICES PASS','SERVICE HANDLES RELEASED','DISABLED ServicesFault','CoreCLR initialized (x86).','LOADED HelloCS','LOADED HelloVB','PrivateDependency=A','PrivateDependency=B','LOADED IsolationA','LOADED IsolationB','DISABLED BadImage','DISABLED WrongClass','DISABLED StartFault','DISABLED FaultMod','[FaultMod] [Stop failed:','C# stopped','VB stopped','Loader stopped.','ASYNC AND SCM PASS','CANCELLED ON GAME THREAD','ZERO DELAY YIELDED FRAMES','DISABLED AsyncFault','DISABLED AsyncVoidFault','Async C#:','Async VB:','SIMPLE CLONED','SIMPLE PROCESS','COMPLEX FIRST PROCESS','COMPLEX NEXT PROCESS','COMPLEX DELETED','TASKS CONFIG SDK PASS','VEHICLES AND GANGS PASS','NATIVE WRAPPER CACHE PASS','WEAPON INFO PASS','PED INFO PASS','VEHICLE INFO PASS','WORLD QUERY PASS','PATH QUERY PASS','HUD BOTH PATHS PASS','DISABLED HudFault','DISABLED HudStartFault','HUD TEXTURES RELEASED; BOTH DRAW PATHS EXECUTED','PROFILER OVERLAY ACTIVE','RACE GRID: 8 opponents, 12 spectators','RACE PASSED - Finished first at Grove Street.','RACE FAILED - Aborted with F10.','RACE CANCELLED','RACE RESOURCES AND SCM ONMISSION CLEARED','LOADED PassengerRide','Entering vehicle 42 as passenger (seat 1).','Leaving vehicle 42.','PassengerRide stopped.','NATIVE FAILURE FINALLY','DISABLED TaskFault','STOP CLEANUP TaskFault','STOP CLEANUP MalformedConfig','[TaskHealthy] [WORKER LOG]','[TaskHealthy] [System.InvalidOperationException: LOG EXCEPTION]','[HotReload] [TRACE UNIFIED 1.0.0]','[HotReload] [TRACE UNIFIED 2.0.0]','HOT RELOAD FINALLY 1.0.0','HOT RELOAD FINALLY 2.0.0','PAUSE POLICY PASS PausedDefault','PAUSE POLICY PASS Pause opt-in','MANIFEST SELECTION PASS 4.3.2.1','MANIFEST SELECTION PASS 4.3.2.2','[Friendly Name] [TRACE WRITE WITHOUT NEWLINE]','[Friendly Name] [EXPLICIT TRACE ERROR]','[Friendly Name] [TYPED LOGGER MANIFEST NAME]','DISABLED MissingFields (Missing Fields v1.0.0.0)','DISABLED UnsafeAssembly (Unsafe Path v1.0.0.0)','DISABLED NoManifest','DISABLED InvalidManifest')
foreach($text in $expected) {if(!$log.Contains($text)) {throw "Missing integration evidence: $text"}}
foreach($name in @('HudHealthy','HudFault','HudStartFault','HudLeak')) {if(!(Test-Path "$testRoot/Mods/$name/hud-stopped.txt")) {throw "HUD Stop was not called: $name"}}
foreach($name in @('TaskHealthy','TaskFault','MalformedConfig')) {
    if((Get-Content "$testRoot/Mods/$name/stop.count" -Raw).Trim() -ne '1') {throw "Stop did not run exactly once: $name"}
}
foreach($file in @('started.txt','stopped.txt')) {
    if((Get-Content "$testRoot/Mods/HotReload/$file" -Raw).Replace("`r",'') -ne "1.0.0`n2.0.0`n") {throw "Hot-reload lifecycle mismatch: $file"}
}
foreach($name in @('AsyncHealthy','AsyncZero','AsyncPending','TaskHealthy','PausedDefault','PausedOptIn','HotReload','HelloCS','HelloVB','PassengerRide','ManifestFolder','HudHealthy','HudLeak','NpcHealthBars','VehicleHealthText','GroveStreetRace','ServicesHealthy')) {
    if($log.Contains("DISABLED $name")) {throw "Healthy fixture was disabled: $name"}
}
foreach($file in @('manifest-started.txt','manifest-stopped.txt')) {
    if((Get-Content "$testRoot/Mods/ManifestFolder/$file" -Raw).Replace("`r",'') -ne "4.3.2.1`n4.3.2.2`n") {throw "Manifest-only reload lifecycle mismatch: $file"}
}
if((Get-Content "$testRoot/Mods/ManifestFolder/trace-errors.txt" | Measure-Object -Sum).Sum -lt 2) {throw 'Uncaught failures did not pass through Trace.TraceError'}
if($log.Contains('Cancellation failed') -or $log.Contains('Unfinished external work')) {throw 'Async cleanup failed'}
foreach($line in ($log -split '\r?\n' | Where-Object {$_})) {if($line -notmatch '^\[[^\]]+\] \[[^\]]+\] \[.*\]$') {throw "Invalid unified log format: $line"}}
if(($log.Split('Entering vehicle 42 as passenger (seat 1).').Length-1) -ne 1 -or ($log.Split('Leaving vehicle 42.').Length-1) -ne 1) {throw 'PassengerRide repeated entry/exit while a key was held'}
if(($log.Split('C# tick').Length-1) -ne 3 -or ($log.Split('VB tick').Length-1) -ne 3) {throw 'C#/VB game callbacks failed'}
Write-Host 'PASS: x86 hosting; memory load and hot reload; manifest-selected assemblies/classes; manifest-only hot reload; private/shared libraries; pause policy/metadata; async cancellation; exactly-once Stop; C++ task callbacks/sequences; vehicles/gangs; weapon/ped/vehicle metadata; world/path/pickup queries; zones/boats/decision makers and service resource cleanup; race pass/abort/cancellation and SCM mission flag; direct HUD/RenderWare textures; profiler; callback exception containment; PassengerRide G/F input; TOML/unified Trace logs; SDK ABI/property names/IntelliSense metadata. Engine/render backend is simulated.'
