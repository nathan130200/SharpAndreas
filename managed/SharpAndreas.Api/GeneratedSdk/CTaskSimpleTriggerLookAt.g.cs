// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleTriggerLookAt : CTaskSimple
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CTaskSimpleTriggerLookAt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pEntity")]
    public CEntity? @Entity { get => SdkMemory.Read<IntPtr>(Pointer+8) == IntPtr.Zero ? null : new CEntity(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_time")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_offsetBoneTag")]
    public int @OffsetBoneTag { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_offsetPos")]
    public RwV3d @OffsetPosition { get => new RwV3d(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("m_bUseTorso")]
    public bool @UseTorso { get => SdkMemory.Read<bool >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_fSpeed")]
    public float @Speed { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_BlendTime")]
    public int @BlendTime { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_bEntityExist")]
    public bool @EntityExist { get => SdkMemory.Read<bool >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    [NativeMember("m_priority")]
    public sbyte @Priority { get => SdkMemory.Read<sbyte >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    public void @InitializeAt(CEntity? @pEntity,int @time,int @offsetBoneTag,RwV3d @offsetPos,bool @bUseTorso,float @speed,int @blendTime,int @priority) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4055 >(4055)(Pointer,@pEntity?.Pointer ?? IntPtr.Zero,@time,@offsetBoneTag,@offsetPos.Pointer,(@bUseTorso ? 1 : 0),@speed,@blendTime,@priority); }
}
