// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedIK : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CPedIK(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pPed")]
    public CPed? @Ped { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_TorsoOrien")]
    public LimbOrientation @TorsoOrien { get => new LimbOrientation(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,8); } }
    [NativeMember("m_fSlopePitch")]
    public float @SlopePitch { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_fSlopePitchLimitMult")]
    public float @SlopePitchLimitMult { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fSlopeRoll")]
    public float @SlopeRoll { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fBodyRoll")]
    public float @BodyRoll { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public void @RotateTorso(AnimBlendFrameData? @bone,LimbOrientation @orientation,bool @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1248 >(1248)(Pointer,@bone?.Pointer ?? IntPtr.Zero,@orientation.Pointer,(@flag ? 1 : 0)); }
    public bool @PointGunInDirection(float @Z_angle,float @arg2,bool @flag,float @arg4) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1249 >(1249)(Pointer,@Z_angle,@arg2,(@flag ? 1 : 0),@arg4); return __sdkResult != 0; }
    public void @PointGunAtPosition(CVector @posn,float @arg2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1250 >(1250)(Pointer,@posn.Pointer,@arg2); }
    public static RwMatrixTag? @GetWorldMatrix(RwFrame? @frame,RwMatrixTag? @transformMat) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1251 >(1251)(@frame?.Pointer ?? IntPtr.Zero,@transformMat?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwMatrixTag(__sdkResult); }
    public static MoveLimbResult @MoveLimb(LimbOrientation @TorsoOrien,float @yaw,float @pitch,LimbMovementInfo @LimbMoveInfo) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1252 >(1252)(@TorsoOrien.Pointer,@yaw,@pitch,@LimbMoveInfo.Pointer); return (MoveLimbResult)__sdkResult; }
    public static MoveLimbResult @MoveLimb(LimbOrientation @TorsoOrien,float @yaw,float @pitch,LimbMovementInfo @LimbMoveInfo,float @fNormalize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1253 >(1253)(@TorsoOrien.Pointer,@yaw,@pitch,@LimbMoveInfo.Pointer,@fNormalize); return (MoveLimbResult)__sdkResult; }
}
