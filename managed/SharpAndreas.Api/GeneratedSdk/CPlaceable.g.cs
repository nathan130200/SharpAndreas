// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CPlaceable : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=24;
    public CPlaceable(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_placement")]
    public CSimpleTransform @Placement { get => new CSimpleTransform(Pointer+4); set { SdkMemory.Copy(value.Pointer,Pointer+4,16); } }
    [NativeMember("m_matrix")]
    public CMatrixLink? @Matrix { get => SdkMemory.Read<IntPtr>(Pointer+20) == IntPtr.Zero ? null : new CMatrixLink(SdkMemory.Read<IntPtr>(Pointer+20)); set { SdkMemory.Write(Pointer+20,value?.Pointer ?? IntPtr.Zero); } }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D277 >(277)(Pointer); }
    public CMatrixLink @GetMatrix() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D278 >(278)(Pointer); return new CMatrixLink(__sdkResult); }
    public static void @ShutdownMatrixArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D279 >(279)(); }
    public static void @InitMatrixArray() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D280 >(280)(); }
    public CVector @GetRightDirection() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D281 >(281)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CVector @GetTopDirection() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D282 >(282)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public CVector @GetAtDirection() { Game.CheckThread(); var result=NativeObject.AllocateStorage<CVector >(12); try { SdkBindings.Get<GeneratedDelegates.D283 >(283)(Pointer,result.Pointer); return result; } catch { result.Dispose(); throw; } }
    public void @FreeStaticMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D284 >(284)(Pointer); }
    public void @SetPosn(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D285 >(285)(Pointer,@x,@y,@z); }
    public void @SetPosn(CVector @posn) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D286 >(286)(Pointer,@posn.Pointer); }
    public void @SetPosition(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D287 >(287)(Pointer,@x,@y,@z); }
    public void @SetPosition(CVector @pos) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D288 >(288)(Pointer,@pos.Pointer); }
    public void @SetOrientation(float @x,float @y,float @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D289 >(289)(Pointer,@x,@y,@z); }
    public void @GetOrientation(NativePointer<float> @x,NativePointer<float> @y,NativePointer<float> @z) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D290 >(290)(Pointer,@x.Pointer,@y.Pointer,@z.Pointer); }
    public void @SetHeading(float @heading) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D291 >(291)(Pointer,@heading); }
    public float @GetHeading() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D292 >(292)(Pointer); return __sdkResult; }
    public bool @IsWithinArea(float @x1,float @y1,float @x2,float @y2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D293 >(293)(Pointer,@x1,@y1,@x2,@y2); return __sdkResult != 0; }
    public bool @IsWithinArea(float @x1,float @y1,float @z1,float @x2,float @y2,float @z2) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D294 >(294)(Pointer,@x1,@y1,@z1,@x2,@y2,@z2); return __sdkResult != 0; }
    public void @RemoveMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D295 >(295)(Pointer); }
    public void @AllocateStaticMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D296 >(296)(Pointer); }
    public void @AllocateMatrix() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D297 >(297)(Pointer); }
    public void @SetMatrix(CMatrix @matrix) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D298 >(298)(Pointer,@matrix.Pointer); }
    public CVector @GetRight() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D299 >(299)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetForward() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D300 >(300)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetUp() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D301 >(301)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetPosition() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D302 >(302)(Pointer); return new CVector(__sdkResult); }
    public CVector @GetPosition__275a9d9c() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D303 >(303)(Pointer); return new CVector(__sdkResult); }
}
