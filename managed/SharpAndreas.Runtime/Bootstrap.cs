using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SharpAndreas.Runtime;

public static class Bootstrap
{
    [StructLayout(LayoutKind.Sequential)]
    private struct StartArgs {public int Size,Version;public IntPtr Root,KeyDown,Help,Scm,Tasks,Sdk,Logger,State,Overlay,World,Paths,Hud,Services;}
    private static ModHost? host;
    private static int thread;
    private static bool stopped;
    [UnmanagedCallersOnly(CallConvs=[typeof(CallConvCdecl)])]
    public static unsafe int Dispatch(void* data,int command)
    {
        try
        {
            if(command==0)
            {
                if(host is not null || data==null || stopped)return -1;
                var args=Marshal.PtrToStructure<StartArgs>((IntPtr)data);
                if(args.Size!=Marshal.SizeOf<StartArgs>() || args.Version!=10 || args.Root==IntPtr.Zero || args.KeyDown==IntPtr.Zero || args.Help==IntPtr.Zero || args.Scm==IntPtr.Zero || args.Tasks==IntPtr.Zero || args.Sdk==IntPtr.Zero || args.Logger==IntPtr.Zero || args.State==IntPtr.Zero || args.Overlay==IntPtr.Zero || args.World==IntPtr.Zero || args.Paths==IntPtr.Zero || args.Hud==IntPtr.Zero || args.Services==IntPtr.Zero)return -1;
                string root=Marshal.PtrToStringUni(args.Root)!;
                Log.Initialize(Path.Combine(root,"plugin.log"),args.Logger);
                GlobalDiagnostics.Initialize();
                var settings=TomlConfig.LoadOrCreate(Path.Combine(root,"SharpAndreas.toml"),new LoaderSettings());
                if(settings.Scheduler.MaxCallbacksPerFrame is <1 or >4096 || !double.IsFinite(settings.Scheduler.BudgetMilliseconds) || settings.Scheduler.BudgetMilliseconds is <0.1 or >50 || settings.HotReload.PollMilliseconds is <50 or >60000 || settings.HotReload.StabilizeMilliseconds is <50 or >10000)
                    throw new FormatException("Invalid scheduler/hot_reload settings in SharpAndreas.toml.");
                ScriptScheduler.MaxCallbacksPerFrame=settings.Scheduler.MaxCallbacksPerFrame;
                ScriptScheduler.BudgetMilliseconds=settings.Scheduler.BudgetMilliseconds;
                thread=Environment.CurrentManagedThreadId;
                Game.BindNative(thread,args.KeyDown,args.Help,args.Scm);
                GameServices.Bind(args.Services);HudRuntime.Bind(args.Hud);Paths.Bind(args.Paths);World.Bind(args.World);Game.BindState(args.State);OverlayBridge.Bind(args.Overlay);
                TaskRuntime.Bind(args.Tasks);Sdk.SdkBindings.Bind(args.Sdk);
                host=new ModHost(root,settings);
            }
            else
            {
                if(host is null || Environment.CurrentManagedThreadId!=thread)return -1;
                if(command==1 && !stopped)host.Update();
                else if(command==2 && !stopped){stopped=true;host.Stop();}
                else if(command==3 && !stopped)host.Draw();
                else if(command!=1 && command!=2 && command!=3)return -1;
            }
            return 0;
        }
        catch(Exception ex){Log.ReportException("Loader","Managed entry point failed",ex);return -1;}
    }
}
public sealed class LoaderSettings
{
    public bool Enabled {get;set;}=true;
    public bool Profiler {get;set;}
    public SchedulerSettings Scheduler {get;set;}=new();
    public HotReloadSettings HotReload {get;set;}=new();
}
public sealed class SchedulerSettings
{
    public int MaxCallbacksPerFrame {get;set;}=64;
    public double BudgetMilliseconds {get;set;}=2;
}
public sealed class HotReloadSettings
{
    public bool Enabled {get;set;}=true;
    public int PollMilliseconds {get;set;}=500;
    public int StabilizeMilliseconds {get;set;}=500;
}
public sealed class ScriptSettings {public bool Enabled {get;set;}=true;}
