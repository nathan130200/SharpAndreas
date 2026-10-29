// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskSimpleIKLookAt : CTaskSimpleIKChain
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=92;
    public CTaskSimpleIKLookAt(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_bUseTorso")]
    public bool @UseTorso { get => SdkMemory.Read<bool >(Pointer+88); set { SdkMemory.Write(Pointer+88,value); } }
    [NativeMember("m_priority")]
    public sbyte @Priority { get => SdkMemory.Read<sbyte >(Pointer+89); set { SdkMemory.Write(Pointer+89,value); } }
    public void @InitializeAt(NativePointer<sbyte> @idString,CEntity? @pEntity,int @time,int @offsetBoneTag,RwV3d @offsetPos,bool @bUseTorso,float @speed,int @blendTime,int @m_priority) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4046 >(4046)(Pointer,@idString.Pointer,@pEntity?.Pointer ?? IntPtr.Zero,@time,@offsetBoneTag,@offsetPos.Pointer,(@bUseTorso ? 1 : 0),@speed,@blendTime,@m_priority); }
}
