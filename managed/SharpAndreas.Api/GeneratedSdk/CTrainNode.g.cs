// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CTrainNode : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=10;
    public CTrainNode(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public short @X { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public short @Y { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("z")]
    public short @Z { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    [NativeMember("m_nDistanceFromStart")]
    public ushort @DistanceFromStart { get => SdkMemory.Read<ushort >(Pointer+6); set { SdkMemory.Write(Pointer+6,value); } }
    [NativeMember("m_nSurfaceLighting")]
    public bool @SurfaceLighting { get => SdkMemory.Read<bool >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_bSurfLightingFound")]
    public bool @SurfLightingFound { get => SdkMemory.Read<bool >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4218 >(4218)(Pointer); }
    public void @SetX(float @X) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4219 >(4219)(Pointer,@X); }
    public void @SetY(float @Y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4220 >(4220)(Pointer,@Y); }
    public void @SetZ(float @Z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4221 >(4221)(Pointer,@Z); }
    public float @GetX() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4222 >(4222)(Pointer); return __sdkResult; }
    public float @GetY() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4223 >(4223)(Pointer); return __sdkResult; }
    public float @GetZ() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4224 >(4224)(Pointer); return __sdkResult; }
    public CVector @GetPosn() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D4225 >(4225)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @SetDistanceFromStart(float @dist) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4226 >(4226)(Pointer,@dist); }
    public float @GetDistanceFromStart() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4227 >(4227)(Pointer); return __sdkResult; }
    public byte @GetLightingFromCollision() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4228 >(4228)(Pointer); return __sdkResult; }
}
