// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBulletTrace : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=44;
    public CBulletTrace(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_vecStart")]
    public CVector @Start { get => new CVector(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,12); } }
    [NativeMember("m_vecEnd")]
    public CVector @End { get => new CVector(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,12); } }
    [NativeMember("m_bExists")]
    public bool @Exists { get => SdkMemory.Read<bool >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nCreationTime")]
    public int @CreationTime { get => SdkMemory.Read<int >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nLifeTime")]
    public uint @LifeTime { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fRadius")]
    public float @Radius { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nTransparency")]
    public byte @Transparency { get => SdkMemory.Read<byte >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1242 >(1242)(Pointer); }
}
