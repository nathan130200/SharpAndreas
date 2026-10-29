// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CSpecialPlateHandler : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=244;
    public CSpecialPlateHandler(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_plateTextEntries")]
    public NativeObjectArray<tCarGenPlateText> @PlateTextEntries { get => new NativeObjectArray<tCarGenPlateText>(Pointer+0,15,16); }
    [NativeMember("m_nCount")]
    public uint @Count { get => SdkMemory.Read<uint >(Pointer+240); set { SdkMemory.Write(Pointer+240,value); } }
    public void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3789 >(3789)(Pointer); }
    public int @Find(int @carGenId,NativePointer<sbyte> @outText) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3790 >(3790)(Pointer,@carGenId,@outText.Pointer); return __sdkResult; }
    public void @Add(int @carGenId,NativePointer<sbyte> @plateText) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3791 >(3791)(Pointer,@carGenId,@plateText.Pointer); }
    public void @Remove(int @plateTextId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3792 >(3792)(Pointer,@plateTextId); }
}
