// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRoadBlocks : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CRoadBlocks(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aScriptRoadBlocks")]
    public static NativeObjectArray<tScriptRoadBlocks> @ScriptRoadBlocks { get => new NativeObjectArray<tScriptRoadBlocks>(new IntPtr(0xA43AB8),16,28); }
    [NativeMember("roadbloxDat")]
    public static NativeObjectArray<tRoadbloxDat> @RoadbloxDat { get => new NativeObjectArray<tRoadbloxDat>(new IntPtr(0xA435A0),325,4); }
    [NativeMember("roadbloxFlags")]
    public static uint @RoadbloxFlags { get => SdkMemory.Read<uint >(new IntPtr(0xA43438)); set { SdkMemory.Write(new IntPtr(0xA43438),value); } }
    [NativeMember("roadbloxDatSize")]
    public static uint @RoadbloxDatSize { get => SdkMemory.Read<uint >(new IntPtr(0xA43580)); set { SdkMemory.Write(new IntPtr(0xA43580),value); } }
    public static void @RegisterScriptRoadBlock(CVector? @cornerA,CVector? @cornerB,byte @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3604 >(3604)(@cornerA?.Pointer ?? IntPtr.Zero,@cornerB?.Pointer ?? IntPtr.Zero,@type); }
    public static void @ClearScriptRoadBlocks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3605 >(3605)(); }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3606 >(3606)(); }
    public static void @GenerateRoadBlockCopsForCar(CVehicle? @car,int @pedsPositionsType,byte @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3607 >(3607)(@car?.Pointer ?? IntPtr.Zero,@pedsPositionsType,@type); }
    public static void @CreateRoadBlockBetween2Points(CVector? @a,CVector? @b,byte @type) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3608 >(3608)(@a?.Pointer ?? IntPtr.Zero,@b?.Pointer ?? IntPtr.Zero,@type); }
    public static void @GenerateRoadBlocks() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3609 >(3609)(); }
}
