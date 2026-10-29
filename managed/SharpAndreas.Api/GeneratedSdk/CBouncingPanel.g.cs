// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBouncingPanel : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CBouncingPanel(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFrameId")]
    public ushort @FrameId { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nAxis")]
    public ushort @Axis { get => SdkMemory.Read<ushort >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_fAngleLimit")]
    public float @AngleLimit { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_vecRotation")]
    public CVector @Rotation { get => new CVector(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("m_vecPos")]
    public CVector @Position { get => new CVector(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("BOUNCE_SPRING_DAMP_MULT")]
    public static float @BOUNCESPRINGDAMPMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D3954)); set { SdkMemory.Write(new IntPtr(0x8D3954),value); } }
    [NativeMember("BOUNCE_SPRING_RETURN_MULT")]
    public static float @BOUNCESPRINGRETURNMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D3958)); set { SdkMemory.Write(new IntPtr(0x8D3958),value); } }
    [NativeMember("BOUNCE_VEL_CHANGE_LIMIT")]
    public static float @BOUNCEVelocityCHANGELIMIT { get => SdkMemory.Read<float >(new IntPtr(0x8D395C)); set { SdkMemory.Write(new IntPtr(0x8D395C),value); } }
    [NativeMember("BOUNCE_HANGING_DAMP_MULT")]
    public static float @BOUNCEHANGINGDAMPMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D3960)); set { SdkMemory.Write(new IntPtr(0x8D3960),value); } }
    [NativeMember("BOUNCE_HANGING_RETURN_MULT")]
    public static float @BOUNCEHANGINGRETURNMULT { get => SdkMemory.Read<float >(new IntPtr(0x8D3964)); set { SdkMemory.Write(new IntPtr(0x8D3964),value); } }
    public void @ResetPanel() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D724 >(724)(Pointer); }
    public void @SetPanel(short @frameId,short @axis,float @angleLimit) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D725 >(725)(Pointer,@frameId,@axis,@angleLimit); }
    public void @ProcessPanel(CVehicle? @vehicle,RwFrame? @frame,CVector @arg2,CVector @arg3,float @arg4,float @arg5) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D726 >(726)(Pointer,@vehicle?.Pointer ?? IntPtr.Zero,@frame?.Pointer ?? IntPtr.Zero,@arg2.Pointer,@arg3.Pointer,@arg4,@arg5); }
}
