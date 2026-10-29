// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAnimationStyleDescriptor : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CAnimationStyleDescriptor(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("groupName")]
    public NativeArray<sbyte> @GroupName { get => new NativeArray<sbyte>(Pointer+0,16); }
    [NativeMember("blockName")]
    public NativeArray<sbyte> @BlockName { get => new NativeArray<sbyte>(Pointer+16,16); }
    [NativeMember("field_20")]
    public int @Field20 { get => SdkMemory.Read<int >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("animsCount")]
    public int @AnimsCount { get => SdkMemory.Read<int >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("animNames")]
    public NativePointer<IntPtr> @AnimationNames { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+40)); set { SdkMemory.Write(Pointer+40,value.Pointer); } }
    [NativeMember("animDesc")]
    public NativePointer<IntPtr> @AnimationDesc { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+44)); set { SdkMemory.Write(Pointer+44,value.Pointer); } }
}
