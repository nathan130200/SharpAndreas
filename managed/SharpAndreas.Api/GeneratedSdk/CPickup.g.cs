// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPickup : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=32;
    public CPickup(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_fRevenueValue")]
    public float @RevenueValue { get => SdkMemory.Read<float >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("m_pObject")]
    public CObject? @Object { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CObject(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nAmmo")]
    public uint @Ammo { get => SdkMemory.Read<uint >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nRegenerationTime")]
    public uint @RegenerationTime { get => SdkMemory.Read<uint >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_vecPos")]
    public CompressedVector @Position { get => new CompressedVector(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,6); } }
    [NativeMember("m_nMoneyPerDay")]
    public ushort @MoneyPerDay { get => SdkMemory.Read<ushort >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("m_nModelIndex")]
    public short @ModelIndex { get => SdkMemory.Read<short >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nReferenceIndex")]
    public short @ReferenceIndex { get => SdkMemory.Read<short >(Pointer+26); set { SdkMemory.Write(Pointer+26,value); } }
    [NativeMember("m_nPickupType")]
    public byte @PickupType { get => SdkMemory.Read<byte >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("m_nFlags")]
    public CPickup___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CPickup_h_59_5__4f62c88df3 @Flags { get => new CPickup___unnamed__at_D__plugin_sdk_plugin_sa_game_sa_CPickup_h_59_5__4f62c88df3(Pointer+29); set { SdkMemory.Copy(value.Pointer,Pointer+29,1); } }
    public void @SetPosn(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3314 >(3314)(Pointer,@x,@y,@z); }
    public CVector @GetPosn() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D3315 >(3315)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public float @GetXCoord() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3316 >(3316)(Pointer); return __sdkResult; }
    public float @GetYCoord() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3317 >(3317)(Pointer); return __sdkResult; }
    public float @GetZCoord() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3318 >(3318)(Pointer); return __sdkResult; }
    public void @SetXCoord(float @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3319 >(3319)(Pointer,@coord); }
    public void @SetYCoord(float @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3320 >(3320)(Pointer,@coord); }
    public void @SetZCoord(float @coord) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3321 >(3321)(Pointer,@coord); }
    public void @ExtractAmmoFromPickup(CPlayerPed? @playerPed) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3322 >(3322)(Pointer,@playerPed?.Pointer ?? IntPtr.Zero); }
    public bool @IsVisible() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3323 >(3323)(Pointer); return __sdkResult != 0; }
    public void @GetRidOfObjects() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3324 >(3324)(Pointer); }
    public bool @PickUpShouldBeInvisible() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3325 >(3325)(Pointer); return __sdkResult != 0; }
    public void @Remove() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3326 >(3326)(Pointer); }
    public void @GiveUsAPickUpObject(NativePointer<IntPtr> @pObject,int @objectPoolSlotIndex) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3327 >(3327)(Pointer,@pObject.Pointer,@objectPoolSlotIndex); }
    public bool @Update(CPlayerPed? @playerPed,CVehicle? @vehicle,int @playerId) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3328 >(3328)(Pointer,@playerPed?.Pointer ?? IntPtr.Zero,@vehicle?.Pointer ?? IntPtr.Zero,@playerId); return __sdkResult != 0; }
    public void @ProcessGunShot(CVector? @origin,CVector? @target) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3329 >(3329)(Pointer,@origin?.Pointer ?? IntPtr.Zero,@target?.Pointer ?? IntPtr.Zero); }
    public static void @FindTextIndexForString(NativePointer<sbyte> @message) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3330 >(3330)(@message.Pointer); }
    public static NativePointer<sbyte> @FindStringForTextIndex(int @index) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D3331 >(3331)(@index); return new NativePointer<sbyte>(__sdkResult); }
}
