using System.Runtime.InteropServices;
namespace SharpAndreas.Runtime;
internal static class OverlayBridge
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate void UpdateCallback([MarshalAs(UnmanagedType.LPWStr)]string text);
    private static UpdateCallback update=null!;
    internal static void Bind(IntPtr pointer)=>update=Marshal.GetDelegateForFunctionPointer<UpdateCallback>(pointer);
    internal static void Update(string text)=>update(text);
}
