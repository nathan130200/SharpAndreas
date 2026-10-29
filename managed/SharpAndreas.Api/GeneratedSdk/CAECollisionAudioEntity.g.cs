// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CAECollisionAudioEntity : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=6520;
    public CAECollisionAudioEntity(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("audio")]
    public CAEAudioEntity @Audio { get => new CAEAudioEntity(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,124); } }
    [NativeMember("field_7C")]
    public NativeArray<sbyte> @Field7C { get => new NativeArray<sbyte>(Pointer+124,388); }
    [NativeMember("field_200")]
    public ushort @Field200 { get => SdkMemory.Read<ushort >(Pointer+512); set { SdkMemory.Write(Pointer+512,value); } }
    [NativeMember("field_202")]
    public ushort @Field202 { get => SdkMemory.Read<ushort >(Pointer+514); set { SdkMemory.Write(Pointer+514,value); } }
    [NativeMember("field_204")]
    public uint @Field204 { get => SdkMemory.Read<uint >(Pointer+516); set { SdkMemory.Write(Pointer+516,value); } }
    [NativeMember("field_208")]
    public NativeObjectArray<tCollisionAudioEntry> @Field208 { get => new NativeObjectArray<tCollisionAudioEntry>(Pointer+520,300,20); }
}
