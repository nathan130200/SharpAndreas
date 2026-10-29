// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CBaseModelInfo : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CBaseModelInfo(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nKey")]
    public uint @Key { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nRefCount")]
    public ushort @RefCount { get => SdkMemory.Read<ushort >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nTxdIndex")]
    public short @TxdIndex { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("m_nAlpha")]
    public byte @Alpha { get => SdkMemory.Read<byte >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nNum2dEffects")]
    public byte @Num2dEffects { get => SdkMemory.Read<byte >(Pointer+13); set { SdkMemory.Write(Pointer+13,value); } }
    [NativeMember("m_n2dEffectIndex")]
    public short @N2dEffectIndex { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("m_nObjectInfoIndex")]
    public short @ObjectInfoIndex { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_pColModel")]
    public CColModel? @CollisionModel { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CColModel(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_fDrawDistance")]
    public float @DrawDistance { get => SdkMemory.Read<float >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    public CBaseModelInfo? @AsAtomicModelInfoPtr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D364 >(364)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public CBaseModelInfo? @AsDamageAtomicModelInfoPtr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D365 >(365)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public CBaseModelInfo? @AsLodAtomicModelInfoPtr() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D366 >(366)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CBaseModelInfo(__sdkResult); }
    public eModelInfoType @GetModelType() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D367 >(367)(Pointer); return (eModelInfoType)__sdkResult; }
    public tTimeInfo? @GetTimeInfo() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D368 >(368)(Pointer); return __sdkResult == IntPtr.Zero ? null : new tTimeInfo(__sdkResult); }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D369 >(369)(Pointer); }
    public void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D370 >(370)(Pointer); }
    public void @DeleteRwObject() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D371 >(371)(Pointer); }
    public uint @GetRwModelType() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D372 >(372)(Pointer); return __sdkResult; }
    public RwObject? @CreateInstance(RwMatrixTag? @matrix) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D373 >(373)(Pointer,@matrix?.Pointer ?? IntPtr.Zero); return __sdkResult == IntPtr.Zero ? null : new RwObject(__sdkResult); }
    public RwObject? @CreateInstance() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D374 >(374)(Pointer); return __sdkResult == IntPtr.Zero ? null : new RwObject(__sdkResult); }
    public void @SetAnimFile(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D375 >(375)(Pointer,@filename.Pointer); }
    public void @ConvertAnimFileIndex() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D376 >(376)(Pointer); }
    public int @GetAnimFileIndex() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D377 >(377)(Pointer); return __sdkResult; }
    public void @SetTexDictionary(NativePointer<sbyte> @txdName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D378 >(378)(Pointer,@txdName.Pointer); }
    public void @ClearTexDictionary() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D379 >(379)(Pointer); }
    public void @AddTexDictionaryRef() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D380 >(380)(Pointer); }
    public void @RemoveTexDictionaryRef() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D381 >(381)(Pointer); }
    public void @AddRef() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D382 >(382)(Pointer); }
    public void @RemoveRef() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D383 >(383)(Pointer); }
    public void @SetColModel(CColModel? @colModel,bool @initPairedModel) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D384 >(384)(Pointer,@colModel?.Pointer ?? IntPtr.Zero,(@initPairedModel ? 1 : 0)); }
    public void @Init2dEffects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D385 >(385)(Pointer); }
    public void @DeleteCollisionModel() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D386 >(386)(Pointer); }
    public C2dEffect? @Get2dEffect(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D387 >(387)(Pointer,@index); return __sdkResult == IntPtr.Zero ? null : new C2dEffect(__sdkResult); }
    public void @Add2dEffect(C2dEffect? @effect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D388 >(388)(Pointer,@effect?.Pointer ?? IntPtr.Zero); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D389 >(389)(Pointer); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D390 >(390)(Pointer); }
    public bool @GetIsDrawLast() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D391 >(391)(Pointer); return __sdkResult != 0; }
    public bool @HasBeenPreRendered() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D392 >(392)(Pointer); return __sdkResult != 0; }
    public bool @HasComplexHierarchy() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D393 >(393)(Pointer); return __sdkResult != 0; }
    public bool @IsBackfaceCulled() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D394 >(394)(Pointer); return __sdkResult != 0; }
    public bool @IsBreakableStatuePart() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D395 >(395)(Pointer); return __sdkResult != 0; }
    public bool @IsLod() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D396 >(396)(Pointer); return __sdkResult != 0; }
    public bool @IsRoad() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D397 >(397)(Pointer); return __sdkResult != 0; }
    public bool @IsTagModel() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D398 >(398)(Pointer); return __sdkResult != 0; }
    public bool @SwaysInWind() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D399 >(399)(Pointer); return __sdkResult != 0; }
    public void @SetHasBeenPreRendered(int @bHasBeenPreRendered) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D400 >(400)(Pointer,@bHasBeenPreRendered); }
    public void @SetDoWeOwnTheColModel(int @bOwned) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D401 >(401)(Pointer,@bOwned); }
    public void @SetIsLod(int @bIsLod) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D402 >(402)(Pointer,@bIsLod); }
    public void @IncreaseAlpha() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D403 >(403)(Pointer); }
}
