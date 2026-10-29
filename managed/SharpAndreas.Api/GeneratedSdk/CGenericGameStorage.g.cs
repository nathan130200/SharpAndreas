// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CGenericGameStorage : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CGenericGameStorage(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_LoadFileNameWithPath")]
    public static NativePointer<sbyte> @LoadFileNameWithPath { get => new NativePointer<sbyte>(new IntPtr(0xC15F60)); }
    [NativeMember("ms_LoadFileName")]
    public static NativePointer<sbyte> @LoadFileName { get => new NativePointer<sbyte>(new IntPtr(0xC15FC8)); }
    [NativeMember("ms_SaveFileNameJustSaved")]
    public static NativePointer<sbyte> @SaveFileNameJustSaved { get => new NativePointer<sbyte>(new IntPtr(0xC16030)); }
    [NativeMember("ms_CheckSum")]
    public static int @CheckSum { get => SdkMemory.Read<int >(new IntPtr(0xC16134)); set { SdkMemory.Write(new IntPtr(0xC16134),value); } }
    [NativeMember("ms_SlotSaveDate")]
    public static tSlotSaveDate? @SlotSaveDate { get => new IntPtr(0xC16138) == IntPtr.Zero ? null : new tSlotSaveDate(new IntPtr(0xC16138)); }
    [NativeMember("ms_SlotFileName")]
    public static tSlotFileName? @SlotFileName { get => new IntPtr(0xC16368) == IntPtr.Zero ? null : new tSlotFileName(new IntPtr(0xC16368)); }
    [NativeMember("ms_ValidSaveName")]
    public static NativePointer<sbyte> @ValidSaveName { get => new NativePointer<sbyte>(new IntPtr(0xC16DB8)); }
    [NativeMember("ms_Slots")]
    public static NativePointer<int> @Slots { get => new NativePointer<int>(new IntPtr(0xC16EB8)); }
    [NativeMember("ms_WorkBuffer")]
    public static NativePointer<IntPtr> @WorkBuffer { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(new IntPtr(0xC16EE8))); set { SdkMemory.Write(new IntPtr(0xC16EE8),value.Pointer); } }
    [NativeMember("ms_WorkBufferPos")]
    public static int @WorkBufferPosition { get => SdkMemory.Read<int >(new IntPtr(0xC16EEC)); set { SdkMemory.Write(new IntPtr(0xC16EEC),value); } }
    [NativeMember("ms_FileHandle")]
    public static _iobuf? @FileHandle { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC16EF0)) == IntPtr.Zero ? null : new _iobuf(SdkMemory.Read<IntPtr>(new IntPtr(0xC16EF0))); set { SdkMemory.Write(new IntPtr(0xC16EF0),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_FilePos")]
    public static int @FilePosition { get => SdkMemory.Read<int >(new IntPtr(0xC16EF4)); set { SdkMemory.Write(new IntPtr(0xC16EF4),value); } }
    [NativeMember("ms_FileSize")]
    public static int @FileSize { get => SdkMemory.Read<int >(new IntPtr(0xC16EF8)); set { SdkMemory.Write(new IntPtr(0xC16EF8),value); } }
    [NativeMember("ms_bFailed")]
    public static bool @Failed { get => SdkMemory.Read<bool >(new IntPtr(0xC16EFC)); set { SdkMemory.Write(new IntPtr(0xC16EFC),value); } }
    [NativeMember("ms_bLoading")]
    public static bool @Loading { get => SdkMemory.Read<bool >(new IntPtr(0xC16EFD)); set { SdkMemory.Write(new IntPtr(0xC16EFD),value); } }
    public static bool @CheckDataNotCorrupt(int @saveID,NativePointer<sbyte> @saveGameFilename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2903 >(2903)(@saveID,@saveGameFilename.Pointer); return __sdkResult != 0; }
    public static bool @CheckSlotDataValid(int @saveID,bool @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2904 >(2904)(@saveID,(@unused ? 1 : 0)); return __sdkResult != 0; }
    public static void @DoGameSpecificStuffAfterSucessLoad() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2905 >(2905)(); }
    public static void @DoGameSpecificStuffBeforeSave() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2906 >(2906)(); }
    public static bool @GenericLoad(NativePointer<bool> @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2907 >(2907)(@arg1.Pointer); return __sdkResult != 0; }
    public static bool @GenericSave(int @unused) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2908 >(2908)(@unused); return __sdkResult != 0; }
    public static int @GetCurrentVersionNumber() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2909 >(2909)(); return __sdkResult; }
    public static NativePointer<sbyte> @GetNameOfSavedGame(int @saveID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2910 >(2910)(@saveID); return new NativePointer<sbyte>(__sdkResult); }
    public static NativePointer<sbyte> @GetNameOfSavedGame_Alt(int @saveID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2911 >(2911)(@saveID); return new NativePointer<sbyte>(__sdkResult); }
    public static int @GetSavedRadioStationPosition() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2912 >(2912)(); return __sdkResult; }
    public static void @InitNewSettingsAfterLoad() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2913 >(2913)(); }
    public static void @InitRadioStationPositionList() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2914 >(2914)(); }
    public static bool @LoadWorkBuffer() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2915 >(2915)(); return __sdkResult != 0; }
    public static void @MakeValidSaveName(int @saveNum) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2916 >(2916)(@saveNum); }
    public static bool @OpenFileForReading(NativePointer<sbyte> @saveGameFilename,NativePointer<uint> @saveID) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2917 >(2917)(@saveGameFilename.Pointer,@saveID.Pointer); return __sdkResult != 0; }
    public static bool @OpenFileForWriting() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2918 >(2918)(); return __sdkResult != 0; }
    public static void @ReportError(eSaveLoadBlocks @block,eSaveLoadError @errorType) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2919 >(2919)((int)@block,(int)@errorType); }
    public static sbyte @RestoreForStartLoad() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2920 >(2920)(); return __sdkResult; }
    public static bool @SaveWorkBuffer(bool @a1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2921 >(2921)((@a1 ? 1 : 0)); return __sdkResult != 0; }
    public static bool @_LoadDataFromWorkBuffer(NativePointer<IntPtr> @pData,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2922 >(2922)(@pData.Pointer,@size); return __sdkResult != 0; }
    public static bool @_SaveDataToWorkBuffer(NativePointer<IntPtr> @pData,int @Size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2923 >(2923)(@pData.Pointer,@Size); return __sdkResult != 0; }
}
