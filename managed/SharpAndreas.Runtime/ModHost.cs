using System.Reflection;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Runtime.ExceptionServices;

namespace SharpAndreas.Runtime;

internal sealed class ModHost
{
    private sealed class Slot(ModLoadContext context,Mod mod,ModContext api,ScriptScheduler scheduler)
    {
        internal ModLoadContext? Context=context;
        internal Mod? Mod=mod;
        internal readonly ModContext Api=api;
        internal readonly ScriptScheduler Scheduler=scheduler;
        internal Task Script=Task.CompletedTask;
        internal Exception? TaskFailure;
        internal readonly bool Draws=mod.GetType().GetMethod(nameof(Mod.Draw))!.DeclaringType!=typeof(Mod);
        internal bool ScriptStarted;
        internal double UpdateMs,DrawMs;
        internal long FrameAllocated,DrawAllocated,TotalAllocated;
        internal void Sample(bool draw,long started,long allocated)
        {
            double milliseconds=Stopwatch.GetElapsedTime(started).TotalMilliseconds;
            long bytes=Math.Max(0,GC.GetAllocatedBytesForCurrentThread()-allocated);
            TotalAllocated+=bytes;
            if(draw) {DrawMs=DrawMs*0.9+milliseconds*0.1;DrawAllocated=bytes;}
            else {UpdateMs=UpdateMs*0.9+milliseconds*0.1;FrameAllocated=bytes;}
        }
    }
    private sealed record Snapshot(string Stamp,ModManifest? Manifest,string? AssemblyPath,byte[]? Bytes,Exception? Error);
    private sealed class Watched(string folder)
    {
        internal readonly string Folder=folder;
        internal string Id=>Path.GetFileName(Folder);
        internal string ManifestPath=>Path.Combine(Folder,"mod.tml");
        internal string Current="",Pending="";
        internal long StableSince;
        internal Slot? Loaded;
        internal Task<Snapshot>? Reading;
    }
    private readonly string directory;
    private readonly LoaderSettings settings;
    private readonly Dictionary<string,Watched> watched=new(StringComparer.OrdinalIgnoreCase);
    private long nextPoll,nextProfile;
    private bool stopped;
    private string previousOverlay="";
    internal ModHost(string root,LoaderSettings settings)
    {
        this.settings=settings;
        directory=Path.Combine(root,"Mods");
        Directory.CreateDirectory(directory);
        SharedLibraries.Initialize(root);
        if(!settings.Enabled)return;
        foreach(string folder in Directory.GetDirectories(directory).Order(StringComparer.OrdinalIgnoreCase))
        {
            var item=new Watched(folder);watched.Add(folder,item);
            try {var snapshot=ReadSnapshot(item);if(snapshot.Stamp==Stamp(item))Replace(item,snapshot);}
            catch(Exception ex){Log.ReportException(item.Id,"Startup load deferred (version unknown)",ex);}
        }
        UpdateOverlay();
    }
    internal void Update()
    {
        if(stopped || !settings.Enabled)return;
        try {AudioStream3D.UpdateAll();}catch(Exception ex){Log.ReportException("Audio","Listener update failed",ex);}
        foreach(var item in watched.Values.ToArray())
        {
            var slot=item.Loaded;
            if(slot?.Mod is null)continue;
            long started=settings.Profiler?Stopwatch.GetTimestamp():0,allocated=settings.Profiler?GC.GetAllocatedBytesForCurrentThread():0;
            try
            {
                if(slot.TaskFailure is { } failure)ExceptionDispatchInfo.Throw(failure);
                if(slot.Script.IsFaulted)ExceptionDispatchInfo.Throw(slot.Script.Exception!.GetBaseException());
                if(slot.Script.IsCanceled && !slot.Scheduler.Token.IsCancellationRequested)throw new TaskCanceledException("RunAsync was canceled.");
                if(Game.IsPaused && !slot.Api.CanTickWhenPaused)continue;
                StartScript(slot);
                slot.Scheduler.Pump();
                if(slot.Script.IsFaulted)ExceptionDispatchInfo.Throw(slot.Script.Exception!.GetBaseException());
                slot.Scheduler.Invoke(slot.Mod.Tick);
            }
            catch(Exception ex) {Log.ReportException(slot.Api.Name,$"DISABLED {item.Id} ({slot.Api.Name} v{slot.Api.Version}) during Tick",ex);Release(item);}
            finally {if(settings.Profiler)slot.Sample(false,started,allocated);}
        }
        if(settings.HotReload.Enabled)Poll();
        UpdateOverlay();UpdateProfiler();
    }
    internal void Draw()
    {
        if(stopped || !settings.Enabled)return;
        foreach(var item in watched.Values.ToArray())
        {
            var slot=item.Loaded;
            if(slot?.Mod is null || !slot.Draws)continue;
            bool begun=false;
            long started=0,allocated=0;
            try
            {
                begun=HudRuntime.Begin(slot.Api.TaskOwner);
                if(begun)
                {
                    if(settings.Profiler) {started=Stopwatch.GetTimestamp();allocated=GC.GetAllocatedBytesForCurrentThread();}
                    slot.Scheduler.Invoke(slot.Mod.Draw);
                }
            }
            catch(Exception ex)
            {
                Log.ReportException(slot.Api.Name,$"DISABLED {item.Id} ({slot.Api.Name} v{slot.Api.Version}) during Draw",ex);
                if(begun) {try {HudRuntime.End(slot.Api.TaskOwner);}catch(Exception cleanup){Log.ReportException(slot.Api.Name,"HUD state cleanup failed",cleanup);}begun=false;}
                Release(item);
            }
            finally
            {
                if(settings.Profiler && started!=0)slot.Sample(true,started,allocated);
                if(begun)HudRuntime.End(slot.Api.TaskOwner);
            }
        }
    }
    private void UpdateProfiler()
    {
        if(!settings.Profiler || Environment.TickCount64<nextProfile)return;
        nextProfile=Environment.TickCount64+250;
        var text=new StringBuilder();
        text.AppendLine(FormattableString.Invariant($".NET profiler | CLR heap {GC.GetTotalMemory(false)/1048576.0:F1} MiB"));
        text.AppendLine("U/D: update/draw avg ms | A: frame allocations KiB | Sum: allocated MiB");
        foreach(var item in watched.Values.Where(w=>w.Loaded?.Mod is not null).OrderBy(w=>w.Loaded!.Api.Name))
        {
            var slot=item.Loaded!;string name=slot.Api.Name.Length>24?slot.Api.Name[..21]+"...":slot.Api.Name;
            text.AppendLine(FormattableString.Invariant($"{name} U:{slot.UpdateMs:F2} D:{slot.DrawMs:F2} A:{(slot.FrameAllocated+slot.DrawAllocated)/1024.0:F1} Sum:{slot.TotalAllocated/1048576.0:F2}"));
        }
        HudRuntime.SetProfiler(text.ToString());
    }
    private static void StartScript(Slot slot)
    {
        if(slot.ScriptStarted)return;slot.ScriptStarted=true;
        slot.Scheduler.Invoke(()=>slot.Script=slot.Mod!.RunAsync(slot.Api,slot.Scheduler.Token) ?? throw new InvalidOperationException("RunAsync returned null."));
    }
    private void UpdateOverlay()
    {
        string text="Active mods: "+watched.Values.Count(w=>w.Loaded?.Mod is not null).ToString(CultureInfo.InvariantCulture);
        if(text==previousOverlay)return;previousOverlay=text;OverlayBridge.Update(text);
    }
    private static string Stamp(Watched item)
    {
        if(!Directory.Exists(item.Folder))return "<removed>";
        var options=new EnumerationOptions {RecurseSubdirectories=true,IgnoreInaccessible=false,AttributesToSkip=FileAttributes.ReparsePoint};
        var files=Directory.EnumerateFiles(item.Folder,"*",options).Where(path=>
            path.EndsWith(".dll",StringComparison.OrdinalIgnoreCase) || path.EndsWith(".deps.json",StringComparison.OrdinalIgnoreCase) || path.Equals(item.ManifestPath,StringComparison.OrdinalIgnoreCase));
        return "manifest="+File.Exists(item.ManifestPath)+"|"+string.Join("|",files.Order(StringComparer.OrdinalIgnoreCase).Select(path=>
        {
            var file=new FileInfo(path);
            return Path.GetRelativePath(item.Folder,path)+":"+file.Length+":"+file.LastWriteTimeUtc.Ticks;
        }));
    }
    private static Snapshot ReadSnapshot(Watched item)
    {
        string before=Stamp(item);
        ModManifest? manifest=null;string? assemblyPath=null;byte[]? bytes=null;Exception? error=null;
        try
        {
            manifest=ModManifest.Parse(File.ReadAllText(item.ManifestPath));
            assemblyPath=manifest.ValidateAndResolve(item.Folder);
            bytes=File.ReadAllBytes(assemblyPath);
        }
        catch(Exception ex) when(ex is not IOException || ex is FileNotFoundException or DirectoryNotFoundException) {error=ex;}
        if(before!=Stamp(item))throw new IOException("Mod files changed while reading.");
        return new(before,manifest,assemblyPath,bytes,error);
    }
    private void Poll()
    {
        long now=Environment.TickCount64;
        foreach(var item in watched.Values.ToArray())
        {
            if(item.Reading is not {IsCompleted:true} ready)continue;
            item.Reading=null;
            try
            {
                var snapshot=ready.GetAwaiter().GetResult();
                if(Directory.Exists(item.Folder) && snapshot.Stamp==Stamp(item))Replace(item,snapshot);
            }
            catch(Exception ex){Log.ReportException(item.Loaded?.Api.Name??item.Id,$"Waiting for a stable mod build (v{item.Loaded?.Api.Version??"unknown"})",ex);}
        }
        if(now<nextPoll)return;
        nextPoll=now+settings.HotReload.PollMilliseconds;
        try
        {
            var folders=Directory.Exists(directory)?Directory.GetDirectories(directory):[];
            var present=folders.ToHashSet(StringComparer.OrdinalIgnoreCase);
            foreach(var old in watched.Values.Where(w=>!present.Contains(w.Folder)).ToArray()) {Release(old);watched.Remove(old.Folder);}
            foreach(string folder in folders)
            {
                if(!watched.TryGetValue(folder,out var item)) {item=new(folder);watched.Add(folder,item);}
                string stamp=Stamp(item);
                if(stamp==item.Current)continue;
                if(item.Pending!=stamp) {item.Pending=stamp;item.StableSince=now;continue;}
                if(item.Reading is not null || now-item.StableSince<settings.HotReload.StabilizeMilliseconds)continue;
                item.Reading=Task.Run(()=>ReadSnapshot(item));
            }
        }
        catch(IOException ex){Log.ReportException("Loader","Mod scan deferred",ex);}
        catch(UnauthorizedAccessException ex){Log.ReportException("Loader","Mod scan deferred",ex);}
    }
    private void Replace(Watched item,Snapshot snapshot)
    {
        Release(item);
        item.Current=snapshot.Stamp;item.Pending="";
        ModLoadContext? context=null;Slot? slot=null;
        string name=snapshot.Manifest?.Name??item.Id;
        if(string.IsNullOrWhiteSpace(name) || name.Length>128 || name.Any(char.IsControl))name=item.Id;
        string version=snapshot.Manifest?.Version??"unknown";
        if(string.IsNullOrWhiteSpace(version) || version.Length>64 || version.Any(char.IsControl))version="unknown";
        try
        {
            if(snapshot.Error is {} error)ExceptionDispatchInfo.Throw(error);
            var manifest=snapshot.Manifest!;
            context=new(snapshot.AssemblyPath!,item.Folder,item.Id);
            var assembly=context.LoadMain(snapshot.Bytes!);
            var type=assembly.GetType(manifest.MainClass,throwOnError:false,ignoreCase:false);
            if(type is null || !type.IsVisible || type.IsAbstract || type.ContainsGenericParameters || !typeof(Mod).IsAssignableFrom(type) || type.GetConstructor(Type.EmptyTypes) is null)
                throw new InvalidOperationException($"main-class '{manifest.MainClass}' must identify a public concrete Mod with a public parameterless constructor in '{manifest.Assembly}'.");
            Log.Register(type,name);
            Mod mod;var previousLog=Log.Enter(name);
            try {mod=(Mod)Activator.CreateInstance(type)!;}finally{Log.Restore(previousLog);}
            var scheduler=new ScriptScheduler();
            var api=new ModContext(item.Folder,message=>Log.Write(name,message),scheduler.Delay,scheduler.Token)
                {ScriptName=name,Name=name,ModId=item.Id,Version=version,CanTickWhenPaused=type.IsDefined(typeof(TickWhenPausedAttribute),inherit:true)};
            scheduler.Context=api;slot=new(context,mod,api,scheduler);
            TaskRuntime.Begin(api,scheduler.Invoke,exception=>slot.TaskFailure??=exception);
            if(!TomlConfig.LoadOrCreate(Path.Combine(item.Folder,"script.toml"),new ScriptSettings()).Enabled)
            {item.Loaded=slot;Release(item);Log.Write(name,$"DISABLED {item.Id} ({name} v{version}) by script.toml.");return;}
            scheduler.Invoke(()=> {mod.Start(api);if(!Game.IsPaused || api.CanTickWhenPaused)StartScript(slot);});
            if(slot.Script.IsFaulted)ExceptionDispatchInfo.Throw(slot.Script.Exception!.GetBaseException());
            item.Loaded=slot;
            Log.Write(name,$"LOADED {item.Id} ({name} v{version}) main-class={manifest.MainClass} assembly={manifest.Assembly} from memory");
        }
        catch(Exception ex)
        {
            Log.ReportException(name,$"DISABLED {item.Id} ({name} v{version}) during load/Start",ex);
            if(slot is not null){item.Loaded=slot;Release(item);}else context?.Unload();
        }
    }
    private static void Release(Watched item)
    {
        var slot=item.Loaded;
        if(slot?.Mod is null)return;
        item.Loaded=null;
        var mod=slot.Mod;slot.Mod=null;
        try
        {
            try {slot.Scheduler.Cancel();}catch(Exception ex){Log.ReportException(slot.Api.Name,$"Cancellation failed ({slot.Api.Name} v{slot.Api.Version})",ex);}
            if(slot.Script.IsFaulted)Log.ReportException(slot.Api.Name,$"RunAsync failed ({slot.Api.Name} v{slot.Api.Version})",slot.Script.Exception!);
            try {slot.Scheduler.Invoke(mod.Stop);}catch(Exception ex){Log.ReportException(slot.Api.Name,$"Stop failed: ({slot.Api.Name} v{slot.Api.Version})",ex);}
            if(!slot.Script.IsCompleted)Log.Write(slot.Api.ScriptName,"Unfinished external work remains; cancellation must be cooperative.");
        }
        finally
        {
            try {slot.Scheduler.Invoke(()=>ModResources.End(slot.Api.TaskOwner));}catch(Exception ex){Log.ReportException(slot.Api.Name,"Resource cleanup failed",ex);}
            try {TaskRuntime.End(slot.Api.TaskOwner);}catch(Exception ex){Log.ReportException(slot.Api.Name,$"Task cleanup failed ({slot.Api.Name} v{slot.Api.Version})",ex);}
            try {HudRuntime.Release(slot.Api.TaskOwner);}catch(Exception ex){Log.ReportException(slot.Api.Name,"HUD resource cleanup failed",ex);}
            slot.TaskFailure=null;slot.Script=Task.CompletedTask;
            slot.Scheduler.Dispose();slot.Context?.Unload();slot.Context=null;
            Log.Write(slot.Api.ScriptName,"AssemblyLoadContext unload requested.");
        }
    }
    internal void Stop()
    {
        if(stopped)return;stopped=true;
        foreach(var item in watched.Values.Reverse())Release(item);
        watched.Clear();HudRuntime.SetProfiler("");OverlayBridge.Update("");Log.Write("Loader","Loader stopped.");
    }
}
