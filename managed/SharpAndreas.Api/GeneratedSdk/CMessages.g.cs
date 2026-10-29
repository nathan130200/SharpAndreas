// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMessages : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CMessages(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("PreviousBriefs")]
    public static NativeObjectArray<tPreviousBrief> @PreviousBriefs { get => new NativeObjectArray<tPreviousBrief>(new IntPtr(0xC1A570),20,32); }
    [NativeMember("BriefMessages")]
    public static NativeObjectArray<tMessage> @BriefMessages { get => new NativeObjectArray<tMessage>(new IntPtr(0xC1A7F0),8,48); }
    [NativeMember("BIGMessages")]
    public static NativeObjectArray<tBigMessage> @BIGMessages { get => new NativeObjectArray<tBigMessage>(new IntPtr(0xC1A970),7,192); }
    public static uint @GetStringLength(NativePointer<sbyte> @text) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3152 >(3152)(@text.Pointer); return __sdkResult; }
    public static void @StringCopy(NativePointer<sbyte> @dest,NativePointer<sbyte> @src,ushort @len) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3153 >(3153)(@dest.Pointer,@src.Pointer,@len); }
    public static byte @StringCompare(NativePointer<sbyte> @str1,NativePointer<sbyte> @str2,ushort @len) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3154 >(3154)(@str1.Pointer,@str2.Pointer,@len); return __sdkResult; }
    public static void @CutString(int @count,NativePointer<sbyte> @str,NativePointer<IntPtr> @dest) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3155 >(3155)(@count,@str.Pointer,@dest.Pointer); }
    public static void @ClearMessages(bool @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3156 >(3156)((@flag ? 1 : 0)); }
    public static void @ClearSmallMessagesOnly() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3157 >(3157)(); }
    public static void @AddToPreviousBriefArray(NativePointer<sbyte> @text,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6,NativePointer<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3158 >(3158)(@text.Pointer,@n1,@n2,@n3,@n4,@n5,@n6,@string.Pointer); }
    public static void @ClearPreviousBriefArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3159 >(3159)(); }
    public static void @InsertNumberInString(NativePointer<sbyte> @src,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6,NativePointer<sbyte> @dst) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3160 >(3160)(@src.Pointer,@n1,@n2,@n3,@n4,@n5,@n6,@dst.Pointer); }
    public static void @InsertStringInString(NativePointer<sbyte> @text,NativePointer<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3161 >(3161)(@text.Pointer,@string.Pointer); }
    public static void @InsertPlayerControlKeysInString(NativePointer<sbyte> @string) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3162 >(3162)(@string.Pointer); }
    public static void @AddMessageWithNumber(NativePointer<sbyte> @text,uint @time,ushort @flag,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6,bool @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3163 >(3163)(@text.Pointer,@time,@flag,@n1,@n2,@n3,@n4,@n5,@n6,(@bPreviousBrief ? 1 : 0)); }
    public static void @AddMessageJumpQWithNumber(NativePointer<sbyte> @text,uint @time,ushort @flag,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6,bool @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3164 >(3164)(@text.Pointer,@time,@flag,@n1,@n2,@n3,@n4,@n5,@n6,(@bPreviousBrief ? 1 : 0)); }
    public static void @AddBigMessageWithNumber(NativePointer<sbyte> @text,uint @time,ushort @style,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3165 >(3165)(@text.Pointer,@time,@style,@n1,@n2,@n3,@n4,@n5,@n6); }
    public static void @AddBigMessageWithNumberQ(NativePointer<sbyte> @text,uint @time,ushort @style,int @n1,int @n2,int @n3,int @n4,int @n5,int @n6) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3166 >(3166)(@text.Pointer,@time,@style,@n1,@n2,@n3,@n4,@n5,@n6); }
    public static void @AddMessageWithString(NativePointer<sbyte> @text,uint @time,ushort @flag,NativePointer<sbyte> @string,sbyte @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3167 >(3167)(@text.Pointer,@time,@flag,@string.Pointer,@bPreviousBrief); }
    public static void @AddMessageJumpQWithString(NativePointer<sbyte> @text,uint @time,ushort @flag,NativePointer<sbyte> @string,sbyte @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3168 >(3168)(@text.Pointer,@time,@flag,@string.Pointer,@bPreviousBrief); }
    public static void @ClearThisPrint(NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3169 >(3169)(@text.Pointer); }
    public static void @ClearThisBigPrint(NativePointer<sbyte> @text) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3170 >(3170)(@text.Pointer); }
    public static void @ClearThisPrintBigNow(ushort @style) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3171 >(3171)(@style); }
    public static void @Init(bool @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3172 >(3172)((@flag ? 1 : 0)); }
    public static void @ClearAllMessagesDisplayedByGame() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3173 >(3173)(); }
    public static void @Process() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3174 >(3174)(); }
    public static void @Display(bool @flag) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3175 >(3175)((@flag ? 1 : 0)); }
    public static void @AddMessage(NativePointer<sbyte> @text,uint @time,ushort @flag,bool @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3176 >(3176)(@text.Pointer,@time,@flag,(@bPreviousBrief ? 1 : 0)); }
    public static void @AddMessageJumpQ(NativePointer<sbyte> @text,uint @time,ushort @flag,bool @bPreviousBrief) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3177 >(3177)(@text.Pointer,@time,@flag,(@bPreviousBrief ? 1 : 0)); }
    public static void @AddBigMessage(NativePointer<sbyte> @text,uint @time,ushort @style) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3178 >(3178)(@text.Pointer,@time,@style); }
    public static void @AddBigMessageQ(NativePointer<sbyte> @text,uint @time,ushort @style) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3179 >(3179)(@text.Pointer,@time,@style); }
}
