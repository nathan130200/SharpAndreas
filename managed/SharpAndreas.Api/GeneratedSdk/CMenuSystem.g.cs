// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMenuSystem : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CMenuSystem(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("MenuInUse")]
    public static NativePointer<bool> @MenuInUse { get => new NativePointer<bool>(new IntPtr(0xBA82E0)); }
    [NativeMember("CurrentMenuInUse")]
    public static byte @CurrentMenuInUse { get => SdkMemory.Read<byte >(new IntPtr(0xBA82E2)); set { SdkMemory.Write(new IntPtr(0xBA82E2),value); } }
    [NativeMember("num_menus_in_use")]
    public static byte @CountMenusInUse { get => SdkMemory.Read<byte >(new IntPtr(0xBA82E3)); set { SdkMemory.Write(new IntPtr(0xBA82E3),value); } }
    public static void @ActivateItems(byte @panelId,bool @item1,bool @item2,bool @item3,bool @item4,bool @item5,bool @item6,bool @item7,bool @item8,bool @item9,bool @item10,bool @item11,bool @item12) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3130 >(3130)(@panelId,(@item1 ? 1 : 0),(@item2 ? 1 : 0),(@item3 ? 1 : 0),(@item4 ? 1 : 0),(@item5 ? 1 : 0),(@item6 ? 1 : 0),(@item7 ? 1 : 0),(@item8 ? 1 : 0),(@item9 ? 1 : 0),(@item10 ? 1 : 0),(@item11 ? 1 : 0),(@item12 ? 1 : 0)); }
    public static void @ActivateOneItem(byte @panelId,byte @rowId,bool @enable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3131 >(3131)(@panelId,@rowId,(@enable ? 1 : 0)); }
    public static byte @CreateNewMenu(eMenuType @type,NativePointer<sbyte> @pTitle,float @posX,float @posY,float @width,sbyte @columns,bool @interactive,bool @background,eFontAlignment @alignment) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3132 >(3132)((int)@type,@pTitle.Pointer,@posX,@posY,@width,@columns,(@interactive ? 1 : 0),(@background ? 1 : 0),(int)@alignment); return __sdkResult; }
    public static sbyte @CheckForAccept(byte @panelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3133 >(3133)(@panelId); return __sdkResult; }
    public static sbyte @CheckForSelected(byte @panelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3134 >(3134)(@panelId); return __sdkResult; }
    public static void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3135 >(3135)(); }
    public static void @Process(byte @panelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3136 >(3136)(@panelId); }
    public static tMenuPanel? @InputStandardMenu(byte @panelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3137 >(3137)(@panelId); return __sdkResult == IntPtr.Zero ? null : new tMenuPanel(__sdkResult); }
    public static tMenuPanel? @InputGridMenu(byte @panelId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3138 >(3138)(@panelId); return __sdkResult == IntPtr.Zero ? null : new tMenuPanel(__sdkResult); }
    public static void @DisplayStandardMenu(byte @panelId,bool @bBrightFont) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3139 >(3139)(@panelId,(@bBrightFont ? 1 : 0)); }
    public static void @DisplayGridMenu(byte @panelId,bool @bBrightFont) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3140 >(3140)(@panelId,(@bBrightFont ? 1 : 0)); }
    public static void @HighlightOneItem(byte @panelId,byte @itemId,bool @bHighlight) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3141 >(3141)(@panelId,@itemId,(@bHighlight ? 1 : 0)); }
    public static NativePointer<IntPtr> @InsertMenuA(byte @panelId,byte @columnId,NativePointer<sbyte> @pTitle,NativePointer<sbyte> @str1,NativePointer<sbyte> @str2,NativePointer<sbyte> @str3,NativePointer<sbyte> @str4,NativePointer<sbyte> @str5,NativePointer<sbyte> @str6,NativePointer<sbyte> @str7,NativePointer<sbyte> @str8,NativePointer<sbyte> @str9,NativePointer<sbyte> @str10,NativePointer<sbyte> @str11,NativePointer<sbyte> @str12) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3142 >(3142)(@panelId,@columnId,@pTitle.Pointer,@str1.Pointer,@str2.Pointer,@str3.Pointer,@str4.Pointer,@str5.Pointer,@str6.Pointer,@str7.Pointer,@str8.Pointer,@str9.Pointer,@str10.Pointer,@str11.Pointer,@str12.Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public static tMenuPanel? @InsertOneMenuItem(byte @panelId,byte @columnId,byte @rowId,NativePointer<sbyte> @str) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3143 >(3143)(@panelId,@columnId,@rowId,@str.Pointer); return __sdkResult == IntPtr.Zero ? null : new tMenuPanel(__sdkResult); }
    public static tMenuPanel? @InsertOneMenuItemWithNumber(byte @panelId,byte @columnId,byte @rowId,NativePointer<sbyte> @str,int @number1,int @number2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3144 >(3144)(@panelId,@columnId,@rowId,@str.Pointer,@number1,@number2); return __sdkResult == IntPtr.Zero ? null : new tMenuPanel(__sdkResult); }
    public static void @SetActiveMenuItem(byte @panelId,sbyte @rowId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3145 >(3145)(@panelId,@rowId); }
    public static void @SetColumnHeader(byte @panelId,byte @columnId,NativePointer<sbyte> @str) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3146 >(3146)(@panelId,@columnId,@str.Pointer); }
    public static void @SetColumnOrientation(byte @panelId,byte @columnId,eFontAlignment @alignment) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3147 >(3147)(@panelId,@columnId,(int)@alignment); }
    public static void @SetColumnWidth(byte @panelId,byte @columnId,ushort @width) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3148 >(3148)(@panelId,@columnId,@width); }
    public static void @SetDPadInput(byte @panelId,bool @bEnable) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3149 >(3149)(@panelId,(@bEnable ? 1 : 0)); }
    public static void @SetHeaderOrientation(byte @panelId,byte @columnId,eFontAlignment @alignment) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3150 >(3150)(@panelId,@columnId,(int)@alignment); }
    public static void @SwitchOffMenu(byte @panelId) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3151 >(3151)(@panelId); }
}
