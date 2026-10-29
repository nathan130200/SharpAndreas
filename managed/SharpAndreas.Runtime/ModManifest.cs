using Tomlyn;
using Tomlyn.Model;

namespace SharpAndreas.Runtime;

internal sealed record ModManifest(string Name,string Version,string Assembly,string MainClass)
{
    internal static ModManifest Parse(string text)
    {
        var table=TomlSerializer.Deserialize<TomlTable>(text) ?? throw new FormatException("Empty mod.tml.");
        string Read(string key)=>table.TryGetValue(key,out var value) && value is string s?s:"";
        return new(Read("name"),Read("version"),Read("assembly"),Read("main-class"));
    }
    internal string ValidateAndResolve(string folder)
    {
        foreach(var (key,value) in new[]{("name",Name),("version",Version),("assembly",Assembly),("main-class",MainClass)})
            if(string.IsNullOrWhiteSpace(value) || value.Any(char.IsControl))
                throw new FormatException($"mod.tml: '{key}' must be a nonempty quoted string without control characters.");
        if(Name.Length>128 || Version.Length>64 || MainClass.Length>512 || MainClass.Contains(','))
            throw new FormatException("mod.tml: invalid name, version, or fully qualified main-class.");
        if(Version.Any(c=>!char.IsAsciiLetterOrDigit(c) && c is not '.' and not '-' and not '+' and not '_'))
            throw new FormatException("mod.tml: version may contain letters, digits, dots, '-', '+' and '_'.");
        if(Path.IsPathRooted(Assembly) || !Path.GetExtension(Assembly).Equals(".dll",StringComparison.OrdinalIgnoreCase))
            throw new FormatException("mod.tml: assembly must be a relative .dll path within this mod directory.");
        string root=Path.GetFullPath(folder)+Path.DirectorySeparatorChar;
        string path=Path.GetFullPath(Path.Combine(folder,Assembly));
        if(!path.StartsWith(root,StringComparison.OrdinalIgnoreCase))
            throw new FormatException("mod.tml: assembly path leaves the mod directory.");
        return path;
    }
}
