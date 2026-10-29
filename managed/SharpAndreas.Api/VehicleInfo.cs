using System.Collections.Frozen;

namespace SharpAndreas;

public enum VehicleClass
{
    Ignore = -1, Normal = 0, PoorFamily = 1, RichFamily = 2, Executive = 3,
    Worker = 4, Big = 5, Taxi = 6, Moped = 7, Motorbike = 8,
    LeisureBoat = 9, WorkerBoat = 10, Bicycle = 11
}

/// <summary>Default vehicle model metadata from vehicles.ide; handling IDs reference handling.cfg.</summary>
public readonly partial record struct VehicleInfo(int ModelId, string ModelName, string TextureDictionary,
    VehicleKind Kind, string HandlingId, string GameNameKey, string? AnimationGroup, VehicleClass Class,
    int Frequency, uint Flags, uint ComponentRules, int? WheelModelId, float? WheelScaleFront,
    float? WheelScaleRear, int? WheelUpgradeClass)
{
    private static readonly Lazy<FrozenDictionary<int, VehicleInfo>> byId = new(
        () => entries.ToFrozenDictionary(info => info.ModelId), LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<FrozenDictionary<string, VehicleInfo>> byName = new(
        () => entries.ToFrozenDictionary(info => info.ModelName, StringComparer.OrdinalIgnoreCase),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<FrozenDictionary<VehicleKind, IReadOnlyList<VehicleInfo>>> byKind = new(
        () => entries.GroupBy(info => info.Kind).ToFrozenDictionary(group => group.Key,
            group => (IReadOnlyList<VehicleInfo>)Array.AsReadOnly(group.ToArray())),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<IReadOnlyList<VehicleInfo>> all = new(
        () => Array.AsReadOnly(entries), LazyThreadSafetyMode.ExecutionAndPublication);

    public static IReadOnlyList<VehicleInfo> All => all.Value;
    public static VehicleInfo Get(int modelId) => TryGet(modelId, out var info) ? info
        : throw new ArgumentOutOfRangeException(nameof(modelId), modelId, "Unknown vehicle model ID.");
    public static bool TryGet(int modelId, out VehicleInfo info) => byId.Value.TryGetValue(modelId, out info);
    public static bool TryGet(string modelName, out VehicleInfo info)
    {
        ArgumentNullException.ThrowIfNull(modelName);
        return byName.Value.TryGetValue(modelName, out info);
    }
    public static IReadOnlyList<VehicleInfo> GetByKind(VehicleKind kind)
        => byKind.Value.TryGetValue(kind, out var matches) ? matches : Array.Empty<VehicleInfo>();
}
