using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SharpAndreas.Sdk;

[AttributeUsage(AttributeTargets.Property)]
public sealed class NativeMemberAttribute(string name):Attribute
{
    public string Name {get;}=name;
}

/// <summary>A typed borrowed view of native SDK memory. Engine lifetimes remain owned by GTA.</summary>
public abstract class NativeObject : IDisposable
{
    private IntPtr pointer;
    public IntPtr Pointer => pointer!=IntPtr.Zero ? pointer : throw new ObjectDisposedException(GetType().Name);
    private bool ownsStorage;
    protected NativeObject(IntPtr pointer) { if(pointer==IntPtr.Zero) throw new ArgumentNullException(nameof(pointer)); this.pointer=pointer; }
    internal void OwnStorage() => ownsStorage=true;
    public void Dispose() { if(ownsStorage && pointer!=IntPtr.Zero) { Marshal.FreeHGlobal(pointer); pointer=IntPtr.Zero; } }
    public static T AllocateStorage<T>(int bytes) where T:NativeObject
    {
        Game.CheckThread();
        if(bytes<=0 || bytes>1_048_576) throw new ArgumentOutOfRangeException(nameof(bytes));
        var pointer=Marshal.AllocHGlobal(bytes);
        unsafe { new Span<byte>((void*)pointer,bytes).Clear(); }
        try { var result=(T)Activator.CreateInstance(typeof(T),pointer)!; result.OwnStorage(); return result; }
        catch { Marshal.FreeHGlobal(pointer); throw; }
    }
}

public readonly struct NativePointer<T>(IntPtr pointer) where T:unmanaged
{
    public IntPtr Pointer { get; }=pointer;
    public T Value { get=>SdkMemory.Read<T>(Pointer); set=>SdkMemory.Write(Pointer,value); }
}
public readonly struct NativeFunctionPointer<TDelegate>(IntPtr pointer) where TDelegate:Delegate
{
    public IntPtr Pointer {get;}=pointer;
    public TDelegate GetDelegate() { Game.CheckThread(); if(typeof(TDelegate).IsDefined(typeof(UnsupportedNativeSignatureAttribute),false)) throw new NotSupportedException("This callback requires an explicit native ABI adapter."); return Marshal.GetDelegateForFunctionPointer<TDelegate>(Pointer); }
}
[AttributeUsage(AttributeTargets.Delegate)]
public sealed class UnsupportedNativeSignatureAttribute:Attribute { }
public readonly struct NativeArray<T>(IntPtr pointer,int count) where T:unmanaged
{
    public IntPtr Pointer { get; }=pointer;
    public int Count { get; }=count;
    public T this[int index] { get { Check(index); return SdkMemory.Read<T>(Pointer+index*Unsafe.SizeOf<T>()); } set { Check(index); SdkMemory.Write(Pointer+index*Unsafe.SizeOf<T>(),value); } }
    private void Check(int index) { if((uint)index>=(uint)Count) throw new ArgumentOutOfRangeException(nameof(index)); }
}
public sealed class NativeObjectArray<T>(IntPtr pointer,int count,int stride) where T:NativeObject
{
    public IntPtr Pointer { get; }=pointer;
    public int Count { get; }=count;
    public T this[int index] { get { if((uint)index>=(uint)Count) throw new ArgumentOutOfRangeException(nameof(index)); Game.CheckThread(); return (T)Activator.CreateInstance(typeof(T),Pointer+index*stride)!; } }
}
public static class SdkMemory
{
    public static unsafe T Read<T>(IntPtr pointer) where T:unmanaged { Game.CheckThread(); if(pointer==IntPtr.Zero) throw new ArgumentNullException(nameof(pointer)); return Unsafe.ReadUnaligned<T>((void*)pointer); }
    public static unsafe void Write<T>(IntPtr pointer,T value) where T:unmanaged { Game.CheckThread(); if(pointer==IntPtr.Zero) throw new ArgumentNullException(nameof(pointer)); Unsafe.WriteUnaligned((void*)pointer,value); }
    public static unsafe void Copy(IntPtr source,IntPtr destination,int size) { Game.CheckThread(); if(source==IntPtr.Zero || destination==IntPtr.Zero || size<0) throw new ArgumentException("Invalid native copy."); Buffer.MemoryCopy((void*)source,(void*)destination,size,size); }
    internal static ulong ReadBits(IntPtr pointer,int bitOffset,int width)
    {
        Game.CheckThread(); ulong value=0;
        for(int i=0;i<width;i++) if((Read<byte>(pointer+(bitOffset+i)/8)&(1<<((bitOffset+i)%8)))!=0) value|=1UL<<i;
        return value;
    }
    internal static long ReadSignedBits(IntPtr pointer,int bitOffset,int width)=>unchecked((long)(ReadBits(pointer,bitOffset,width)<<(64-width)))>>(64-width);
    internal static void WriteBits(IntPtr pointer,int bitOffset,int width,ulong value)
    {
        Game.CheckThread();
        for(int i=0;i<width;i++) { var p=pointer+(bitOffset+i)/8; int mask=1<<((bitOffset+i)%8); Write(p,(byte)((Read<byte>(p)&~mask)|(((value>>i)&1)!=0?mask:0))); }
    }
}

internal static class SdkBindings
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate IntPtr Resolver(int id);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)] private delegate IntPtr FieldAddress();
    internal static IntPtr Address(int id)=>Get<FieldAddress>(id)();
    private static Resolver resolve=null!;
    private static readonly Dictionary<int,Delegate> cache=[];
    internal static void Bind(IntPtr callback)=>resolve=Marshal.GetDelegateForFunctionPointer<Resolver>(callback);
    internal static T Get<T>(int id) where T:Delegate
    {
        Game.CheckThread();
        if(cache.TryGetValue(id,out var found)) return (T)found;
        var pointer=resolve(id);
        if(pointer==IntPtr.Zero) throw new NotSupportedException($"SDK binding {id} is not available in this host.");
        var result=Marshal.GetDelegateForFunctionPointer<T>(pointer); cache.Add(id,result); return result;
    }
}
