// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRegisteredCorona : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public CRegisteredCorona(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vPosn")]
    public CVector @Position { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_dwId")]
    public uint @Id { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_pTexture")]
    public RwTexture? @Texture { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new RwTexture(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fSize")]
    public float @Size { get => SdkMemory.Read<float >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fAngle")]
    public float @Angle { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fFarClip")]
    public float @FarClip { get => SdkMemory.Read<float >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_fNearClip")]
    public float @NearClip { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fHeightAboveGround")]
    public float @HeightAboveGround { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_fFadeSpeed")]
    public float @FadeSpeed { get => SdkMemory.Read<float >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_Color")]
    public CRGBA @Color { get => new CRGBA(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,4); } }
    [NativeMember("m_nFadeState")]
    public byte @FadeState { get => SdkMemory.Read<byte >(Pointer+48); set { SdkMemory.Write(Pointer+48,value); } }
    [NativeMember("m_bRegisteredThisFrame")]
    public byte @RegisteredThisFrame { get => SdkMemory.Read<byte >(Pointer+49); set { SdkMemory.Write(Pointer+49,value); } }
    [NativeMember("m_nFlareType")]
    public eCoronaFlareType @FlareType { get => SdkMemory.Read<eCoronaFlareType >(Pointer+50); set { SdkMemory.Write(Pointer+50,value); } }
    [NativeMember("m_bUsesReflection")]
    public byte @UsesReflection { get => SdkMemory.Read<byte >(Pointer+51); set { SdkMemory.Write(Pointer+51,value); } }
    [NativeMember("m_bCheckObstacles")]
    public byte @CheckObstacles { get => (byte)SdkMemory.ReadBits(Pointer,416,1); set { SdkMemory.WriteBits(Pointer,416,1,unchecked((ulong)value)); } }
    [NativeMember("m_bOffScreen")]
    public byte @OffScreen { get => (byte)SdkMemory.ReadBits(Pointer,417,1); set { SdkMemory.WriteBits(Pointer,417,1,unchecked((ulong)value)); } }
    [NativeMember("m_bJustCreated")]
    public byte @JustCreated { get => SdkMemory.Read<byte >(Pointer+53); set { SdkMemory.Write(Pointer+53,value); } }
    [NativeMember("m_bFlashWhileFading")]
    public byte @FlashWhileFading { get => (byte)SdkMemory.ReadBits(Pointer,432,1); set { SdkMemory.WriteBits(Pointer,432,1,unchecked((ulong)value)); } }
    [NativeMember("m_bOnlyFromBelow")]
    public byte @OnlyFromBelow { get => (byte)SdkMemory.ReadBits(Pointer,433,1); set { SdkMemory.WriteBits(Pointer,433,1,unchecked((ulong)value)); } }
    [NativeMember("m_bReflectionDelay")]
    public byte @ReflectionDelay { get => (byte)SdkMemory.ReadBits(Pointer,434,1); set { SdkMemory.WriteBits(Pointer,434,1,unchecked((ulong)value)); } }
    [NativeMember("m_bDrawWithWhiteCore")]
    public byte @DrawWithWhiteCore { get => (byte)SdkMemory.ReadBits(Pointer,435,1); set { SdkMemory.WriteBits(Pointer,435,1,unchecked((ulong)value)); } }
    [NativeMember("m_bAttached")]
    public byte @Attached { get => (byte)SdkMemory.ReadBits(Pointer,436,1); set { SdkMemory.WriteBits(Pointer,436,1,unchecked((ulong)value)); } }
    [NativeMember("m_pAttachedTo")]
    public CEntity? @AttachedTo { get => SdkMemory.Read<IntPtr>(Pointer+56) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+56)); set { SdkMemory.Write(Pointer+56,value?.Pointer ?? IntPtr.Zero); } }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2284 >(2284)(Pointer); }
}
