// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSetPiece : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CSetPiece(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nLastGenerationTime")]
    public int @LastGenerationTime { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nAreaCornerX1")]
    public short @AreaCornerX1 { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nAreaCornerY1")]
    public short @AreaCornerY1 { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nAreaCornerX2")]
    public short @AreaCornerX2 { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nAreaCornerY2")]
    public short @AreaCornerY2 { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nSpawnCoord1X")]
    public short @SpawnCoord1X { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nSpawnCoord1Y")]
    public short @SpawnCoord1Y { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nSpawnCoord2X")]
    public short @SpawnCoord2X { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nSpawnCoord2Y")]
    public short @SpawnCoord2Y { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_nTargetCoord1X")]
    public short @TargetCoord1X { get => SdkMemory.Read<short >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nTargetCoord1Y")]
    public short @TargetCoord1Y { get => SdkMemory.Read<short >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_nTargetCoord2X")]
    public short @TargetCoord2X { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nTargetCoord2Y")]
    public short @TargetCoord2Y { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3711 >(3711)(Pointer); }
    public CVector2D @GetSpawnCoord1() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D3712 >(3712)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CVector2D @GetSpawnCoord2() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D3713 >(3713)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CVector2D @GetTargetCoord1() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D3714 >(3714)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CVector2D @GetTargetCoord2() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D3715 >(3715)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @SetCornerA(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3716 >(3716)(Pointer,@coord.Pointer); }
    public void @SetCornerB(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3717 >(3717)(Pointer,@coord.Pointer); }
    public void @SetSpawnCoord1(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3718 >(3718)(Pointer,@coord.Pointer); }
    public void @SetSpawnCoord2(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3719 >(3719)(Pointer,@coord.Pointer); }
    public void @SetTargetCoord1(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3720 >(3720)(Pointer,@coord.Pointer); }
    public void @SetTargetCoord2(CVector2D @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3721 >(3721)(Pointer,@coord.Pointer); }
    public float @GetCornerAX() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3722 >(3722)(Pointer); return __sdkResult; }
    public float @GetCornerAY() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3723 >(3723)(Pointer); return __sdkResult; }
    public float @GetCornerBX() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3724 >(3724)(Pointer); return __sdkResult; }
    public float @GetCornerBY() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3725 >(3725)(Pointer); return __sdkResult; }
    public float @GetSpawnCoord1X() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3726 >(3726)(Pointer); return __sdkResult; }
    public float @GetSpawnCoord1Y() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3727 >(3727)(Pointer); return __sdkResult; }
    public float @GetSpawnCoord2X() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3728 >(3728)(Pointer); return __sdkResult; }
    public float @GetSpawnCoord2Y() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3729 >(3729)(Pointer); return __sdkResult; }
    public float @GetTargetCoord1X() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3730 >(3730)(Pointer); return __sdkResult; }
    public float @GetTargetCoord1Y() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3731 >(3731)(Pointer); return __sdkResult; }
    public float @GetTargetCoord2X() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3732 >(3732)(Pointer); return __sdkResult; }
    public float @GetTargetCoord2Y() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3733 >(3733)(Pointer); return __sdkResult; }
    public CCopPed? @TryToGenerateCopPed(CVector2D @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3734 >(3734)(Pointer,@posn.Pointer); return __sdkResult == IntPtr.Zero ? null : new CCopPed(__sdkResult); }
    public CVehicle? @TryToGenerateCopCar(CVector2D @posn,CVector2D @target) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3735 >(3735)(Pointer,@posn.Pointer,@target.Pointer); return __sdkResult == IntPtr.Zero ? null : new CVehicle(__sdkResult); }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3736 >(3736)(Pointer); }
}
