// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class D3DIndexDataBuffer : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public D3DIndexDataBuffer(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFormat")]
    public uint @Format { get => SdkMemory.Read<uint >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public int @Field4 { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nCapcacity")]
    public uint @Capcacity { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nNumDatasInBuffer")]
    public uint @CountDatasInBuffer { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_nSize")]
    public uint @Size { get => SdkMemory.Read<uint >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_apIndexData")]
    public NativePointer<IntPtr> @IndexData { get => new NativePointer<IntPtr>(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value.Pointer); } }
    public void @Clear() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4495 >(4495)(Pointer); }
    public void @Destroy() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4496 >(4496)(Pointer); }
    public uint @GetTotalDataSize() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4497 >(4497)(Pointer); return __sdkResult; }
    public void @Resize(uint @newCapacity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4498 >(4498)(Pointer,@newCapacity); }
    public void @Setup(uint @format,int @_f4,uint @capacity) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4499 >(4499)(Pointer,@format,@_f4,@capacity); }
    public NativePointer<IntPtr> @Pop() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4500 >(4500)(Pointer); return new NativePointer<IntPtr>(__sdkResult); }
    public NativePointer<IntPtr> @Pop(uint @indexCount) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4501 >(4501)(Pointer,@indexCount); return new NativePointer<IntPtr>(__sdkResult); }
    public bool @Push(NativePointer<IntPtr> @indexBuffer) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4502 >(4502)(Pointer,@indexBuffer.Pointer); return __sdkResult != 0; }
    public bool @PushWithoutIncreasingCounter(NativePointer<IntPtr> @indexBuffer) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4503 >(4503)(Pointer,@indexBuffer.Pointer); return __sdkResult != 0; }
}
