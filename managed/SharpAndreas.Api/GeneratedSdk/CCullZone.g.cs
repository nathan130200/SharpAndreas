// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CCullZone : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=18;
    public CCullZone(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("zoneDef")]
    public CZoneDef @ZoneDef { get => new CZoneDef(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,16); } }
    [NativeMember("flags")]
    public eZoneAttributes @Flags { get => SdkMemory.Read<eZoneAttributes >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
}
