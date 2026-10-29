// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class C3dMarker : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=160;
    public C3dMarker(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_mat")]
    public CMatrix @Mat { get => new CMatrix(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,72); } }
    [NativeMember("m_pAtomic")]
    public RpAtomic? @Atomic { get => SdkMemory.Read<IntPtr>(Pointer+72) == IntPtr.Zero ? null : new RpAtomic(SdkMemory.Read<IntPtr>(Pointer+72)); set { SdkMemory.Write(Pointer+72,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pMaterial")]
    public RpMaterial? @Material { get => SdkMemory.Read<IntPtr>(Pointer+76) == IntPtr.Zero ? null : new RpMaterial(SdkMemory.Read<IntPtr>(Pointer+76)); set { SdkMemory.Write(Pointer+76,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nType")]
    public ushort @Type { get => SdkMemory.Read<ushort >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("m_bIsUsed")]
    public bool @IsUsed { get => SdkMemory.Read<bool >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("m_bMustBeRenderedThisFrame")]
    public bool @MustBeRenderedThisFrame { get => SdkMemory.Read<bool >(Pointer+83); set { SdkMemory.Write(Pointer+83,value); } }
    [NativeMember("m_nIdentifier")]
    public int @Identifier { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("m_colour")]
    public CRGBA @Color { get => new CRGBA(Pointer+88); set { SdkMemory.Copy(value.Pointer,Pointer+88,4); } }
    [NativeMember("m_nPulsePeriod")]
    public short @PulsePeriod { get => SdkMemory.Read<short >(Pointer+92); set { SdkMemory.Write(Pointer+92,value); } }
    [NativeMember("m_nRotateRate")]
    public short @RotateRate { get => SdkMemory.Read<short >(Pointer+94); set { SdkMemory.Write(Pointer+94,value); } }
    [NativeMember("m_nStartTime")]
    public int @StartTime { get => SdkMemory.Read<int >(Pointer+96); set { SdkMemory.Write(Pointer+96,value); } }
    [NativeMember("m_fPulseFraction")]
    public float @PulseFraction { get => SdkMemory.Read<float >(Pointer+100); set { SdkMemory.Write(Pointer+100,value); } }
    [NativeMember("m_fStdSize")]
    public float @StdSize { get => SdkMemory.Read<float >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+108); set { SdkMemory.Write(Pointer+108,value); } }
    [NativeMember("m_fBrightness")]
    public float @Brightness { get => SdkMemory.Read<float >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_fCameraRange")]
    public float @CameraRange { get => SdkMemory.Read<float >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    [NativeMember("m_vecNormal")]
    public CVector @Normal { get => new CVector(Pointer+120); set { SdkMemory.Copy(value.Pointer,Pointer+120,12); } }
    [NativeMember("m_nLastMapReadX")]
    public short @LastMapReadX { get => SdkMemory.Read<short >(Pointer+132); set { SdkMemory.Write(Pointer+132,value); } }
    [NativeMember("m_nLastMapReadY")]
    public short @LastMapReadY { get => SdkMemory.Read<short >(Pointer+134); set { SdkMemory.Write(Pointer+134,value); } }
    [NativeMember("m_fLastMapReadResultZ")]
    public float @LastMapReadResultZ { get => SdkMemory.Read<float >(Pointer+136); set { SdkMemory.Write(Pointer+136,value); } }
    [NativeMember("m_fRoofHeight")]
    public float @RoofHeight { get => SdkMemory.Read<float >(Pointer+140); set { SdkMemory.Write(Pointer+140,value); } }
    [NativeMember("m_vecLastPosition")]
    public CVector @LastPosition { get => new CVector(Pointer+144); set { SdkMemory.Copy(value.Pointer,Pointer+144,12); } }
    [NativeMember("m_nOnScreenTestTime")]
    public int @OnScreenTestTime { get => SdkMemory.Read<int >(Pointer+156); set { SdkMemory.Write(Pointer+156,value); } }
    public bool @AddMarker(uint @id,ushort @type,float @size,byte @red,byte @green,byte @blue,byte @alpha,ushort @pulsePeriod,float @pulseFraction,short @rotateRate) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D184 >(184)(Pointer,@id,@type,@size,@red,@green,@blue,@alpha,@pulsePeriod,@pulseFraction,@rotateRate); return __sdkResult != 0; }
    public void @DeleteMarkerObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D185 >(185)(Pointer); }
    public bool @IsZCoordinateUpToDate() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D186 >(186)(Pointer); return __sdkResult != 0; }
    public void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D187 >(187)(Pointer); }
    public void @SetZCoordinateIfNotUpToDate(float @coordinate) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D188 >(188)(Pointer,@coordinate); }
    public void @UpdateZCoordinate(CVector @arg0,float @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D189 >(189)(Pointer,@arg0.Pointer,@arg1); }
}
