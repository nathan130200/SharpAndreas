// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CompressedVector2D : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=4;
    public CompressedVector2D(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("x")]
    public short @X { get => SdkMemory.Read<short >(Pointer+0); set { SdkMemory.Write(Pointer+0,value); } }
    [NativeMember("y")]
    public short @Y { get => SdkMemory.Read<short >(Pointer+2); set { SdkMemory.Write(Pointer+2,value); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D767 >(767)(Pointer); }
    public void @InitializeAt(short @X,short @Y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D768 >(768)(Pointer,@X,@Y); }
    public void @InitializeAt(CompressedVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D769 >(769)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(CompressedVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D770 >(770)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(CVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D771 >(771)(Pointer,@rhs.Pointer); }
    public void @InitializeAt(RwV2d @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D772 >(772)(Pointer,@rhs.Pointer); }
    public void @Set(short @X,short @Y) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D773 >(773)(Pointer,@X,@Y); }
    public void @Set(CompressedVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D774 >(774)(Pointer,@rhs.Pointer); }
    public void @Set(CompressedVector @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D775 >(775)(Pointer,@rhs.Pointer); }
    public void @Set(CVector2D @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D776 >(776)(Pointer,@rhs.Pointer); }
    public void @Set(RwV2d @rhs) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D777 >(777)(Pointer,@rhs.Pointer); }
    public CVector2D @Uncompressed() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector2D >(8); try { SdkBindings.Get<GeneratedDelegates.D778 >(778)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public RwV2d @ToRwV2d() { Game.CheckThread(); var result=NativeObject.AllocateStorage<RwV2d >(8); try { SdkBindings.Get<GeneratedDelegates.D779 >(779)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CompressedVector @To3D() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CompressedVector >(6); try { SdkBindings.Get<GeneratedDelegates.D780 >(780)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @Uncompress(CVector2D @out) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D781 >(781)(Pointer,@out.Pointer); }
    public bool @Operator_operator__(CompressedVector2D @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D782 >(782)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
    public bool @Operator_operator____7634f6fd(CompressedVector2D @rhs) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D783 >(783)(Pointer,@rhs.Pointer); return __sdkResult != 0; }
}
