// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCarGenerator : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CCarGenerator(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nModelId")]
    public short @ModelId { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nColor1")]
    public sbyte @Color1 { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_nColor2")]
    public sbyte @Color2 { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_vecPosn")]
    public CompressedVector @Position { get => new CompressedVector(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,6); } }
    [NativeMember("m_nAngle")]
    public sbyte @Angle { get => SdkMemory.Read<sbyte >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nAlarm")]
    public sbyte @Alarm { get => SdkMemory.Read<sbyte >(Pointer+11); set { SdkMemory.Write(Pointer+11,value); } }
    [NativeMember("m_nDoorLock")]
    public sbyte @DoorLock { get => SdkMemory.Read<sbyte >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nMinDelay")]
    public short @MinDelay { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nMaxDelay")]
    public short @MaxDelay { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nNextGenTime")]
    public int @NextGenTime { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nVehicleHandle")]
    public short @VehicleHandle { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nGenerateCount")]
    public short @GenerateCount { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nIplId")]
    public sbyte @IplId { get => SdkMemory.Read<sbyte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_bIsUsed")]
    public bool @IsUsed { get => SdkMemory.Read<bool >(Pointer+29); set { SdkMemory.Write(Pointer+29,value); } }
    public bool @CheckForBlockage(int @modelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1893 >(1893)(Pointer,@modelId); return __sdkResult != 0; }
    public bool @CheckIfWithinRangeOfAnyPlayers() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1894 >(1894)(Pointer); return __sdkResult != 0; }
    public void @DoInternalProcessing() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1895 >(1895)(Pointer); }
    public void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1896 >(1896)(Pointer); }
    public void @Setup(float @x,float @y,float @z,float @angle,int @modelId,short @color1,short @color2,byte @bforceSpawn,byte @alarm_chances,byte @doorLock_chances,ushort @minDelay,ushort @maxDelay,byte @iplId,byte @bOwnedbyplayer) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1897 >(1897)(Pointer,@x,@y,@z,@angle,@modelId,@color1,@color2,@bforceSpawn,@alarm_chances,@doorLock_chances,@minDelay,@maxDelay,@iplId,@bOwnedbyplayer); }
    public void @SwitchOff() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1898 >(1898)(Pointer); }
    public void @SwitchOn() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1899 >(1899)(Pointer); }
    public static uint @CalcNextGen() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1900 >(1900)(); return __sdkResult; }
    public static CCarGenerator? @Get(ushort @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1901 >(1901)(@index); return __sdkResult == IntPtr.Zero ? null : new CCarGenerator(__sdkResult); }
}
