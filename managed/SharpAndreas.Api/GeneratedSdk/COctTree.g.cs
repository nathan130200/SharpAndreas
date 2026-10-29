// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class COctTree : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public COctTree(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("level")]
    public uint @Level { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("lastStep")]
    public bool @LastStep { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("childrens")]
    public NativeArray<short> @Childrens { get => new NativeArray<short>(Pointer+10,8); }
    [NativeMember("redComponent")]
    public uint @RedComponent { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("greenComponent")]
    public uint @GreenComponent { get => SdkMemory.Read<uint >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("blueComponent")]
    public uint @BlueComponent { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("ms_bFailed")]
    public static bool @Failed { get => SdkMemory.Read<bool >(new IntPtr(0xBC12DC)); set { SdkMemory.Write(new IntPtr(0xBC12DC),value); } }
    [NativeMember("ms_level")]
    public static uint @LevelValue { get => SdkMemory.Read<uint >(new IntPtr(0xBC12E0)); set { SdkMemory.Write(new IntPtr(0xBC12E0),value); } }
    [NativeMember("ms_octTreePool")]
    public static CPool_COctTree__5e96da1ab6 @OctTreePool { get => new CPool_COctTree__5e96da1ab6(new IntPtr(0xBC12E4)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xBC12E4),-2); } }
    public bool @InsertTree(byte @colorRed,byte @colorGreen,byte @colorBlue) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3214 >(3214)(Pointer,@colorRed,@colorGreen,@colorBlue); return __sdkResult != 0; }
    public void @FillPalette(NativePointer<byte> @colors) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3215 >(3215)(Pointer,@colors.Pointer); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3216 >(3216)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3217 >(3217)(Pointer); }
    public uint @FindNearestColour(byte @colorRed,byte @colorGreen,byte @colorBlue) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3218 >(3218)(Pointer,@colorRed,@colorGreen,@colorBlue); return __sdkResult; }
    public void @InitPool(NativePointer<IntPtr> @data,int @dataSize) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3219 >(3219)(Pointer,@data.Pointer,@dataSize); }
    public uint @NoOfChildren() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3220 >(3220)(Pointer); return __sdkResult; }
    public void @ReduceTree() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3221 >(3221)(Pointer); }
    public void @RemoveChildren() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3222 >(3222)(Pointer); }
    public void @ShutdownPool() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3223 >(3223)(Pointer); }
    public void @empty() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3224 >(3224)(Pointer); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3225 >(3225)(@data.Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3226 >(3226)(@size); return new NativePointer<IntPtr>(__sdkResult); }
}
