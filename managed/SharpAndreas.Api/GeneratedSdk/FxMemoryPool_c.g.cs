// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class FxMemoryPool_c : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public FxMemoryPool_c(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("data")]
    public NativePointer<sbyte> @Data { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value.Pointer); } }
    [NativeMember("size")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("position")]
    public uint @Position { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    public void @Optimise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4526 >(4526)(Pointer); }
}
