// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFileLoader : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CFileLoader(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_line")]
    public static NativeArray<sbyte> @Line { get => new NativeArray<sbyte>(new IntPtr(0xB71848),512); }
    public static void @AddTexDictionaries(RwTexDictionary? @dictionary,RwTexDictionary? @baseDictionary) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2558 >(2558)(@dictionary?.Pointer ?? IntPtr.Zero,@baseDictionary?.Pointer ?? IntPtr.Zero); }
    public static RpAtomic? @FindRelatedModelInfoCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2559 >(2559)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static bool @FinishLoadClumpFile(RwStream? @stream,uint @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2560 >(2560)(@stream?.Pointer ?? IntPtr.Zero,@modelIndex); return __sdkResult != 0; }
    public static void @LoadAnimatedClumpObject(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2561 >(2561)(@line.Pointer); }
    public static void @LoadAtomicFile(RwStream? @stream,uint @modelIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2562 >(2562)(@stream?.Pointer ?? IntPtr.Zero,@modelIndex); }
    public static void @LoadAtomicFile(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2563 >(2563)(@filename.Pointer); }
    public static RpClump? @LoadAtomicFile2Return(NativePointer<sbyte> @filename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2564 >(2564)(@filename.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpClump(__sdkResult); }
    public static void @LoadAudioZone(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2565 >(2565)(@line.Pointer); }
    public static void @LoadBoundingBox(NativePointer<byte> @data,CBoundingBox @outBoundBox) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2566 >(2566)(@data.Pointer,@outBoundBox.Pointer); }
    public static void @LoadCarGenerator(CFileCarGenerator? @carGen,int @iplId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2567 >(2567)(@carGen?.Pointer ?? IntPtr.Zero,@iplId); }
    public static void @LoadCarGenerator(NativePointer<sbyte> @line,int @iplId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2568 >(2568)(@line.Pointer,@iplId); }
    public static void @LoadCarPathNode(NativePointer<sbyte> @line,int @objModelIndex,int @pathEntryIndex,bool @a4) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2569 >(2569)(@line.Pointer,@objModelIndex,@pathEntryIndex,(@a4 ? 1 : 0)); }
    public static bool @LoadClumpFile(RwStream? @stream,uint @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2570 >(2570)(@stream?.Pointer ?? IntPtr.Zero,@modelIndex); return __sdkResult != 0; }
    public static void @LoadClumpFile(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2571 >(2571)(@filename.Pointer); }
    public static int @LoadClumpObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2572 >(2572)(@line.Pointer); return __sdkResult; }
    public static bool @LoadCollisionFile(NativePointer<byte> @data,uint @dataSize,byte @colId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2573 >(2573)(@data.Pointer,@dataSize,@colId); return __sdkResult != 0; }
    public static void @LoadCollisionFile(NativePointer<sbyte> @filename,byte @colId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2574 >(2574)(@filename.Pointer,@colId); }
    public static bool @LoadCollisionFileFirstTime(NativePointer<byte> @data,uint @dataSize,byte @colId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2575 >(2575)(@data.Pointer,@dataSize,@colId); return __sdkResult != 0; }
    public static void @LoadCollisionModel(NativePointer<byte> @data,CColModel @outColModel) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2576 >(2576)(@data.Pointer,@outColModel.Pointer); }
    public static void @LoadCollisionModelVer2(NativePointer<byte> @data,uint @dataSize,CColModel @outColModel,NativePointer<sbyte> @modelName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2577 >(2577)(@data.Pointer,@dataSize,@outColModel.Pointer,@modelName.Pointer); }
    public static void @LoadCollisionModelVer3(NativePointer<byte> @data,uint @dataSize,CColModel @outColModel,NativePointer<sbyte> @modelName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2578 >(2578)(@data.Pointer,@dataSize,@outColModel.Pointer,@modelName.Pointer); }
    public static void @LoadCollisionModelVer4(NativePointer<IntPtr> @data,uint @dataSize,CColModel @outColModel,NativePointer<sbyte> @modelName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2579 >(2579)(@data.Pointer,@dataSize,@outColModel.Pointer,@modelName.Pointer); }
    public static void @LoadCullZone(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2580 >(2580)(@line.Pointer); }
    public static void @LoadEntryExit(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2581 >(2581)(@line.Pointer); }
    public static void @LoadGarage(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2582 >(2582)(@line.Pointer); }
    public static void @LoadLevel(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2583 >(2583)(@filename.Pointer); }
    public static NativePointer<sbyte> @LoadLine(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2584 >(2584)(@file); return new NativePointer<sbyte>(__sdkResult); }
    public static NativePointer<sbyte> @LoadLine(NativePointer<IntPtr> @outLine,NativePointer<int> @outSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2585 >(2585)(@outLine.Pointer,@outSize.Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public static int @LoadObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2586 >(2586)(@line.Pointer); return __sdkResult; }
    public static CEntity? @LoadObjectInstance(CFileObjectInstance? @objInstance,NativePointer<sbyte> @modelname) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2587 >(2587)(@objInstance?.Pointer ?? IntPtr.Zero,@modelname.Pointer); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public static CEntity? @LoadObjectInstance(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2588 >(2588)(@line.Pointer); return __sdkResult == IntPtr.Zero ? null : new CEntity(__sdkResult); }
    public static void @LoadObjectTypes(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2589 >(2589)(@filename.Pointer); }
    public static void @LoadOcclusionVolume(NativePointer<sbyte> @line,NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2590 >(2590)(@line.Pointer,@filename.Pointer); }
    public static int @LoadPathHeader(NativePointer<sbyte> @line,NativePointer<int> @outPathType) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2591 >(2591)(@line.Pointer,@outPathType.Pointer); return __sdkResult; }
    public static int @LoadPedObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2592 >(2592)(@line.Pointer); return __sdkResult; }
    public static void @LoadPedPathNode(NativePointer<sbyte> @line,int @objModelIndex,int @pathEntryIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2593 >(2593)(@line.Pointer,@objModelIndex,@pathEntryIndex); }
    public static void @LoadPickup(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2594 >(2594)(@line.Pointer); }
    public static void @LoadScene(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2595 >(2595)(@filename.Pointer); }
    public static void @LoadStuntJump(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2596 >(2596)(@line.Pointer); }
    public static void @LoadTXDParent(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2597 >(2597)(@line.Pointer); }
    public static RwTexDictionary? @LoadTexDictionary(NativePointer<sbyte> @filename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2598 >(2598)(@filename.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwTexDictionary(__sdkResult); }
    public static void @LoadTimeCyclesModifier(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2599 >(2599)(@line.Pointer); }
    public static int @LoadTimeObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2600 >(2600)(@line.Pointer); return __sdkResult; }
    public static int @LoadVehicleObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2601 >(2601)(@line.Pointer); return __sdkResult; }
    public static int @LoadWeaponObject(NativePointer<sbyte> @line) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2602 >(2602)(@line.Pointer); return __sdkResult; }
    public static void @LoadZone(NativePointer<sbyte> @line) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2603 >(2603)(@line.Pointer); }
    public static void @ReloadObjectTypes(NativePointer<sbyte> @arg1) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2604 >(2604)(@arg1.Pointer); }
    public static void @ReloadPaths(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2605 >(2605)(@filename.Pointer); }
    public static void @SaveTexDictionary(RwTexDictionary? @dictionary,NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2606 >(2606)(@dictionary?.Pointer ?? IntPtr.Zero,@filename.Pointer); }
    public static RpAtomic? @SetRelatedModelInfoCB(RpAtomic? @atomic,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2607 >(2607)(@atomic?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RpAtomic(__sdkResult); }
    public static bool @StartLoadClumpFile(RwStream? @stream,uint @modelIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2608 >(2608)(@stream?.Pointer ?? IntPtr.Zero,@modelIndex); return __sdkResult != 0; }
}
