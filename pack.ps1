param([string]$Feed, [string]$Version = '1.1.0')
$ErrorActionPreference='Stop'
Push-Location $PSScriptRoot
try {
    $packageOutput=Join-Path $PSScriptRoot 'artifacts/nuget'
    & dotnet pack 'managed/SharpAndreas.Api/SharpAndreas.Api.csproj' -c Release -o $packageOutput "-p:PackageVersion=$Version"
    if($LASTEXITCODE) {throw 'API package build failed'}
    if($Feed) {
        $destination=[System.IO.Path]::GetFullPath($Feed)
        New-Item -ItemType Directory -Force -Path $destination | Out-Null
        Copy-Item -LiteralPath (Join-Path $packageOutput "SharpAndreas.Api.$Version.nupkg") -Destination $destination -Force
        Write-Host "API package copied to $destination"
    }
    Write-Host "Package ready in $packageOutput"
} finally {Pop-Location}
