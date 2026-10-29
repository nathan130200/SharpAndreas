using System.Numerics;
using System.Runtime.InteropServices;
namespace SharpAndreas;
/// <summary>Mod-owned positional audio using optional x86 BASS 2.4. Loading bytes is asynchronous; control stays on the game thread.</summary>
public sealed class AudioStream3D:IDisposable
{
    private static readonly HashSet<AudioStream3D> streams=[];
    private readonly uint owner;
    private uint handle;
    private IntPtr buffer;
    private Entity? attached;
    private Vector3 offset,position;
    private float volume=1;
    private AudioStream3D(uint handle,IntPtr buffer) {this.handle=handle;this.buffer=buffer;owner=ModResources.Register(this);streams.Add(this);}
    /// <summary>Reads a local mono WAV/OGG/MP3 file into memory. bass.dll must be in SharpAndreas/Libraries.</summary>
    public static async Task<AudioStream3D> LoadAsync(string file,CancellationToken cancellationToken=default)
    {
        Game.CheckThread();_ = TaskRuntime.CurrentOwner;ArgumentException.ThrowIfNullOrWhiteSpace(file);
        using var cancellation=CancellationTokenSource.CreateLinkedTokenSource(cancellationToken,ModContext.Current!.CancellationToken);
        byte[] bytes=await File.ReadAllBytesAsync(Path.GetFullPath(file),cancellation.Token);
        cancellation.Token.ThrowIfCancellationRequested();Game.CheckThread();Bass.Initialize();
        IntPtr buffer=Marshal.AllocHGlobal(bytes.Length);uint channel=0;
        try {Marshal.Copy(bytes,0,buffer,bytes.Length);channel=Bass.Create(1,buffer,0,(ulong)bytes.Length,8|2);if(channel==0)throw Bass.Error("Create 3D stream (use mono audio)");return new(channel,buffer);}
        catch {if(channel!=0)Bass.Free(channel);Marshal.FreeHGlobal(buffer);throw;}
    }
    private void Check() {ModResources.Check(owner);ObjectDisposedException.ThrowIf(handle==0,this);}
    public Vector3 Position {get {Check();return position;}set {Check();Entity.ValidatePosition(value);attached=null;position=value;ApplyPosition();}}
    public float Volume {get {Check();return volume;}set {Check();if(!float.IsFinite(value)||value is <0 or >1)throw new ArgumentOutOfRangeException(nameof(value));Bass.Require(Bass.Attribute(handle,2,value),"Set volume");volume=value;}}
    public void SetDistance(float minimum,float maximum) {Check();if(!float.IsFinite(minimum)||!float.IsFinite(maximum)||minimum<=0||maximum<minimum)throw new ArgumentOutOfRangeException(nameof(minimum));Bass.Require(Bass.Attributes3D(handle,0,minimum,maximum,-1,-1,-1),"Set 3D distance");Bass.Apply();}
    public void AttachTo(Entity entity,Vector3 offset=default) {Check();ArgumentNullException.ThrowIfNull(entity);if(!entity.Exists)throw new InvalidOperationException("Entity no longer exists.");Entity.ValidatePosition(offset);attached=entity;this.offset=offset;UpdateSource();}
    public void Detach() {Check();attached=null;}
    public void Play(bool restart=false) {Check();Bass.Require(Bass.Play(handle,restart?1:0),"Play stream");}
    public void Pause() {Check();Bass.Require(Bass.Pause(handle),"Pause stream");}
    public void Stop() {Check();Bass.Require(Bass.Stop(handle),"Stop stream");}
    private unsafe void ApplyPosition() {var point=Convert(position);Bass.Require(Bass.Position3D(handle,&point,null,null),"Set 3D position");Bass.Apply();}
    private void UpdateSource() {if(attached is {} entity){if(!entity.Exists){attached=null;Bass.Stop(handle);return;}position=entity.Position+offset;}ApplyPosition();}
    private static Vector3 Convert(Vector3 value)=>new(value.X,value.Z,value.Y);
    internal static unsafe void UpdateAll()
    {
        if(streams.Count==0)return;
        // BASS and the game have one listener each. Preserve the game camera as that listener.
        var position=Convert(Camera.Position);var forward=Convert(Camera.Target-Camera.Position);if(forward.LengthSquared()<0.0001f)forward=Vector3.UnitZ;else forward=Vector3.Normalize(forward);
        var up=Vector3.UnitY;Bass.Listener(&position,null,&forward,&up);
        foreach(var stream in streams.ToArray())try {stream.UpdateSource();}catch(Exception ex){Log.ReportException("Audio","3D stream update failed",ex);}
        Bass.Apply();
    }
    public void Dispose()
    {if(handle==0)return;ModResources.Check(owner);Bass.Require(Bass.Free(handle),"Free stream");handle=0;Marshal.FreeHGlobal(buffer);buffer=IntPtr.Zero;attached=null;streams.Remove(this);ModResources.Forget(owner,this);}
    private static unsafe class Bass
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int InitCallback(int device,uint frequency,uint flags,IntPtr window,IntPtr clsid);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate uint CreateCallback(int memory,IntPtr file,ulong offset,ulong length,uint flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int HandleCallback(uint handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int PlayCallback(uint handle,int restart);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int AttributeCallback(uint handle,uint attribute,float value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int PositionCallback(uint handle,Vector3* position,Vector3* orientation,Vector3* velocity);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int ListenerCallback(Vector3* position,Vector3* velocity,Vector3* front,Vector3* top);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate int AttributesCallback(uint handle,int mode,float minimum,float maximum,int inside,int outside,float outsideVolume);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] internal delegate void ApplyCallback();
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] private delegate int ErrorCallback();
        [UnmanagedFunctionPointer(CallingConvention.StdCall)] private delegate uint VersionCallback();
        internal static CreateCallback Create=null!;internal static HandleCallback Free=null!,Pause=null!,Stop=null!;
        internal static PlayCallback Play=null!;internal static AttributeCallback Attribute=null!;
        internal static PositionCallback Position3D=null!;internal static ListenerCallback Listener=null!;internal static AttributesCallback Attributes3D=null!;internal static ApplyCallback Apply=null!;
        private static ErrorCallback error=null!;private static IntPtr library;private static bool initialized;
        private static T Get<T>(string name) where T:Delegate=>Marshal.GetDelegateForFunctionPointer<T>(NativeLibrary.GetExport(library,name));
        internal static void Initialize()
        {
            if(initialized)return;
            if(library==IntPtr.Zero) {
                string runtime=Path.GetDirectoryName(typeof(Game).Assembly.Location)!;
                string file=Path.GetFullPath(Path.Combine(runtime,"..","Libraries","bass.dll"));
                if(!File.Exists(file))throw new FileNotFoundException("AudioStream3D requires the optional x86 BASS 2.4 bass.dll in SharpAndreas/Libraries.",file);
                library=NativeLibrary.Load(file);
            }
            if((Get<VersionCallback>("BASS_GetVersion")()>>16)!=0x204)throw new NotSupportedException("AudioStream3D requires BASS 2.4.");
            error=Get<ErrorCallback>("BASS_ErrorGetCode");
            if(Get<InitCallback>("BASS_Init")(-1,44100,4,IntPtr.Zero,IntPtr.Zero)==0 && error()!=14)throw Error("Initialize BASS");
            Create=Get<CreateCallback>("BASS_StreamCreateFile");Free=Get<HandleCallback>("BASS_StreamFree");Pause=Get<HandleCallback>("BASS_ChannelPause");Stop=Get<HandleCallback>("BASS_ChannelStop");Play=Get<PlayCallback>("BASS_ChannelPlay");Attribute=Get<AttributeCallback>("BASS_ChannelSetAttribute");Position3D=Get<PositionCallback>("BASS_ChannelSet3DPosition");Listener=Get<ListenerCallback>("BASS_Set3DPosition");Attributes3D=Get<AttributesCallback>("BASS_ChannelSet3DAttributes");Apply=Get<ApplyCallback>("BASS_Apply3D");initialized=true;
        }
        internal static Exception Error(string operation)=>new InvalidOperationException($"{operation}: BASS error {error()}.");
        internal static void Require(int success,string operation) {if(success==0)throw Error(operation);}
    }
}
