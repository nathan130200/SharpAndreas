// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTaskComplexKillPedOnFoot : CTaskComplex
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=56;
    public CTaskComplexKillPedOnFoot(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_nFlags")]
    public byte @Flags { get => SdkMemory.Read<byte >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("m_pTarget")]
    public CPed? @Target { get => SdkMemory.Read<IntPtr>(Pointer+16) == IntPtr.Zero ? null : new CPed(SdkMemory.Read<IntPtr>(Pointer+16)); set { SdkMemory.Write(Pointer+16,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("m_nAttackFlags")]
    public uint @AttackFlags { get => SdkMemory.Read<uint >(Pointer+20); set { SdkMemory.Write(Pointer+20,value); } }
    [NativeMember("m_nActionDelay")]
    public uint @ActionDelay { get => SdkMemory.Read<uint >(Pointer+24); set { SdkMemory.Write(Pointer+24,value); } }
    [NativeMember("m_nActionChance")]
    public uint @ActionChance { get => SdkMemory.Read<uint >(Pointer+28); set { SdkMemory.Write(Pointer+28,value); } }
    [NativeMember("field_20")]
    public sbyte @Field20 { get => SdkMemory.Read<sbyte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("m_nLaunchTime")]
    public uint @LaunchTime { get => SdkMemory.Read<uint >(Pointer+36); set { SdkMemory.Write(Pointer+36,value); } }
    [NativeMember("m_nTime")]
    public int @Time { get => SdkMemory.Read<int >(Pointer+40); set { SdkMemory.Write(Pointer+40,value); } }
    [NativeMember("m_taskTimer")]
    public CTaskTimer @TaskTimer { get => new CTaskTimer(Pointer+44); set { SdkMemory.Copy(value.Pointer,Pointer+44,12); } }
    public void @InitializeAt(CPed? @target,int @time,int @specFlags,int @delay,int @chance,sbyte @a7) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4018 >(4018)(Pointer,@target?.Pointer ?? IntPtr.Zero,@time,@specFlags,@delay,@chance,@a7); }
}
