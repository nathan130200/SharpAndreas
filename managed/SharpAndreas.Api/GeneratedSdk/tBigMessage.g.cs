// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tBigMessage : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=192;
    public tBigMessage(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_Current")]
    public tMessage @Current { get => new tMessage(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,48); } }
    [NativeMember("m_Stack")]
    public NativeObjectArray<tMessage> @Stack { get => new NativeObjectArray<tMessage>(Pointer+48,3,48); }
}
