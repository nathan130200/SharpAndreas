using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace SharpAndreas.Runtime;

internal sealed class ModLoadContext(string assemblyPath,string directory,string id):AssemblyLoadContext(id,isCollectible:true)
{
    private readonly AssemblyDependencyResolver resolver=new(assemblyPath);
    internal Assembly LoadMain(byte[] bytes)
    {
        using var stream=new MemoryStream(bytes,writable:false);
        return LoadFromStream(stream);
    }
    private Assembly LoadFile(string path)=>LoadMain(File.ReadAllBytes(path));
    protected override Assembly? Load(AssemblyName name)
    {
        if(name.Name==typeof(Mod).Assembly.GetName().Name)return typeof(Mod).Assembly;
        string simple=name.Name ?? throw new FileNotFoundException("Assembly name is empty.");
        if(Path.GetFileName(simple)!=simple)throw new FileNotFoundException("Invalid assembly name.");
        foreach(string path in new[]{Path.Combine(directory,"Libraries",simple+".dll"),Path.Combine(Path.GetDirectoryName(assemblyPath)!,simple+".dll"),Path.Combine(directory,simple+".dll")})
            if(File.Exists(path))return LoadFile(path);
        string? resolved=resolver.ResolveAssemblyToPath(name);
        if(resolved is not null && File.Exists(resolved))return LoadFile(resolved);
        return SharedLibraries.Resolve(name);
    }
    protected override IntPtr LoadUnmanagedDll(string name)
    {
        string filename=Path.GetFileName(name);
        if(!filename.EndsWith(".dll",StringComparison.OrdinalIgnoreCase))filename+=".dll";
        string privatePath=Path.Combine(directory,"Libraries",filename);
        if(File.Exists(privatePath))return LoadUnmanagedDllFromPath(privatePath);
        string? resolved=resolver.ResolveUnmanagedDllToPath(name);
        if(resolved is not null)return LoadUnmanagedDllFromPath(resolved);
        string shared=Path.Combine(SharedLibraries.Directory,filename);
        return File.Exists(shared)?LoadUnmanagedDllFromPath(shared):IntPtr.Zero;
    }
}

internal static class SharedLibraries
{
    private static readonly object gate=new();
    internal static string Directory="";
    internal static void Initialize(string root)
    {
        Directory=Path.Combine(root,"Libraries");
        System.IO.Directory.CreateDirectory(Directory);
        AssemblyLoadContext.Default.Resolving+=(_,name)=>Resolve(name);
        AssemblyLoadContext.Default.ResolvingUnmanagedDll+=(_,name)=>
        {
            string filename=Path.GetFileName(name);
            if(!filename.EndsWith(".dll",StringComparison.OrdinalIgnoreCase))filename+=".dll";
            string path=Path.Combine(Directory,filename);
            return File.Exists(path)?NativeLibrary.Load(path):IntPtr.Zero;
        };
    }
    internal static Assembly? Resolve(AssemblyName name)
    {
        string? simple=name.Name;
        if(simple is null || Path.GetFileName(simple)!=simple)return null;
        lock(gate)
        {
            var existing=AssemblyLoadContext.Default.Assemblies.FirstOrDefault(a=>a.GetName().Name==simple);
            if(existing is not null)return existing;
            string path=Path.Combine(Directory,simple+".dll");
            if(!File.Exists(path))return null;
            using var stream=new MemoryStream(File.ReadAllBytes(path),writable:false);
            return AssemblyLoadContext.Default.LoadFromStream(stream);
        }
    }
}
