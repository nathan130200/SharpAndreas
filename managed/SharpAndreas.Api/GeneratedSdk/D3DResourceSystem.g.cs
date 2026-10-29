// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class D3DResourceSystem : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public D3DResourceSystem(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("UseD3DResourceBuffering")]
    public static bool @UseD3DResourceBuffering { get => SdkMemory.Read<bool >(new IntPtr(0x8D6084)); set { SdkMemory.Write(new IntPtr(0x8D6084),value); } }
    [NativeMember("FreeTextureBufferIndex")]
    public static uint @FreeTextureBufferIndex { get => SdkMemory.Read<uint >(new IntPtr(0xC87C60)); set { SdkMemory.Write(new IntPtr(0xC87C60),value); } }
    [NativeMember("TextureBuffer")]
    public static D3DTextureBuffer @TextureBuffer { get => new D3DTextureBuffer(new IntPtr(0xC87C68)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC87C68),28); } }
    [NativeMember("IndexDataBuffer")]
    public static D3DIndexDataBuffer @IndexDataBuffer { get => new D3DIndexDataBuffer(new IntPtr(0xC87E48)); set { SdkMemory.Copy(value.Pointer,new IntPtr(0xC87E48),24); } }
    public static void @CancelBuffering() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4513 >(4513)(); }
    public static uint @GetTotalIndexDataSize() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4514 >(4514)(); return __sdkResult; }
    public static uint @GetTotalPixelsSize() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4515 >(4515)(); return __sdkResult; }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4516 >(4516)(); }
    public static void @SetUseD3DResourceBuffering(bool @bUse) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4517 >(4517)((@bUse ? 1 : 0)); }
    public static void @Shutdown() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4518 >(4518)(); }
    public static void @TidyUpD3DIndexBuffers(uint @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4519 >(4519)(@count); }
    public static void @TidyUpD3DTextures(uint @count) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4520 >(4520)(@count); }
    public static int @CreateIndexBuffer(uint @numIndices,uint @format,NativePointer<IntPtr> @ppIndexBuffer) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4521 >(4521)(@numIndices,@format,@ppIndexBuffer.Pointer); return __sdkResult; }
    public static int @CreateTexture(int @width,int @height,uint @format,NativePointer<IntPtr> @ppTexture) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4522 >(4522)(@width,@height,@format,@ppTexture.Pointer); return __sdkResult; }
    public static void @DestroyIndexBuffer(NativePointer<IntPtr> @pIndexBuffer) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4523 >(4523)(@pIndexBuffer.Pointer); }
    public static void @DestroyTexture(NativePointer<IntPtr> @pTexture) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4524 >(4524)(@pTexture.Pointer); }
}
