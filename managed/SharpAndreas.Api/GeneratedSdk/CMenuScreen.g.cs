// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CMenuScreen : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=226;
    public CMenuScreen(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("m_ScreenName")]
    public NativeArray<sbyte> @ScreenName { get => new NativeArray<sbyte>(Pointer+0,8); }
    [NativeMember("m_nPreviousPage")]
    public sbyte @PreviousPage { get => SdkMemory.Read<sbyte >(Pointer+8); set { SdkMemory.Write(Pointer+8,value); } }
    [NativeMember("m_nParentEntry")]
    public sbyte @ParentEntry { get => SdkMemory.Read<sbyte >(Pointer+9); set { SdkMemory.Write(Pointer+9,value); } }
    [NativeMember("m_aEntries")]
    public NativeObjectArray<CMenuScreen__CMenuEntry> @Entries { get => new NativeObjectArray<CMenuScreen__CMenuEntry>(Pointer+10,12,18); }
}
