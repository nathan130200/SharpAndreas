// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimBlendAssocGroup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=20;
    public CAnimBlendAssocGroup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pAnimBlock")]
    public CAnimBlock? @AnimationBlock { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CAnimBlock(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_pAssociations")]
    public CAnimBlendStaticAssociation? @Associations { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CAnimBlendStaticAssociation(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nNumAnimations")]
    public uint @CountAnimations { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nIdOffset")]
    public int @IdOffset { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nGroupID")]
    public int @GroupID { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D609 >(609)(Pointer); }
    public CAnimBlendAssociation? @CopyAnimation(NativePointer<sbyte> @AnimName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D610 >(610)(Pointer,@AnimName.Pointer); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public CAnimBlendAssociation? @CopyAnimation(uint @ID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D611 >(611)(Pointer,@ID); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public void @CreateAssociations(NativePointer<sbyte> @szBlockName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D612 >(612)(Pointer,@szBlockName.Pointer); }
    public void @CreateAssociations(NativePointer<sbyte> @AnimName,RpClump? @pClump,NativePointer<IntPtr> @arg3,int @NumAnimations) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D613 >(613)(Pointer,@AnimName.Pointer,@pClump?.Pointer ?? IntPtr.Zero,@arg3.Pointer,@NumAnimations); }
    public void @CreateAssociations(NativePointer<sbyte> @AnimName,NativePointer<sbyte> @arg2,NativePointer<sbyte> @arg3,int @arg4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D614 >(614)(Pointer,@AnimName.Pointer,@arg2.Pointer,@arg3.Pointer,@arg4); }
    public void @DestroyAssociations() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D615 >(615)(Pointer); }
    public CAnimBlendAssociation? @GetAnimation(NativePointer<sbyte> @AnimName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D616 >(616)(Pointer,@AnimName.Pointer); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public CAnimBlendAssociation? @GetAnimation(uint @ID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D617 >(617)(Pointer,@ID); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public uint @GetAnimationId(NativePointer<sbyte> @AnimName) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D618 >(618)(Pointer,@AnimName.Pointer); return __sdkResult; }
    public void @InitEmptyAssociations(RpClump? @pClump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D619 >(619)(Pointer,@pClump?.Pointer ?? IntPtr.Zero); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D620 >(620)(Pointer); }
}
