// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class psGlobalType : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public psGlobalType(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("window")]
    public HWND__? @Window { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new HWND__(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("instance")]
    public HINSTANCE__? @Instance { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new HINSTANCE__(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("fullScreen")]
    public int @FullScreen { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("lastMousePos")]
    public RwV2d @LastMousePosition { get => new RwV2d(Pointer+12); set { SdkMemory.Copy(value.Pointer,Pointer+12,8); } }
    [NativeMember("field_14")]
    public int @Field14 { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("diInterface")]
    public NativePointer<IntPtr> @DiInterface { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    [NativeMember("diMouse")]
    public NativePointer<IntPtr> @DiMouse { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+28)); set { SdkMemory.Write(Pointer+28,value.Pointer); } }
    [NativeMember("diDevice1")]
    public NativePointer<IntPtr> @DiDevice1 { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+32)); set { SdkMemory.Write(Pointer+32,value.Pointer); } }
    [NativeMember("diDevice2")]
    public NativePointer<IntPtr> @DiDevice2 { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+36)); set { SdkMemory.Write(Pointer+36,value.Pointer); } }
}
