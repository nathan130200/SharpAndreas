// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTheCarGenerators : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTheCarGenerators(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("GenerateEvenIfPlayerIsCloseCounter")]
    public static byte @GenerateEvenIfPlayerIsCloseCounter { get => SdkMemory.Read<byte >(new IntPtr(0xC279D0)); set { SdkMemory.Write(new IntPtr(0xC279D0),value); } }
    [NativeMember("ProcessCounter")]
    public static byte @ProcessCounter { get => SdkMemory.Read<byte >(new IntPtr(0xC279D1)); set { SdkMemory.Write(new IntPtr(0xC279D1),value); } }
    [NativeMember("NumOfCarGenerators")]
    public static uint @CountOfCarGenerators { get => SdkMemory.Read<uint >(new IntPtr(0xC279D4)); set { SdkMemory.Write(new IntPtr(0xC279D4),value); } }
    [NativeMember("m_SpecialPlateHandler")]
    public static CSpecialPlateHandler @SpecialPlateHandler { get => new CSpecialPlateHandler(new IntPtr(0xC279D8)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC279D8),244); } }
    [NativeMember("CarGeneratorArray")]
    public static CCarGenerator? @CarGeneratorArray { get => new IntPtr(0xC27AD0) == IntPtr.Zero ? null : new CCarGenerator(new IntPtr(0xC27AD0)); }
    public static int @CreateCarGenerator(float @x,float @y,float @z,float @angle,int @modelId,short @color1,short @color2,byte @forceSpawn,byte @alarm_chances,byte @doorLock_chances,ushort @minDelay,ushort @maxDelay,byte @iplId,byte @bOwnedbyplayer) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4073 >(4073)(@x,@y,@z,@angle,@modelId,@color1,@color2,@forceSpawn,@alarm_chances,@doorLock_chances,@minDelay,@maxDelay,@iplId,@bOwnedbyplayer); return __sdkResult; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4074 >(4074)(); }
    public static void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4075 >(4075)(); }
    public static void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4076 >(4076)(); }
    public static void @RemoveCarGenerators(byte @IplID) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4077 >(4077)(@IplID); }
    public static void @Save() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4078 >(4078)(); }
}
