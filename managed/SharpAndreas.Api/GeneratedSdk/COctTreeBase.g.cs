// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class COctTreeBase : COctTree
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public COctTreeBase(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("numBranches")]
    public uint @CountBranches { get => SdkMemory.Read<uint >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("hasTransparentPixels")]
    public int @HasTransparentPixels { get => SdkMemory.Read<int >(Pointer+44); set { SdkMemory.Write(Pointer+44,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3227 >(3227)(Pointer); }
    public void @Init(int @numBranches) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3228 >(3228)(Pointer,@numBranches); }
    public bool @Insert(byte @colorRed,byte @colorGreen,byte @colorBlue) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3229 >(3229)(Pointer,@colorRed,@colorGreen,@colorBlue); return __sdkResult != 0; }
    public void @ReduceBranches(int @newBranchesCount) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3230 >(3230)(Pointer,@newBranchesCount); }
}
