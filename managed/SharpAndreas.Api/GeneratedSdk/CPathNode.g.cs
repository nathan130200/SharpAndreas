// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPathNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=28;
    public CPathNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("pNext")]
    public CPathNode? @Next { get => SdkMemory.Read<IntPtr>(Pointer+0) == IntPtr.Zero ? null : new CPathNode(SdkMemory.Read<IntPtr>(Pointer+0)); set { SdkMemory.Write(Pointer+0,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("pPrevious")]
    public CPathNode? @Previous { get => SdkMemory.Read<IntPtr>(Pointer+4) == IntPtr.Zero ? null : new CPathNode(SdkMemory.Read<IntPtr>(Pointer+4)); set { SdkMemory.Write(Pointer+4,value?.Pointer ?? IntPtr.Zero); } }
    [NativeMember("CoorsX")]
    public short @CoorsX { get => SdkMemory.Read<short >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("CoorsY")]
    public short @CoorsY { get => SdkMemory.Read<short >(Pointer+10); set { SdkMemory.Write(Pointer+10,value); } }
    [NativeMember("CoorsZ")]
    public short @CoorsZ { get => SdkMemory.Read<short >(Pointer+12); set { SdkMemory.Write(Pointer+12,value); } }
    [NativeMember("DistanceToTarget")]
    public short @DistanceToTarget { get => SdkMemory.Read<short >(Pointer+14); set { SdkMemory.Write(Pointer+14,value); } }
    [NativeMember("IndexAdjacentNodes")]
    public short @IndexAdjacentNodes { get => SdkMemory.Read<short >(Pointer+16); set { SdkMemory.Write(Pointer+16,value); } }
    [NativeMember("Address")]
    public CNodeAddress @Address { get => new CNodeAddress(Pointer+18); set { SdkMemory.Copy(value.Pointer,Pointer+18,4); } }
    [NativeMember("Width")]
    public byte @Width { get => SdkMemory.Read<byte >(Pointer+22); set { SdkMemory.Write(Pointer+22,value); } }
    [NativeMember("Group")]
    public byte @Group { get => SdkMemory.Read<byte >(Pointer+23); set { SdkMemory.Write(Pointer+23,value); } }
    [NativeMember("NumberAdjNodes")]
    public byte @NumberAdjNodes { get => (byte)SdkMemory.ReadBits(Pointer,192,4); set { SdkMemory.WriteBits(Pointer,192,4,unchecked((ulong)value)); } }
    [NativeMember("OnDeadEnd")]
    public byte @OnDeadEnd { get => (byte)SdkMemory.ReadBits(Pointer,196,1); set { SdkMemory.WriteBits(Pointer,196,1,unchecked((ulong)value)); } }
    [NativeMember("SwitchedOff")]
    public byte @SwitchedOff { get => (byte)SdkMemory.ReadBits(Pointer,197,1); set { SdkMemory.WriteBits(Pointer,197,1,unchecked((ulong)value)); } }
    [NativeMember("RoadBlock")]
    public byte @RoadBlock { get => (byte)SdkMemory.ReadBits(Pointer,198,1); set { SdkMemory.WriteBits(Pointer,198,1,unchecked((ulong)value)); } }
    [NativeMember("WaterNode")]
    public byte @WaterNode { get => (byte)SdkMemory.ReadBits(Pointer,199,1); set { SdkMemory.WriteBits(Pointer,199,1,unchecked((ulong)value)); } }
    [NativeMember("SwitchedOffOriginal")]
    public byte @SwitchedOffOriginal { get => (byte)SdkMemory.ReadBits(Pointer,200,1); set { SdkMemory.WriteBits(Pointer,200,1,unchecked((ulong)value)); } }
    [NativeMember("AlreadyFound")]
    public byte @AlreadyFound { get => (byte)SdkMemory.ReadBits(Pointer,201,1); set { SdkMemory.WriteBits(Pointer,201,1,unchecked((ulong)value)); } }
    [NativeMember("DontWanderHere")]
    public byte @DontWanderHere { get => (byte)SdkMemory.ReadBits(Pointer,202,1); set { SdkMemory.WriteBits(Pointer,202,1,unchecked((ulong)value)); } }
    [NativeMember("InteriorNode")]
    public byte @InteriorNode { get => (byte)SdkMemory.ReadBits(Pointer,203,1); set { SdkMemory.WriteBits(Pointer,203,1,unchecked((ulong)value)); } }
    [NativeMember("Speed")]
    public byte @Speed { get => (byte)SdkMemory.ReadBits(Pointer,204,2); set { SdkMemory.WriteBits(Pointer,204,2,unchecked((ulong)value)); } }
    [NativeMember("Dummy")]
    public byte @Dummy { get => (byte)SdkMemory.ReadBits(Pointer,206,2); set { SdkMemory.WriteBits(Pointer,206,2,unchecked((ulong)value)); } }
    [NativeMember("Density")]
    public byte @Density { get => (byte)SdkMemory.ReadBits(Pointer,208,4); set { SdkMemory.WriteBits(Pointer,208,4,unchecked((ulong)value)); } }
    [NativeMember("SpecialFunction")]
    public byte @SpecialFunction { get => (byte)SdkMemory.ReadBits(Pointer,212,4); set { SdkMemory.WriteBits(Pointer,212,4,unchecked((ulong)value)); } }
    public CVector @GetNodeCoors() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D785 >(785)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
}
