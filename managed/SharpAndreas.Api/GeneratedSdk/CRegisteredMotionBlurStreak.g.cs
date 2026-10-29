// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CRegisteredMotionBlurStreak : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=84;
    public CRegisteredMotionBlurStreak(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nId")]
    public int @Id { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_color")]
    public CRGBA @Color { get => new CRGBA(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,4); } }
    [NativeMember("m_avecLeftPoints")]
    public NativeObjectArray<CVector> @LeftPoints { get => new NativeObjectArray<CVector>(Pointer+8,3,12); }
    [NativeMember("m_avecRightPoints")]
    public NativeObjectArray<CVector> @RightPoints { get => new NativeObjectArray<CVector>(Pointer+44,3,12); }
    [NativeMember("m_bExists")]
    public bool @Exists { get => SdkMemory.Read<bool >(Pointer+80); set { SdkMemory.Write(Pointer+80,value); } }
    [NativeMember("field_51")]
    public bool @Field51 { get => SdkMemory.Read<bool >(Pointer+81); set { SdkMemory.Write(Pointer+81,value); } }
    [NativeMember("field_52")]
    public sbyte @Field52 { get => SdkMemory.Read<sbyte >(Pointer+82); set { SdkMemory.Write(Pointer+82,value); } }
    [NativeMember("field_53")]
    public sbyte @Field53 { get => SdkMemory.Read<sbyte >(Pointer+83); set { SdkMemory.Write(Pointer+83,value); } }
    public void @Update() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3208 >(3208)(Pointer); }
    public void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3209 >(3209)(Pointer); }
}
