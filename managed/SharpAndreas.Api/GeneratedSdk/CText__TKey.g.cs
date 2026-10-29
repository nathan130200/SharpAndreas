// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CText__TKey : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CText__TKey(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("data")]
    public tGXT_VERSION_2_TKEY_item? @Data { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new tGXT_VERSION_2_TKEY_item(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("size")]
    public short @Size { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    public bool @read(uint @TKEYblockSize,_iobuf? @file,NativePointer<int> @pFileOffset,bool @skipReading) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4059 >(4059)(Pointer,@TKEYblockSize,@file?.Pointer ?? IntPtr.Zero,@pFileOffset.Pointer,(@skipReading ? 1 : 0)); return __sdkResult != 0; }
    public void @patchOffsets(int @PosOffsetMovement) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4060 >(4060)(Pointer,@PosOffsetMovement); }
    public tGXT_VERSION_2_TKEY_item? @bsearch(uint @key,tGXT_VERSION_2_TKEY_item? @pData,short @firstIndex,short @lastIndex) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4061 >(4061)(Pointer,@key,@pData?.Pointer ?? IntPtr.Zero,@firstIndex,@lastIndex); return __sdkResult == IntPtr.Zero ? null : new tGXT_VERSION_2_TKEY_item(__sdkResult); }
    public NativePointer<sbyte> @GetTextByLabel(NativePointer<sbyte> @keyName,NativePointer<bool> @bFound) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4062 >(4062)(Pointer,@keyName.Pointer,@bFound.Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4063 >(4063)(Pointer); }
}
