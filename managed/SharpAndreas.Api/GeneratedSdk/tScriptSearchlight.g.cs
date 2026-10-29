// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class tScriptSearchlight : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=124;
    public tScriptSearchlight(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("bUsed")]
    public sbyte @Used { get => SdkMemory.Read<sbyte >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_1")]
    public sbyte @Field1 { get => SdkMemory.Read<sbyte >(Pointer+1); set { SdkMemory.Write(Pointer+1,value); } }
    [NativeMember("bEnableShadow")]
    public sbyte @EnableShadow { get => SdkMemory.Read<sbyte >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("field_3")]
    public sbyte @Field3 { get => SdkMemory.Read<sbyte >(Pointer+3); set { SdkMemory.Write(Pointer+3,value); } }
    [NativeMember("wUniqueID")]
    public short @UniqueID { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_6")]
    public short @Field6 { get => SdkMemory.Read<short >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("position")]
    public RwV3d @Position { get => new RwV3d(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,12); } }
    [NativeMember("target")]
    public RwV3d @Target { get => new RwV3d(Pointer+20); set { SdkMemory.Copy(value.Pointer,Pointer+20,12); } }
    [NativeMember("targetRadius")]
    public float @TargetRadius { get => SdkMemory.Read<float >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("baseRadius")]
    public float @BaseRadius { get => SdkMemory.Read<float >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("pathCoord1")]
    public RwV3d @PathCoord1 { get => new RwV3d(Pointer+40); set { SdkMemory.Copy(value.Pointer,Pointer+40,12); } }
    [NativeMember("pathCoord2")]
    public RwV3d @PathCoord2 { get => new RwV3d(Pointer+52); set { SdkMemory.Copy(value.Pointer,Pointer+52,12); } }
    [NativeMember("pathSpeed")]
    public float @PathSpeed { get => SdkMemory.Read<float >(Pointer+64); set { SdkMemory.Write(Pointer+64,value); } }
    [NativeMember("attachedEntity")]
    public int @AttachedEntity { get => SdkMemory.Read<int >(Pointer+68); set { SdkMemory.Write(Pointer+68,value); } }
    [NativeMember("followingEntity")]
    public int @FollowingEntity { get => SdkMemory.Read<int >(Pointer+72); set { SdkMemory.Write(Pointer+72,value); } }
    [NativeMember("tower")]
    public int @Tower { get => SdkMemory.Read<int >(Pointer+76); set { SdkMemory.Write(Pointer+76,value); } }
    [NativeMember("housing")]
    public int @Housing { get => SdkMemory.Read<int >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("bulb")]
    public int @Bulb { get => SdkMemory.Read<int >(Pointer+84); set { SdkMemory.Write(Pointer+84,value); } }
    [NativeMember("targetSpot")]
    public RwV3d @TargetSpot { get => new RwV3d(Pointer+88); set { SdkMemory.Copy(value.Pointer,Pointer+88,12); } }
    [NativeMember("field_64")]
    public RwV3d @Field64 { get => new RwV3d(Pointer+100); set { SdkMemory.Copy(value.Pointer,Pointer+100,12); } }
    [NativeMember("field_70")]
    public RwV3d @Field70 { get => new RwV3d(Pointer+112); set { SdkMemory.Copy(value.Pointer,Pointer+112,12); } }
}
