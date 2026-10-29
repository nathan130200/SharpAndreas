// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class cHandlingDataMgr : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=50724;
    public cHandlingDataMgr(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("field_0")]
    public float @Field0 { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("field_4")]
    public float @Field4 { get => SdkMemory.Read<float >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("field_8")]
    public float @Field8 { get => SdkMemory.Read<float >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("field_C")]
    public float @FieldC { get => SdkMemory.Read<float >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("field_10")]
    public float @Field10 { get => SdkMemory.Read<float >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("m_aVehicleHandling")]
    public NativeObjectArray<tHandlingData> @VehicleHandling { get => new NativeObjectArray<tHandlingData>(Pointer+20,210,224); }
    [NativeMember("m_aBikeHandling")]
    public NativeObjectArray<tBikeHandlingData> @BikeHandling { get => new NativeObjectArray<tBikeHandlingData>(Pointer+47060,13,64); }
    [NativeMember("m_aFlyingHandling")]
    public NativeObjectArray<tFlyingHandlingData> @FlyingHandling { get => new NativeObjectArray<tFlyingHandlingData>(Pointer+47892,24,88); }
    [NativeMember("m_aBoatHandling")]
    public NativeObjectArray<tBoatHandlingData> @BoatHandling { get => new NativeObjectArray<tBoatHandlingData>(Pointer+50004,12,60); }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2929 >(2929)(Pointer); }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2930 >(2930)(Pointer); }
    public void @LoadHandlingData() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2931 >(2931)(Pointer); }
    public int @FindExactWord(NativePointer<sbyte> @line,NativePointer<sbyte> @nameTable,int @entrySize,int @entryCount) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2932 >(2932)(Pointer,@line.Pointer,@nameTable.Pointer,@entrySize,@entryCount); return __sdkResult; }
    public bool @IsNotRearDriveVehicle(byte @handlingId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2933 >(2933)(Pointer,@handlingId); return __sdkResult != 0; }
    public bool @IsNotFrontDriveVehicle(byte @handlingId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2934 >(2934)(Pointer,@handlingId); return __sdkResult != 0; }
    public int @GetHandlingId(NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2935 >(2935)(Pointer,@name.Pointer); return __sdkResult; }
    public void @ConvertDataToWorldUnits(tHandlingData? @handling) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2936 >(2936)(Pointer,@handling?.Pointer ?? IntPtr.Zero); }
    public void @ConvertDataToGameUnits(tHandlingData? @handling) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2937 >(2937)(Pointer,@handling?.Pointer ?? IntPtr.Zero); }
    public void @ConvertBikeDataToWorldUnits(tBikeHandlingData? @bikeHandling) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2938 >(2938)(Pointer,@bikeHandling?.Pointer ?? IntPtr.Zero); }
    public void @ConvertBikeDataToGameUnits(tBikeHandlingData? @bikeHandling) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D2939 >(2939)(Pointer,@bikeHandling?.Pointer ?? IntPtr.Zero); }
    public tFlyingHandlingData? @GetFlyingPointer(byte @handlingId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2940 >(2940)(Pointer,@handlingId); return __sdkResult == IntPtr.Zero ? null : new tFlyingHandlingData(__sdkResult); }
    public tBoatHandlingData? @GetBoatPointer(byte @handlingId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D2941 >(2941)(Pointer,@handlingId); return __sdkResult == IntPtr.Zero ? null : new tBoatHandlingData(__sdkResult); }
}
