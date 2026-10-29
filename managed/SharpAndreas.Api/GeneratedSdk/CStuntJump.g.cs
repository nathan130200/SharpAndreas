// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CStuntJump : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=68;
    public CStuntJump(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("start")]
    public CBoundingBox @Start { get => new CBoundingBox(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,24); } }
    [NativeMember("end")]
    public CBoundingBox @End { get => new CBoundingBox(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,24); } }
    [NativeMember("camera")]
    public CVector @Camera { get => new CVector(Pointer+48); set { SdkMemory.Copy(value.Pointer,Pointer+48,12); } }
    [NativeMember("reward")]
    public int @Reward { get => SdkMemory.Read<int >(Pointer+60); set { SdkMemory.Write(Pointer+60,value); } }
    [NativeMember("done")]
    public bool @Done { get => SdkMemory.Read<bool >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("found")]
    public bool @Found { get => SdkMemory.Read<bool >(Pointer+65); set { SdkMemory.Write(Pointer+65,value); } }
}
