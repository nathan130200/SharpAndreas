// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tUsedObject : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public tUsedObject(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("szModelName")]
    public NativeArray<sbyte> @ModelName { get => new NativeArray<sbyte>(Pointer+0,24); }
    [NativeMember("dwModelIndex")]
    public int @ModelIndex { get => SdkMemory.Read<int >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
}
