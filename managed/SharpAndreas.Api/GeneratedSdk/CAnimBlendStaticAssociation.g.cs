// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendStaticAssociation : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CAnimBlendStaticAssociation(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nNumBlendNodes")]
    public ushort @CountBlendNodes { get => SdkMemory.Read<ushort >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nAnimId")]
    public short @AnimationId { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nAnimGroup")]
    public ushort @AnimationGroup { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nFlags")]
    public ushort @Flags { get => SdkMemory.Read<ushort >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_pSequenceArray")]
    public NativePointer<IntPtr> @SequenceArray { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+12)); set { SdkMemory.Write(Pointer+12,value.Pointer); } }
    [NativeMember("m_pHeirarchy")]
    public CAnimBlendHierarchy? @Heirarchy { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CAnimBlendHierarchy(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    public void @AllocateSequenceArray(int @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D662 >(662)(Pointer,@count); }
    public void @FreeSequenceArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D663 >(663)(Pointer); }
    public void @Init(RpClump? @clump,CAnimBlendHierarchy? @hierarchy) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D664 >(664)(Pointer,@clump?.Pointer ?? IntPtr.Zero,@hierarchy?.Pointer ?? IntPtr.Zero); }
}
