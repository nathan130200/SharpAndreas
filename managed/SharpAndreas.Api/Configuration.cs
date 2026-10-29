using System.Text.Json;
using Tomlyn;

namespace SharpAndreas;

/// <summary>Typed TOML configuration files scoped to the mod directory.</summary>
public sealed class ModConfiguration
{
    private readonly string directory;
    internal ModConfiguration(string directory) => this.directory = Path.GetFullPath(directory);
    private string Resolve(string filename)
    {
        if (string.IsNullOrWhiteSpace(filename) || Path.GetFileName(filename) != filename || !filename.EndsWith(".toml", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentException("Use a simple .toml filename within the script directory.", nameof(filename));
        return Path.Combine(directory, filename);
    }
    public T Load<T>(string filename = "settings.toml") where T : notnull, new() => TomlConfig.LoadOrCreate(Resolve(filename), new T());
    public void Save<T>(T settings, string filename = "settings.toml") where T : notnull => TomlConfig.Save(Resolve(filename), settings);
}

public static class TomlConfig
{
    // Per-operation serializer options keep collectible script types out of a global metadata cache.
    private static TomlSerializerOptions Options() => new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
    public static T LoadOrCreate<T>(string filename, T defaults) where T : notnull
    {
        ArgumentNullException.ThrowIfNull(defaults);
        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(filename))!);
        if (!File.Exists(filename))
        {
            try
            {
                using var stream = new FileStream(filename, FileMode.CreateNew, FileAccess.Write, FileShare.Read);
                TomlSerializer.Serialize(stream, defaults, Options());
                return defaults;
            }
            catch (IOException) when (File.Exists(filename)) { }
        }
        try
        {
            using var stream = File.OpenRead(filename);
            return TomlSerializer.Deserialize<T>(stream, Options()) ?? throw new FormatException($"Empty TOML configuration: {filename}");
        }
        catch (TomlException ex) { throw new FormatException($"Invalid TOML configuration '{filename}': {ex.Message}", ex); }
    }
    public static void Save<T>(string filename, T settings) where T : notnull
    {
        string target = Path.GetFullPath(filename);
        Directory.CreateDirectory(Path.GetDirectoryName(target)!);
        string temporary = target + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try
        {
            using (var stream = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None))
                TomlSerializer.Serialize(stream, settings, Options());
            File.Move(temporary, target, overwrite: true);
        }
        finally { if (File.Exists(temporary)) File.Delete(temporary); }
    }
}
