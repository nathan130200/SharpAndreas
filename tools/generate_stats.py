"""Generate StatType from the locally installed Plugin-SDK enum; no game files are modified."""
import argparse
import re
from pathlib import Path
parser = argparse.ArgumentParser()
parser.add_argument("--sdk", type=Path, default=Path("D:/plugin-sdk"))
args = parser.parse_args()
source = args.sdk / "plugin_sa/game_sa/enums/eStats.h"
values = re.findall(r"STAT_([A-Z0-9_]+)\s*=\s*(\d+)", source.read_text())
lines = []
for name, value in values:
    name = "".join(word.title() for word in name.split("_"))
    if name[0].isdigit():
        name = "Stat" + name
    lines.append(f"    {name}={value},")
output = Path(__file__).resolve().parents[1] / "managed/SharpAndreas.Api/StatType.g.cs"
output.write_text("// Generated from plugin-sdk eStats.h numeric identifiers. Regenerate with tools/generate_stats.py.\nnamespace SharpAndreas;\npublic enum StatType\n{\n" + "\n".join(lines) + "\n}\n")
print(f"Generated {len(values)} stat IDs")
