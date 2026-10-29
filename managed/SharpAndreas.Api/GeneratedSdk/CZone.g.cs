// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CZone : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=48;
    public CZone(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_szLabel")]
    public NativeArray<sbyte> @Label { get => new NativeArray<sbyte>(Pointer+0,8); }
    [NativeMember("m_szTextKey")]
    public NativeArray<sbyte> @TextKey { get => new NativeArray<sbyte>(Pointer+8,8); }
    [NativeMember("m_fX1")]
    public short @X1 { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_fY1")]
    public short @Y1 { get => SdkMemory.Read<short >(Pointer+18); set { SdkMemory.Write(Pointer+18,value); } }
    [NativeMember("m_fZ1")]
    public short @Z1 { get => SdkMemory.Read<short >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_fX2")]
    public short @X2 { get => SdkMemory.Read<short >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_fY2")]
    public short @Y2 { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_fZ2")]
    public short @Z2 { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nZoneExtraIndexInfo")]
    public CZoneInfo @ZoneExtraIndexInfo { get => new CZoneInfo(Pointer+28); set { SdkMemory.Copy(value.Pointer,Pointer+28,17); } }
    [NativeMember("m_nType")]
    public byte @Type { get => SdkMemory.Read<byte >(Pointer+45); set { SdkMemory.Write(Pointer+45,value); } }
    [NativeMember("m_nLevel")]
    public byte @Level { get => SdkMemory.Read<byte >(Pointer+46); set { SdkMemory.Write(Pointer+46,value); } }
    public NativePointer<sbyte> @GetTranslatedName() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2788 >(2788)(Pointer); return new NativePointer<sbyte>(__sdkResult); }
}
