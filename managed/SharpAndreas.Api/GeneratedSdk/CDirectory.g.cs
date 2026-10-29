// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDirectory : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CDirectory(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_pEntries")]
    public CDirectory__DirectoryInfo? @Entries { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CDirectory__DirectoryInfo(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nCapacity")]
    public uint @Capacity { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nNumEntries")]
    public uint @CountEntries { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bOwnsEntries")]
    public bool @OwnsEntries { get => SdkMemory.Read<bool >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2419 >(2419)(Pointer); }
    public void @InitializeAt(int @capacity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2420 >(2420)(Pointer,@capacity); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2421 >(2421)(Pointer); }
    public void @Init(int @capacity,NativePointer<IntPtr> @entries) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2422 >(2422)(Pointer,@capacity,@entries.Pointer); }
    public void @AddItem(CDirectory__DirectoryInfo @entry) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2423 >(2423)(Pointer,@entry.Pointer); }
    public void @ReadDirFile(NativePointer<sbyte> @filename) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2424 >(2424)(Pointer,@filename.Pointer); }
    public bool @WriteDirFile(NativePointer<sbyte> @filename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2425 >(2425)(Pointer,@filename.Pointer); return __sdkResult != 0; }
    public CDirectory__DirectoryInfo? @FindItem(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2426 >(2426)(Pointer,@name.Pointer); return __sdkResult == IntPtr.Zero ? null : new CDirectory__DirectoryInfo(__sdkResult); }
    public CDirectory__DirectoryInfo? @FindItem(NativePointer<sbyte> @name,NativePointer<uint> @outOffset,NativePointer<uint> @outStreamingSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2427 >(2427)(Pointer,@name.Pointer,@outOffset.Pointer,@outStreamingSize.Pointer); return __sdkResult == IntPtr.Zero ? null : new CDirectory__DirectoryInfo(__sdkResult); }
    public CDirectory__DirectoryInfo? @FindItem(uint @key,NativePointer<uint> @outOffset,NativePointer<uint> @outStreamingSize) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2428 >(2428)(Pointer,@key,@outOffset.Pointer,@outStreamingSize.Pointer); return __sdkResult == IntPtr.Zero ? null : new CDirectory__DirectoryInfo(__sdkResult); }
}
