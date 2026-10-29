// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCheckpoint : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public CCheckpoint(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nType")]
    public ushort @Type { get => SdkMemory.Read<ushort >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_bIsUsed")]
    public bool @IsUsed { get => SdkMemory.Read<bool >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("m_bMustBeRenderedThisFrame")]
    public bool @MustBeRenderedThisFrame { get => SdkMemory.Read<bool >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("m_nIdentifier")]
    public int @Identifier { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_colour")]
    public CRGBA @Color { get => new CRGBA(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,4); } }
    [NativeMember("m_nPulsePeriod")]
    public short @PulsePeriod { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nRotateRate")]
    public short @RotateRate { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_vecPosition")]
    public CVector @Position { get => new CVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,12); } }
    [NativeMember("m_vecDirection")]
    public CVector @Direction { get => new CVector(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,12); } }
    [NativeMember("m_fPulseFraction")]
    public float @PulseFraction { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_fDistanceToPlayer")]
    public float @DistanceToPlayer { get => SdkMemory.Read<float >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_multiSize")]
    public float @MultiSize { get => SdkMemory.Read<float >(Pointer+52); set { SdkMemory.Write(Pointer+52,value); } }
    public void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1972 >(1972)(Pointer); }
}
