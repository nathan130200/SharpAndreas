// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RsInputDevice : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=12;
    public RsInputDevice(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("inputDeviceType")]
    public RsInputDeviceType @InputDeviceType { get => SdkMemory.Read<RsInputDeviceType >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("used")]
    public int @Used { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("inputEventHandler")]
    public NativeFunctionPointer<Callback_24de34bdf65c> @InputEventHandler { get => new NativeFunctionPointer<Callback_24de34bdf65c>(SdkMemory.Read<IntPtr>(Pointer+8)); set { SdkMemory.Write(Pointer+8,value.Pointer); } }
}
