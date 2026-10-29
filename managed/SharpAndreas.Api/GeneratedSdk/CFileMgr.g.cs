// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CFileMgr : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CFileMgr(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_dirName")]
    public static NativePointer<sbyte> @DirectionName { get => new NativePointer<sbyte>(new IntPtr(0xB71A60)); }
    [NativeMember("ms_rootDirName")]
    public static NativePointer<sbyte> @RootDirectionName { get => new NativePointer<sbyte>(new IntPtr(0xB71AE0)); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2542 >(2542)(); }
    public static int @ChangeDir(NativePointer<sbyte> @path) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2543 >(2543)(@path.Pointer); return __sdkResult; }
    public static int @SetDir(NativePointer<sbyte> @path) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2544 >(2544)(@path.Pointer); return __sdkResult; }
    public static int @SetDirMyDocuments() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2545 >(2545)(); return __sdkResult; }
    public static int @LoadFile(NativePointer<sbyte> @path,NativePointer<byte> @buf,int @size,NativePointer<sbyte> @mode) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2546 >(2546)(@path.Pointer,@buf.Pointer,@size,@mode.Pointer); return __sdkResult; }
    public static int @OpenFile(NativePointer<sbyte> @path,NativePointer<sbyte> @mode) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2547 >(2547)(@path.Pointer,@mode.Pointer); return __sdkResult; }
    public static int @OpenFileForWriting(NativePointer<sbyte> @path) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2548 >(2548)(@path.Pointer); return __sdkResult; }
    public static int @OpenFileForAppending(NativePointer<sbyte> @path) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2549 >(2549)(@path.Pointer); return __sdkResult; }
    public static int @Read(int @file,NativePointer<sbyte> @buf,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2550 >(2550)(@file,@buf.Pointer,@size); return __sdkResult; }
    public static int @Write(int @file,NativePointer<sbyte> @buf,int @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2551 >(2551)(@file,@buf.Pointer,@size); return __sdkResult; }
    public static sbyte @Seek(int @file,int @offset,int @origin) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2552 >(2552)(@file,@offset,@origin); return __sdkResult; }
    public static sbyte @ReadLine(int @file,NativePointer<sbyte> @str,int @num) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2553 >(2553)(@file,@str.Pointer,@num); return __sdkResult; }
    public static int @CloseFile(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2554 >(2554)(@file); return __sdkResult; }
    public static int @GetFileLength(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2555 >(2555)(@file); return __sdkResult; }
    public static int @Tell(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2556 >(2556)(@file); return __sdkResult; }
    public static bool @GetErrorReadWrite(int @file) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2557 >(2557)(@file); return __sdkResult != 0; }
}
