// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CText__Tabl : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2404;
    public CText__Tabl(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("data")]
    public NativeObjectArray<CText__TablEntry> @Data { get => new NativeObjectArray<CText__TablEntry>(Pointer+0,200,12); }
    [NativeMember("size")]
    public short @Size { get => SdkMemory.Read<short >(Pointer+2400); set { SdkMemory.Write(Pointer+2400,value); } }
    [NativeMember("__pad")]
    public short @Pad { get => SdkMemory.Read<short >(Pointer+2402); set { SdkMemory.Write(Pointer+2402,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4057 >(4057)(Pointer); }
    public void @read(uint @TABLblockSize,_iobuf? @file,NativePointer<int> @pFileOffset,int @maxReadSize) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4058 >(4058)(Pointer,@TABLblockSize,@file?.Pointer ?? IntPtr.Zero,@pFileOffset.Pointer,@maxReadSize); }
}
