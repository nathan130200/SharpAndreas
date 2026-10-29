// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CompressedVector : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=6;
    public CompressedVector(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public short @X { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public short @Y { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    [NativeMember("z")]
    public short @Z { get => SdkMemory.Read<short >(Pointer+4); set { SdkMemory.Write(Pointer+4,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D326 >(326)(Pointer); }
    public void @InitializeAt(short @X,short @Y,short @Z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D327 >(327)(Pointer,@X,@Y,@Z); }
    public void @InitializeAt(CompressedVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D328 >(328)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(CompressedVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D329 >(329)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(CVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D330 >(330)(Pointer,@rhs.Pointer); }
    public void @Set(short @X,short @Y,short @Z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D331 >(331)(Pointer,@X,@Y,@Z); }
    public void @Set(CompressedVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D332 >(332)(Pointer,@rhs.Pointer); }
    public void @Set(CompressedVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D333 >(333)(Pointer,@rhs.Pointer); }
    public void @Set(CVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D334 >(334)(Pointer,@rhs.Pointer); }
    public CVector @Uncompressed() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D335 >(335)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @Uncompress(CVector @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D336 >(336)(Pointer,@out.Pointer); }
    public CompressedVector2D @To2D() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CompressedVector2D >(4); try { SdkBindings.Get<GeneratedDelegates.D337 >(337)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public bool @Operator_operator__(CompressedVector @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D338 >(338)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator____836e0569(CompressedVector @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D339 >(339)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
}
