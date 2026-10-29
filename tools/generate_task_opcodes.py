from pathlib import Path
import re
root=Path(__file__).resolve().parents[1]
source=Path('D:/plugin-sdk/plugin_sa/game_sa/enums/eScriptCommands.h').read_text()
commands=re.findall(r'COMMAND_(TASK_\w+)\s*=\s*(0x[0-9A-Fa-f]+)',source)
text='// Generated from installed Plugin-SDK eScriptCommands.h.\nnamespace SharpAndreas;\npublic enum TaskOpcode : ushort\n{\n'
text+=''.join(f'    {name} = {value},\n' for name,value in commands)+'}\n'
text+='internal static class SdkTaskOpcodes\n{\n    private static readonly System.Collections.Generic.HashSet<ushort> values = System.Enum.GetValues<TaskOpcode>().Select(x => (ushort)x).ToHashSet();\n    internal static bool IsTask(ushort opcode) => values.Contains(opcode);\n}\n'
(root/'managed/SharpAndreas.Api/TaskOpcodes.g.cs').write_text(text)
print(f'{len(commands)} typed task opcodes')
