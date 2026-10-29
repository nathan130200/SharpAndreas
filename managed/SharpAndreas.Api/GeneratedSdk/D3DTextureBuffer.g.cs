// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class D3DTextureBuffer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public D3DTextureBuffer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFormat")]
    public uint @Format { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_nWidth")]
    public uint @Width { get => SdkMemory.Read<uint >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nLevels")]
    public int @Levels { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nCapcacity")]
    public uint @Capcacity { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nNumTexturesInBuffer")]
    public uint @CountTexturesInBuffer { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_nSize")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_apTextures")]
    public NativePointer<IntPtr> @Textures { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+24)); set { SdkMemory.Write(Pointer+24,value.Pointer); } }
    public void @Clear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4504 >(4504)(Pointer); }
    public void @Destroy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4505 >(4505)(Pointer); }
    public uint @GetTotalDataSize() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4506 >(4506)(Pointer); return __sdkResult; }
    public void @Resize(uint @newCapacity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4507 >(4507)(Pointer,@newCapacity); }
    public void @Setup(uint @format,int @width,int @bOneLevel,uint @capacity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4508 >(4508)(Pointer,@format,@width,@bOneLevel,@capacity); }
    public NativePointer<IntPtr> @Pop() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4509 >(4509)(Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public NativePointer<IntPtr> @Pop(uint @format,int @width,int @height,int @bOneLevel) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4510 >(4510)(Pointer,@format,@width,@height,@bOneLevel); return new NativePointer<IntPtr>(__sdkResult); }
    public bool @Push(NativePointer<IntPtr> @texture) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4511 >(4511)(Pointer,@texture.Pointer); return __sdkResult != 0; }
    public bool @PushWithoutIncreasingCounter(NativePointer<IntPtr> @texture) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4512 >(4512)(Pointer,@texture.Pointer); return __sdkResult != 0; }
}
