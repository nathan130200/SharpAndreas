using SharpAndreas;
using System.Runtime.Loader;
public abstract class IsolationFixture : Mod
{
    public override void Start(ModContext context)
    {
        var own = AssemblyLoadContext.GetLoadContext(GetType().Assembly);
        var dependency = AssemblyLoadContext.GetLoadContext(typeof(PrivateValue).Assembly);
        bool shared=System.IO.Path.GetFileName(context.Directory)=="IsolationB";
        if (own is null || !own.IsCollectible || (shared?dependency!=AssemblyLoadContext.Default:own!=dependency) || own == AssemblyLoadContext.Default)
            throw new Exception("Mod dependency was not isolated");
        context.Log("PrivateDependency=" + PrivateValue.Marker);
    }
}
#if IsolationA
public sealed class IsolationA:IsolationFixture { }
#else
public sealed class IsolationB:IsolationFixture { }
#endif
