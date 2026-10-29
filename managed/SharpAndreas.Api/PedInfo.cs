using System.Collections.Frozen;

namespace SharpAndreas;

[Flags]
public enum PedVehiclePreferences : uint
{
    None = 0, NormalCar = 1, PoorFamilyCar = 2, RichFamilyCar = 4,
    ExecutiveCar = 8, WorkerCar = 16, BigCar = 32, Taxi = 64,
    Moped = 128, Motorbike = 256, LeisureBoat = 512, WorkerBoat = 1024,
    Bicycle = 2048, OnFoot = 4096
}

/// <summary>Default behavior profile from pedstats.dat; values are metadata, not a live ped's stats.</summary>
public readonly record struct PedStats(int Id, string Name, float FleeDistance, float HeadingChangeRate,
    int Fear, int Temper, int Lawfulness, int Sexiness, float AttackStrength, float DefendWeakness,
    int ShootingRate, int DefaultDecisionMaker);

/// <summary>Default model metadata from peds.ide, including its pedstats.dat behavior profile.</summary>
public readonly partial record struct PedInfo(int ModelId, string ModelName, string TextureDictionary,
    PedType PedType, PedStats Stats, string AnimationGroup, PedVehiclePreferences VehiclePreferences,
    uint Flags, string? AnimationFile, int RadioStation1, int RadioStation2,
    string AudioType, string VoiceMin, string VoiceMax)
{
    private static readonly Lazy<FrozenDictionary<int, PedInfo>> byId = new(
        () => entries.ToFrozenDictionary(info => info.ModelId), LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<FrozenDictionary<string, PedInfo>> byName = new(
        () => entries.ToFrozenDictionary(info => info.ModelName, StringComparer.OrdinalIgnoreCase),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<FrozenDictionary<PedType, IReadOnlyList<PedInfo>>> byType = new(
        () => entries.GroupBy(info => info.PedType).ToFrozenDictionary(group => group.Key,
            group => (IReadOnlyList<PedInfo>)Array.AsReadOnly(group.ToArray())),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private static readonly Lazy<IReadOnlyList<PedInfo>> all = new(
        () => Array.AsReadOnly(entries), LazyThreadSafetyMode.ExecutionAndPublication);

    public bool BuysDrugs => (Flags & 1) != 0;
    public bool IsSpecialModel => ModelId is >= 290 and <= 299;
    public static IReadOnlyList<PedInfo> All => all.Value;
    public static PedInfo Get(int modelId) => TryGet(modelId, out var info) ? info
        : throw new ArgumentOutOfRangeException(nameof(modelId), modelId, "Unknown ped model ID.");
    public static bool TryGet(int modelId, out PedInfo info) => byId.Value.TryGetValue(modelId, out info);
    public static bool TryGet(string modelName, out PedInfo info)
    {
        ArgumentNullException.ThrowIfNull(modelName);
        return byName.Value.TryGetValue(modelName, out info);
    }
    public static IReadOnlyList<PedInfo> GetByPedType(PedType type)
        => byType.Value.TryGetValue(type, out var matches) ? matches : Array.Empty<PedInfo>();
}
