// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPedClothesDesc : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=120;
    public CPedClothesDesc(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_anModelKeys")]
    public NativeArray<uint> @ModelKeys { get => new NativeArray<uint>(Pointer+0,10); }
    [NativeMember("m_anTextureKeys")]
    public NativeArray<uint> @TextureKeys { get => new NativeArray<uint>(Pointer+40,18); }
    [NativeMember("m_fFatStat")]
    public float @FatStat { get => SdkMemory.Read<float >(Pointer+112); set { SdkMemory.Write(Pointer+112,value); } }
    [NativeMember("m_fMuscleStat")]
    public float @MuscleStat { get => SdkMemory.Read<float >(Pointer+116); set { SdkMemory.Write(Pointer+116,value); } }
    public void @Initialise() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1407 >(1407)(Pointer); }
    public void @SetModel(uint @modelid,int @eClothesModelPart) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1408 >(1408)(Pointer,@modelid,@eClothesModelPart); }
    public void @SetModel(NativePointer<sbyte> @model,int @eClothesModelPart) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1409 >(1409)(Pointer,@model.Pointer,@eClothesModelPart); }
    public bool @GetIsWearingBalaclava() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1410 >(1410)(Pointer); return __sdkResult != 0; }
    public bool @HasVisibleNewHairCut(int @arg1) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1411 >(1411)(Pointer,@arg1); return __sdkResult != 0; }
    public bool @HasVisibleTattoo() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D1412 >(1412)(Pointer); return __sdkResult != 0; }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1413 >(1413)(Pointer); }
    public void @SetTextureAndModel(uint @texture,uint @model,int @eClothesTexturePart) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1414 >(1414)(Pointer,@texture,@model,@eClothesTexturePart); }
    public void @SetTextureAndModel(NativePointer<sbyte> @texturename,NativePointer<sbyte> @modelname,int @eClothesTexturePart) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D1415 >(1415)(Pointer,@texturename.Pointer,@modelname.Pointer,@eClothesTexturePart); }
}
