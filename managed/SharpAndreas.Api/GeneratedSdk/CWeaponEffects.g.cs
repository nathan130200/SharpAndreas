// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CWeaponEffects : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CWeaponEffects(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bActive")]
    public bool @Active { get => SdkMemory.Read<bool >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nTimeWhenToDeactivate")]
    public int @TimeWhenToDeactivate { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_color")]
    public CRGBA @Color { get => new CRGBA(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,4); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("field_1C")]
    public int @Field1C { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("field_20")]
    public int @Field20 { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fRotation")]
    public float @Rotation { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("field_28")]
    public sbyte @Field28 { get => SdkMemory.Read<sbyte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4379 >(4379)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4380 >(4380)(Pointer); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4381 >(4381)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4382 >(4382)(); }
    public static bool @IsLockedOn(int @crosshairId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4383 >(4383)(@crosshairId); return __sdkResult != 0; }
    public static void @MarkTarget(int @crosshairId,CVector @posn,byte @red,byte @green,byte @blue,byte @alpha,float @size,byte @arg7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4384 >(4384)(@crosshairId,@posn.Pointer,@red,@green,@blue,@alpha,@size,@arg7); }
    public static void @ClearCrossHair(int @crosshairId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4385 >(4385)(@crosshairId); }
    public static void @ClearCrossHairs() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4386 >(4386)(); }
    public static void @ClearCrossHairImmediately(int @crosshairId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4387 >(4387)(@crosshairId); }
    public static void @ClearCrossHairsImmediately() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4388 >(4388)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4389 >(4389)(); }
}
