param([string]$PluginSdk = 'D:\plugin-sdk', [switch]$Test)
$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot
function Run([string]$Program, [string[]]$Arguments) {
    & $Program @Arguments
    if ($LASTEXITCODE -ne 0) { throw "$Program failed with exit code $LASTEXITCODE" }
}
$dotnet = (Get-Command dotnet.exe).Source
$dotnetRoot = Split-Path $dotnet
$pack = Get-ChildItem "$dotnetRoot\packs\Microsoft.NETCore.App.Host.win-x86" -Directory |
    Where-Object { $_.Name -match '^10\.\d+\.\d+$' } |
    Sort-Object { [version]$_.Name } -Descending | Select-Object -First 1
if (!$pack) { throw 'Install the .NET 10 SDK with the win-x86 hosting pack.' }
$nativePack = Join-Path $pack.FullName 'runtimes\win-x86\native'
Run cmake @('-S', '.', '-B', 'build/vs2022', '-G', 'Visual Studio 17 2022', '-A', 'Win32', "-DPLUGIN_SDK=$PluginSdk", "-DDOTNET_HOST_PACK=$nativePack")
Run cmake @('--build', 'build/vs2022', '--config', 'Release')
New-Item -ItemType Directory -Force 'dist/SharpAndreas/Runtime','dist/SharpAndreas/Mods','dist/SharpAndreas/Libraries' | Out-Null
Run $dotnet @('build', 'managed/SharpAndreas.Runtime', '-c', 'Release', '-o', 'dist/SharpAndreas/Runtime')
foreach ($sample in @('HelloCS', 'HelloVB', 'PassengerRide', 'NpcHealthBars', 'VehicleHealthText', 'GroveStreetRace')) {
    Run $dotnet @('build', "examples/$sample", '-c', 'Release', '-o', "dist/SharpAndreas/Mods/$sample")
    Copy-Item "examples/$sample/mod.tml" "dist/SharpAndreas/Mods/$sample/mod.tml" -Force
    # Every mod shares the host's API assembly identity.
    Remove-Item "dist/SharpAndreas/Mods/$sample/SharpAndreas.Api.*" -ErrorAction SilentlyContinue
}
Copy-Item 'build/vs2022/Release/SharpAndreas.asi' 'dist/SharpAndreas.asi' -Force
if (!(Test-Path 'dist/SharpAndreas/SharpAndreas.toml')) { Copy-Item 'defaults/SharpAndreas.toml' 'dist/SharpAndreas/SharpAndreas.toml' }
Copy-Item 'SDK-COVERAGE.json' 'dist/SharpAndreas/Runtime/SDK-COVERAGE.json' -Force
Copy-Item 'defaults/Libraries.README.md' 'dist/SharpAndreas/Libraries/README.md' -Force
& "$PSScriptRoot/pack.ps1"
if ($Test) { & "$PSScriptRoot/tests/check.ps1" }
Write-Host "Built $PSScriptRoot\dist"

