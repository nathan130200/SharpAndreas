param([string]$PluginSdk='D:\plugin-sdk',[string]$Python='python')
$ErrorActionPreference='Stop'
Set-Location $PSScriptRoot
# Development-only dependency: python -m pip install libclang==18.1.1
& $Python tools/extract_sdk.py --sdk $PluginSdk --output build/sdk-ast.json
if($LASTEXITCODE) { throw 'SDK header extraction failed' }
& $Python tools/extract_sdk.py --sdk $PluginSdk --definitions --output build/sdk-definitions.json
if($LASTEXITCODE) { throw 'SDK implementation extraction failed' }
& $Python tools/generate_sdk.py
if($LASTEXITCODE) { throw 'SDK binding generation failed' }
& $Python tools/generate_task_opcodes.py
if($LASTEXITCODE) { throw 'Task opcode generation failed' }
Write-Host 'Generated typed SDK bindings. Run ./build.ps1 -Test to compile and validate.'
