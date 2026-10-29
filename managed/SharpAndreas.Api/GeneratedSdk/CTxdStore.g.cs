// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTxdStore : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CTxdStore(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("ms_pTxdPool")]
    public static CPool_TxdDef__194d228ac2? @TxdPool { get => SdkMemory.Read<IntPtr>(new IntPtr(0xC8800C)) == IntPtr.Zero ? null : new CPool_TxdDef__194d228ac2(SdkMemory.Read<IntPtr>(new IntPtr(0xC8800C))); set { SdkMemory.Write(new IntPtr(0xC8800C),value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("ms_pStoredTxd")]
    public static RwTexDictionary? @StoredTxd { get => SdkMemory.Read<IntPtr>(SdkBindings.Address(4664)) == IntPtr.Zero ? null : new RwTexDictionary(SdkMemory.Read<IntPtr>(SdkBindings.Address(4664))); }
    public static void @PushCurrentTxd() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4264 >(4264)(); }
    public static void @PopCurrentTxd() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4265 >(4265)(); }
    public static int @FindTxdSlot(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4266 >(4266)(@name.Pointer); return __sdkResult; }
    public static int @FindTxdSlot(uint @hash) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4267 >(4267)(@hash); return __sdkResult; }
    public static bool @StartLoadTxd(int @index,RwStream? @stream) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4268 >(4268)(@index,@stream?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @Create(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4269 >(4269)(@index); }
    public static void @SetCurrentTxd(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4270 >(4270)(@index); }
    public static TxdDef? @AddRef(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4271 >(4271)(@index); return __sdkResult == IntPtr.Zero ? null : new TxdDef(__sdkResult); }
    public static void @RemoveRef(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4272 >(4272)(@index); }
    public static TxdDef? @RemoveRefWithoutDelete(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4273 >(4273)(@index); return __sdkResult == IntPtr.Zero ? null : new TxdDef(__sdkResult); }
    public static uint @GetNumRefs(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4274 >(4274)(@index); return __sdkResult; }
    public static int @AddTxdSlot(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4275 >(4275)(@name.Pointer); return __sdkResult; }
    public static void @RemoveTxdSlot(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4276 >(4276)(@index); }
    public static bool @LoadTxd(int @index,RwStream? @stream) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4277 >(4277)(@index,@stream?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static bool @FinishLoadTxd(int @index,RwStream? @stream) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4278 >(4278)(@index,@stream?.Pointer ?? IntPtr.Zero); return __sdkResult != 0; }
    public static void @RemoveTxd(int @index) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4279 >(4279)(@index); }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4280 >(4280)(); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4281 >(4281)(); }
    public static void @GameShutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4282 >(4282)(); }
    public static bool @LoadTxd(int @index,NativePointer<sbyte> @filename) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4283 >(4283)(@index,@filename.Pointer); return __sdkResult != 0; }
}
