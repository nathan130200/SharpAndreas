// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimManager : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CAnimManager(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_aAnimAssocDefinitions")]
    public static CAnimationStyleDescriptor? @AnimationAssocDefinitions { get => new IntPtr(0x8AA5A8) == IntPtr.Zero ? null : new CAnimationStyleDescriptor(new IntPtr(0x8AA5A8)); }
    [NativeMember("ms_aAnimAssocGroups")]
    public static CAnimBlendAssocGroup? @AnimationAssocGroups { get => new IntPtr(0xB4EA34) == IntPtr.Zero ? null : new CAnimBlendAssocGroup(new IntPtr(0xB4EA34)); }
    [NativeMember("ms_aAnimations")]
    public static CAnimBlendHierarchy? @Animations { get => new IntPtr(0xB4EA40) == IntPtr.Zero ? null : new CAnimBlendHierarchy(new IntPtr(0xB4EA40)); }
    [NativeMember("ms_aAnimBlocks")]
    public static CAnimBlock? @AnimationBlocks { get => new IntPtr(0xB5D4A0) == IntPtr.Zero ? null : new CAnimBlock(new IntPtr(0xB5D4A0)); }
    [NativeMember("ms_animCache")]
    public static CAnimBlendHierarchy? @AnimationCache { get => new IntPtr(0xB5EB20) == IntPtr.Zero ? null : new CAnimBlendHierarchy(new IntPtr(0xB5EB20)); }
    [NativeMember("ms_numAnimAssocDefinitions")]
    public static int @CountAnimationAssocDefinitions { get => SdkMemory.Read<int >(new IntPtr(0xB4EA28)); set { SdkMemory.Write(new IntPtr(0xB4EA28),value); } }
    [NativeMember("ms_numAnimBlocks")]
    public static int @CountAnimationBlocks { get => SdkMemory.Read<int >(new IntPtr(0xB4EA30)); set { SdkMemory.Write(new IntPtr(0xB4EA30),value); } }
    [NativeMember("ms_numAnimations")]
    public static int @CountAnimations { get => SdkMemory.Read<int >(new IntPtr(0xB4EA2C)); set { SdkMemory.Write(new IntPtr(0xB4EA2C),value); } }
    public static CAnimBlock? @GetAnimationBlock(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D665 >(665)(@name.Pointer); return __sdkResult == IntPtr.Zero ? null : new CAnimBlock(__sdkResult); }
    public static int @GetAnimationBlockIndex(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D666 >(666)(@name.Pointer); return __sdkResult; }
    public static int @GetFirstAssocGroup(NativePointer<sbyte> @basename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D667 >(667)(@basename.Pointer); return __sdkResult; }
    public static CAnimBlendHierarchy? @GetAnimation(uint @hash,CAnimBlock? @ifp) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D668 >(668)(@hash,@ifp?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendHierarchy(__sdkResult); }
    public static CAnimBlendHierarchy? @GetAnimation(NativePointer<sbyte> @animName,CAnimBlock? @ifp) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D669 >(669)(@animName.Pointer,@ifp?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendHierarchy(__sdkResult); }
    public static NativePointer<sbyte> @GetAnimGroupName(int @AssocGroupId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D670 >(670)(@AssocGroupId); return new NativePointer<sbyte>(__sdkResult); }
    public static NativePointer<sbyte> @GetAnimBlockName(int @AssocGroupId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D671 >(671)(@AssocGroupId); return new NativePointer<sbyte>(__sdkResult); }
    public static CAnimBlendAssociation? @CreateAnimAssociation(int @AssocGroupId,int @AnimationId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D672 >(672)(@AssocGroupId,@AnimationId); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static CAnimBlendStaticAssociation? @GetAnimAssociation(int @AssocGroupId,int @AnimationId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D673 >(673)(@AssocGroupId,@AnimationId); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendStaticAssociation(__sdkResult); }
    public static CAnimBlendStaticAssociation? @GetAnimAssociation(int @AssocGroupId,NativePointer<sbyte> @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D674 >(674)(@AssocGroupId,@arg2.Pointer); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendStaticAssociation(__sdkResult); }
    public static CAnimBlendAssociation? @AddAnimation(RpClump? @clump,int @AssocGroupId,int @AnimationId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D675 >(675)(@clump?.Pointer ?? IntPtr.Zero,@AssocGroupId,@AnimationId); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static CAnimBlendAssociation? @AddAnimation(RpClump? @clump,CAnimBlendHierarchy? @pAnimBlendHier,int @clumpAssocFlag) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D676 >(676)(@clump?.Pointer ?? IntPtr.Zero,@pAnimBlendHier?.Pointer ?? IntPtr.Zero,@clumpAssocFlag); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static CAnimBlendAssociation? @AddAnimationAndSync(RpClump? @clump,CAnimBlendAssociation? @pAnimBlendAssoc,int @AssocGroupId,int @AnimationId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D677 >(677)(@clump?.Pointer ?? IntPtr.Zero,@pAnimBlendAssoc?.Pointer ?? IntPtr.Zero,@AssocGroupId,@AnimationId); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static CAnimationStyleDescriptor? @AddAnimAssocDefinition(NativePointer<sbyte> @groupName,NativePointer<sbyte> @blockName,uint @arg3,uint @animsCount,NativePointer<IntPtr> @pAnimDescriptor) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D678 >(678)(@groupName.Pointer,@blockName.Pointer,@arg3,@animsCount,@pAnimDescriptor.Pointer); return __sdkResult == IntPtr.Zero ? null : new CAnimationStyleDescriptor(__sdkResult); }
    public static NativePointer<IntPtr> @AddAnimToAssocDefinition(NativePointer<IntPtr> @pAnimAssocDefinition,NativePointer<sbyte> @arg2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D679 >(679)(@pAnimAssocDefinition.Pointer,@arg2.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static void @CreateAnimAssocGroups() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D680 >(680)(); }
    public static int @RegisterAnimBlock(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D681 >(681)(@name.Pointer); return __sdkResult; }
    public static void @RemoveLastAnimFile() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D682 >(682)(); }
    public static void @RemoveAnimBlock(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D683 >(683)(@index); }
    public static void @AddAnimBlockRef(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D684 >(684)(@index); }
    public static void @RemoveAnimBlockRef(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D685 >(685)(@index); }
    public static void @RemoveAnimBlockRefWithoutDelete(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D686 >(686)(@index); }
    public static int @GetNumRefsToAnimBlock(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D687 >(687)(@index); return __sdkResult; }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D688 >(688)(); }
    public static void @UncompressAnimation(CAnimBlendHierarchy? @pAnimBlendHier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D689 >(689)(@pAnimBlendHier?.Pointer ?? IntPtr.Zero); }
    public static void @RemoveFromUncompressedCache(CAnimBlendHierarchy? @pAnimBlendHier) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D690 >(690)(@pAnimBlendHier?.Pointer ?? IntPtr.Zero); }
    public static CAnimBlendAssociation? @BlendAnimation(RpClump? @clump,CAnimBlendHierarchy? @pAnimBlendHier,int @flags,float @clumpAssocBlendData) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D691 >(691)(@clump?.Pointer ?? IntPtr.Zero,@pAnimBlendHier?.Pointer ?? IntPtr.Zero,@flags,@clumpAssocBlendData); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static CAnimBlendAssociation? @BlendAnimation(RpClump? @clump,int @AssocGroupId,int @AnimationId,float @clumpAssocBlendData) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D692 >(692)(@clump?.Pointer ?? IntPtr.Zero,@AssocGroupId,@AnimationId,@clumpAssocBlendData); return __sdkResult == IntPtr.Zero ? null : new CAnimBlendAssociation(__sdkResult); }
    public static void @LoadAnimFile(RwStream? @stream,bool @arg1,NativeArray<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D693 >(693)(@stream?.Pointer ?? IntPtr.Zero,(@arg1 ? 1 : 0),@string.Pointer); }
    public static void @LoadAnimFiles() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D694 >(694)(); }
    public static void @ReadAnimAssociationDefinitions() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D695 >(695)(); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D696 >(696)(); }
}
