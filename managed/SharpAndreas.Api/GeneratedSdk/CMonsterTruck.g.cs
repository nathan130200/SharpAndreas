// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMonsterTruck : CAutomobile
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2460;
    public CMonsterTruck(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_988")]
    public float @Field988 { get => SdkMemory.Read<float >(Pointer+2440); set { SdkMemory.Write(Pointer+2440,value); } }
    [NativeMember("field_98C")]
    public float @Field98C { get => SdkMemory.Read<float >(Pointer+2444); set { SdkMemory.Write(Pointer+2444,value); } }
    [NativeMember("field_990")]
    public float @Field990 { get => SdkMemory.Read<float >(Pointer+2448); set { SdkMemory.Write(Pointer+2448,value); } }
    [NativeMember("field_994")]
    public float @Field994 { get => SdkMemory.Read<float >(Pointer+2452); set { SdkMemory.Write(Pointer+2452,value); } }
    [NativeMember("field_998")]
    public float @Field998 { get => SdkMemory.Read<float >(Pointer+2456); set { SdkMemory.Write(Pointer+2456,value); } }
    [NativeMember("DUMPER_COL_ANGLEMULT")]
    public static float @DUMPERCollisionANGLEMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D33A8)); set { SdkMemory.Write(new IntPtr(0x8D33A8),value); } }
    public void @InitializeAt(int @modelIndex,byte @createdBy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3206 >(3206)(Pointer,@modelIndex,@createdBy); }
    public void @ExtendSuspension() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3207 >(3207)(Pointer); }
}
