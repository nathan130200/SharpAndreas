// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CShinyTexts : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=1;
    public CShinyTexts(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("aShinyTexts")]
    public static CRegisteredShinyText? @ShinyTexts { get => new IntPtr(0xC7D258) == IntPtr.Zero ? null : new CRegisteredShinyText(new IntPtr(0xC7D258)); }
    [NativeMember("NumShinyTexts")]
    public static uint @CountShinyTexts { get => SdkMemory.Read<uint >(new IntPtr(0xC7C6F8)); set { SdkMemory.Write(new IntPtr(0xC7C6F8),value); } }
    public static void @Init() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3773 >(3773)(); }
    public static void @RenderOutGeometryBuffer() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3774 >(3774)(); }
    public static void @Render() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3775 >(3775)(); }
    public static void @RegisterOne(CVector @cornerAA,CVector @cornerBA,CVector @cornerBB,CVector @cornerAB,float @u1,float @v1,float @u2,float @v2,float @u3,float @v3,float @u4,float @v4,byte @red,byte @green,byte @blue,byte @alpha,float @maxDistance) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D3776 >(3776)(@cornerAA.Pointer,@cornerBA.Pointer,@cornerBB.Pointer,@cornerAB.Pointer,@u1,@v1,@u2,@v2,@u3,@v3,@u4,@v4,@red,@green,@blue,@alpha,@maxDistance); }
}
