// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tCutsceneParticleEffect : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=108;
    public tCutsceneParticleEffect(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_szEffectName")]
    public NativeArray<sbyte> @EffectName { get => new NativeArray<sbyte>(Pointer+0,32); }
    [NativeMember("m_pFxSystem")]
    public FxSystem_c? @FxSystem { get => SdkMemory.Read<IntPtr>(Pointer+32) == IntPtr.Zero ? null : new FxSystem_c(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nStartTime")]
    public int @StartTime { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nEndTime")]
    public int @EndTime { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_nObjectId")]
    public int @ObjectId { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_szObjectPart")]
    public NativeArray<sbyte> @ObjectPart { get => new NativeArray<sbyte>(Pointer+48,32); }
    [NativeMember("m_vecPosn")]
    public CVector @Position { get => new CVector(Pointer+80); set { SdkMemory.Copy(value.Pointer,Pointer+80,12); } }
    [NativeMember("m_vecDirection")]
    public CVector @Direction { get => new CVector(Pointer+92); set { SdkMemory.Copy(value.Pointer,Pointer+92,12); } }
    [NativeMember("m_bPlaying")]
    public bool @Playing { get => SdkMemory.Read<bool >(Pointer+104); set { SdkMemory.Write(Pointer+104,value); } }
    [NativeMember("m_bStopped")]
    public bool @Stopped { get => SdkMemory.Read<bool >(Pointer+105); set { SdkMemory.Write(Pointer+105,value); } }
}
