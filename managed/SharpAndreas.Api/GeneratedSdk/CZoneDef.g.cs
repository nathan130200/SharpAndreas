// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CZoneDef : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=16;
    public CZoneDef(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x1")]
    public short @X1 { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y1")]
    public short @Y1 { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("x2")]
    public short @X2 { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("y2")]
    public short @Y2 { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("x3")]
    public short @X3 { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("y3")]
    public short @Y3 { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("z1")]
    public short @Z1 { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("z2")]
    public short @Z2 { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    public void @Init(CVector @center,float @_x1,float @_y1,float @_z1,float @_x2,float @_y2,float @_z2) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2323 >(2323)(Pointer,@center.Pointer,@_x1,@_y1,@_z1,@_x2,@_y2,@_z2); }
    public bool @IsPointWithin(CVector @point) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2324 >(2324)(Pointer,@point.Pointer); return __sdkResult != 0; }
}
