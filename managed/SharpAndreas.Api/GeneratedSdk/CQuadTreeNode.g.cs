// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CQuadTreeNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=40;
    public CQuadTreeNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("rect")]
    public CRect @Rect { get => new CRect(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("itemList")]
    public CPtrListSingleLink @ItemList { get => new CPtrListSingleLink(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,4); } }
    [NativeMember("childrens")]
    public NativeArray<IntPtr> @Childrens { get => new NativeArray<IntPtr>(Pointer+20,4); }
    [NativeMember("level")]
    public uint @Level { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    public void @InitializeAt(CRect @rect,int @startLevel) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2237 >(2237)(Pointer,@rect.Pointer,@startLevel); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2238 >(2238)(Pointer); }
    public void @AddItem(NativePointer<IntPtr> @item,CRect @rect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2239 >(2239)(Pointer,@item.Pointer,@rect.Pointer); }
    public void @DeleteItem(NativePointer<IntPtr> @item) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2240 >(2240)(Pointer,@item.Pointer); }
    public void @DeleteItem(NativePointer<IntPtr> @item,CRect @rect) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2241 >(2241)(Pointer,@item.Pointer,@rect.Pointer); }
    public int @FindSector(CRect @rect) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2242 >(2242)(Pointer,@rect.Pointer); return __sdkResult; }
    public int @FindSector(CVector2D @posn) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2243 >(2243)(Pointer,@posn.Pointer); return __sdkResult; }
    public void @ForAllMatching(CRect @rect,NativeFunctionPointer<Callback_155a92b3593f> @callback) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2244 >(2244)(Pointer,@rect.Pointer,@callback.Pointer); }
    public void @ForAllMatching(CVector2D @posn,NativeFunctionPointer<Callback_e9ad1c61a9ce> @callback) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2245 >(2245)(Pointer,@posn.Pointer,@callback.Pointer); }
    public void @GetAll(CPtrListSingleLink @list) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2246 >(2246)(Pointer,@list.Pointer); }
    public void @GetAllMatching(CRect @rect,CPtrListSingleLink @list) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2247 >(2247)(Pointer,@rect.Pointer,@list.Pointer); }
    public void @GetAllMatching(CVector2D @posn,CPtrListSingleLink @list) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2248 >(2248)(Pointer,@posn.Pointer,@list.Pointer); }
    public bool @InSector(CRect @rect,int @sector) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2249 >(2249)(Pointer,@rect.Pointer,@sector); return __sdkResult != 0; }
    public void @InitPool() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2250 >(2250)(Pointer); }
    public static void @FreeNative(NativePointer<IntPtr> @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2251 >(2251)(@data.Pointer); }
    public static NativePointer<IntPtr> @AllocateNative(uint @size) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2252 >(2252)(@size); return new NativePointer<IntPtr>(__sdkResult); }
}
