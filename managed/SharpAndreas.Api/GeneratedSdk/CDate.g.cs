// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CDate : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CDate(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("seconds")]
    public int @Seconds { get => SdkMemory.Read<int >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("minutes")]
    public int @Minutes { get => SdkMemory.Read<int >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("hours")]
    public int @Hours { get => SdkMemory.Read<int >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("day")]
    public int @Day { get => SdkMemory.Read<int >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("month")]
    public int @Month { get => SdkMemory.Read<int >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("year")]
    public int @Year { get => SdkMemory.Read<int >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2480 >(2480)(Pointer); }
    public bool @Operator_operator_(CDate @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2481 >(2481)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator__(CDate @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2482 >(2482)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator___1c518b48(CDate @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2483 >(2483)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public void @PopulateDateFields(NativePointer<sbyte> @seconds,NativePointer<sbyte> @minutes,NativePointer<sbyte> @hours,NativePointer<sbyte> @day,NativePointer<sbyte> @month,short @year) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2484 >(2484)(Pointer,@seconds.Pointer,@minutes.Pointer,@hours.Pointer,@day.Pointer,@month.Pointer,@year); }
}
