// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class RsGlobalType : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=60;
    public RsGlobalType(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("appName")]
    public NativePointer<sbyte> @AppName { get => new NativePointer<sbyte>(SdkMemory.Read<IntPtr>(Pointer+0)); }
    [NativeMember("maximumWidth")]
    public int @MaximumWidth { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("maximumHeight")]
    public int @MaximumHeight { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("maxFPS")]
    public int @MaxFPS { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("quit")]
    public int @Quit { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("ps")]
    public psGlobalType? @Ps { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new psGlobalType(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("keyboard")]
    public RsInputDevice @Keyboard { get => new RsInputDevice(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,12); } }
    [NativeMember("mouse")]
    public RsInputDevice @Mouse { get => new RsInputDevice(Pointer+36); set { SdkMemory.Copy(value.Pointer,Pointer+36,12); } }
    [NativeMember("pad")]
    public RsInputDevice @Pad { get => new RsInputDevice(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
}
