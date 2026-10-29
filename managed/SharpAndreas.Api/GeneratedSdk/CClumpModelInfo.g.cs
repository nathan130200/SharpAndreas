// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CClumpModelInfo : CBaseModelInfo
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=36;
    public CClumpModelInfo(System.IntPtr pointer) : base(pointer) {}
    public CBox? @GetBoundingBox() { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D407 >(407)(Pointer); return __sdkResult == IntPtr.Zero ? null : new CBox(__sdkResult); }
    public void @SetClump(RpClump? @clump) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D408 >(408)(Pointer,@clump?.Pointer ?? IntPtr.Zero); }
    public static void @SetAtomicRendererCB(RpAtomic? @atomic,NativePointer<IntPtr> @renderFunc) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D409 >(409)(@atomic?.Pointer ?? IntPtr.Zero,@renderFunc.Pointer); }
    public static RwFrame? @FindFrameFromNameCB(RwFrame? @frame,NativePointer<IntPtr> @searchData) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D410 >(410)(@frame?.Pointer ?? IntPtr.Zero,@searchData.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static RwFrame? @FindFrameFromNameWithoutIdCB(RwFrame? @frame,NativePointer<IntPtr> @searchData) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D411 >(411)(@frame?.Pointer ?? IntPtr.Zero,@searchData.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static RwFrame? @FindFrameFromIdCB(RwFrame? @frame,NativePointer<IntPtr> @searchData) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D412 >(412)(@frame?.Pointer ?? IntPtr.Zero,@searchData.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static RwFrame? @FillFrameArrayCB(RwFrame? @frame,NativePointer<IntPtr> @data) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D413 >(413)(@frame?.Pointer ?? IntPtr.Zero,@data.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static RwFrame? @GetFrameFromId(RpClump? @clump,int @id) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D414 >(414)(@clump?.Pointer ?? IntPtr.Zero,@id); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static RwFrame? @GetFrameFromName(RpClump? @clump,NativePointer<sbyte> @name) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D415 >(415)(@clump?.Pointer ?? IntPtr.Zero,@name.Pointer); return __sdkResult == IntPtr.Zero ? null : new RwFrame(__sdkResult); }
    public static void @FillFrameArray(RpClump? @clump,NativePointer<IntPtr> @frames) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D416 >(416)(@clump?.Pointer ?? IntPtr.Zero,@frames.Pointer); }
    public void @SetFrameIds(RwObjectNameIdAssocation? @data) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D417 >(417)(Pointer,@data?.Pointer ?? IntPtr.Zero); }
}
