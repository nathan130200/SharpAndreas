// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CText__TDat : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=8;
    public CText__TDat(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("data")]
    public NativePointer<sbyte> @Data { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("size")]
    public int @Size { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    public bool @read(uint @TABLblockSize,_iobuf? @file,NativePointer<int> @pFileOffset,bool @skipRead) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4056 >(4056)(Pointer,@TABLblockSize,@file?.Pointer ?? IntPtr.Zero,@pFileOffset.Pointer,(@skipRead ? 1 : 0)); return __sdkResult != 0; }
}
