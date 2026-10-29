// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class SurfaceInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=316;
    public SurfaceInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("SurfaceName")]
    public NativeArray<sbyte> @SurfaceName { get => new NativeArray<sbyte>(Pointer+0,64); }
    [NativeMember("AdhesionGroup")]
    public NativeArray<sbyte> @AdhesionGroup { get => new NativeArray<sbyte>(Pointer+64,32); }
    [NativeMember("TyreGrip")]
    public float @TyreGrip { get => SdkMemory.Read<float >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("WetGrip")]
    public float @WetGrip { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("SkidMark")]
    public NativeArray<sbyte> @SkidMark { get => new NativeArray<sbyte>(Pointer+104,32); }
    [NativeMember("FrictionEffect")]
    public NativeArray<sbyte> @FrictionEffect { get => new NativeArray<sbyte>(Pointer+136,32); }
    [NativeMember("SoftLand")]
    public int @SoftLand { get => SdkMemory.Read<int >(Pointer+168); set { SdkMemory.Write(Pointer+168,value); } }
    [NativeMember("SeeThrough")]
    public int @SeeThrough { get => SdkMemory.Read<int >(Pointer+172); set { SdkMemory.Write(Pointer+172,value); } }
    [NativeMember("ShootThrough")]
    public int @ShootThrough { get => SdkMemory.Read<int >(Pointer+176); set { SdkMemory.Write(Pointer+176,value); } }
    [NativeMember("Sand")]
    public int @Sand { get => SdkMemory.Read<int >(Pointer+180); set { SdkMemory.Write(Pointer+180,value); } }
    [NativeMember("Water")]
    public int @Water { get => SdkMemory.Read<int >(Pointer+184); set { SdkMemory.Write(Pointer+184,value); } }
    [NativeMember("ShallowWater")]
    public int @ShallowWater { get => SdkMemory.Read<int >(Pointer+188); set { SdkMemory.Write(Pointer+188,value); } }
    [NativeMember("Beach")]
    public int @Beach { get => SdkMemory.Read<int >(Pointer+192); set { SdkMemory.Write(Pointer+192,value); } }
    [NativeMember("SteepSlope")]
    public int @SteepSlope { get => SdkMemory.Read<int >(Pointer+196); set { SdkMemory.Write(Pointer+196,value); } }
    [NativeMember("Glass")]
    public int @Glass { get => SdkMemory.Read<int >(Pointer+200); set { SdkMemory.Write(Pointer+200,value); } }
    [NativeMember("Stairs")]
    public int @Stairs { get => SdkMemory.Read<int >(Pointer+204); set { SdkMemory.Write(Pointer+204,value); } }
    [NativeMember("Skateable")]
    public int @Skateable { get => SdkMemory.Read<int >(Pointer+208); set { SdkMemory.Write(Pointer+208,value); } }
    [NativeMember("Pavement")]
    public int @Pavement { get => SdkMemory.Read<int >(Pointer+212); set { SdkMemory.Write(Pointer+212,value); } }
    [NativeMember("Roughness")]
    public int @Roughness { get => SdkMemory.Read<int >(Pointer+216); set { SdkMemory.Write(Pointer+216,value); } }
    [NativeMember("Flame")]
    public int @Flame { get => SdkMemory.Read<int >(Pointer+220); set { SdkMemory.Write(Pointer+220,value); } }
    [NativeMember("Sparks")]
    public int @Sparks { get => SdkMemory.Read<int >(Pointer+224); set { SdkMemory.Write(Pointer+224,value); } }
    [NativeMember("Sprint")]
    public int @Sprint { get => SdkMemory.Read<int >(Pointer+228); set { SdkMemory.Write(Pointer+228,value); } }
    [NativeMember("Footsteps")]
    public int @Footsteps { get => SdkMemory.Read<int >(Pointer+232); set { SdkMemory.Write(Pointer+232,value); } }
    [NativeMember("FootDust")]
    public int @FootDust { get => SdkMemory.Read<int >(Pointer+236); set { SdkMemory.Write(Pointer+236,value); } }
    [NativeMember("CarDirt")]
    public int @CarDirt { get => SdkMemory.Read<int >(Pointer+240); set { SdkMemory.Write(Pointer+240,value); } }
    [NativeMember("CarClean")]
    public int @CarClean { get => SdkMemory.Read<int >(Pointer+244); set { SdkMemory.Write(Pointer+244,value); } }
    [NativeMember("WheelGrass")]
    public int @WheelGrass { get => SdkMemory.Read<int >(Pointer+248); set { SdkMemory.Write(Pointer+248,value); } }
    [NativeMember("WheelGravel")]
    public int @WheelGravel { get => SdkMemory.Read<int >(Pointer+252); set { SdkMemory.Write(Pointer+252,value); } }
    [NativeMember("WheelMud")]
    public int @WheelMud { get => SdkMemory.Read<int >(Pointer+256); set { SdkMemory.Write(Pointer+256,value); } }
    [NativeMember("WheelDust")]
    public int @WheelDust { get => SdkMemory.Read<int >(Pointer+260); set { SdkMemory.Write(Pointer+260,value); } }
    [NativeMember("WheelSand")]
    public int @WheelSand { get => SdkMemory.Read<int >(Pointer+264); set { SdkMemory.Write(Pointer+264,value); } }
    [NativeMember("WheelSpray")]
    public int @WheelSpray { get => SdkMemory.Read<int >(Pointer+268); set { SdkMemory.Write(Pointer+268,value); } }
    [NativeMember("ProcPlant")]
    public int @ProcPlant { get => SdkMemory.Read<int >(Pointer+272); set { SdkMemory.Write(Pointer+272,value); } }
    [NativeMember("ProcObj")]
    public int @ProcObject { get => SdkMemory.Read<int >(Pointer+276); set { SdkMemory.Write(Pointer+276,value); } }
    [NativeMember("Climbable")]
    public int @Climbable { get => SdkMemory.Read<int >(Pointer+280); set { SdkMemory.Write(Pointer+280,value); } }
    [NativeMember("BulletFx")]
    public NativeArray<sbyte> @BulletFx { get => new NativeArray<sbyte>(Pointer+284,32); }
}
