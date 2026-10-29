using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;

namespace SharpAndreas;

public enum WeaponFireType { Melee, InstantHit, Projectile, AreaEffect, Camera, Use }

/// <summary>Immutable weapon/model mappings generated from the installed game's data files.</summary>
public sealed partial class WeaponInfo
{
    // Lazy initialization also keeps the generated partial's field initialization order irrelevant.
    private static readonly Lazy<FrozenDictionary<int, WeaponInfo>> byId = new(
        () => entries.ToFrozenDictionary(info => info.Id), LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<FrozenDictionary<int, IReadOnlyList<WeaponInfo>>> byModel = new(
        () => entries.SelectMany(info => new[] { info.ModelId, info.SecondaryModelId }
                .Where(model => model >= 0).Distinct().Select(model => (Model: model, Info: info)))
            .GroupBy(item => item.Model)
            .ToFrozenDictionary(group => group.Key,
                group => (IReadOnlyList<WeaponInfo>)Array.AsReadOnly(group.Select(item => item.Info).ToArray())),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<IReadOnlyList<WeaponInfo>> all = new(
        () => Array.AsReadOnly(entries), LazyThreadSafetyMode.ExecutionAndPublication);

    private WeaponInfo(WeaponType type, string dataName, WeaponFireType fireType,
        int modelId, int secondaryModelId, int slot, string? modelName, string? secondaryModelName)
    {
        Type = type;
        DataName = dataName;
        FireType = fireType;
        ModelId = modelId;
        SecondaryModelId = secondaryModelId;
        Slot = slot;
        ModelName = modelName;
        SecondaryModelName = secondaryModelName;
    }

    public WeaponType Type { get; }
    public int Id => (int)Type;
    public string DataName { get; }
    public WeaponFireType FireType { get; }
    /// <summary>Primary model ID, or -1 when this weapon has no model (unarmed).</summary>
    public int ModelId { get; }
    /// <summary>Additional model ID, or -1 when absent. A satchel also uses the detonator model.</summary>
    public int SecondaryModelId { get; }
    public string? ModelName { get; }
    public string? SecondaryModelName { get; }
    public int Slot { get; }
    public static IReadOnlyList<WeaponInfo> All => all.Value;
    public static WeaponInfo Get(WeaponType type) => Get((int)type);
    public static WeaponInfo Get(int weaponId) => TryGet(weaponId, out var info)
        ? info : throw new ArgumentOutOfRangeException(nameof(weaponId), weaponId, "Unknown weapon ID.");
    public static bool TryGet(int weaponId, [NotNullWhen(true)] out WeaponInfo? info)
        => byId.Value.TryGetValue(weaponId, out info);
    /// <summary>All weapons using this primary or secondary model; empty for unknown model IDs.</summary>
    public static IReadOnlyList<WeaponInfo> GetByModelId(int modelId)
        => byModel.Value.TryGetValue(modelId, out var matches) ? matches : Array.Empty<WeaponInfo>();
}
