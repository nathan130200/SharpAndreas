// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.
#nullable enable
#pragma warning disable CS0108, CS0114
namespace SharpAndreas.Sdk;
public class CText : NativeObject
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public const int NativeSize=2704;
    public CText(System.IntPtr pointer) : base(pointer) {}
    [NativeMember("tkeyMain")]
    public CText__TKey @TkeyMain { get => new CText__TKey(Pointer+0); set { SdkMemory.Copy(value.Pointer,Pointer+0,8); } }
    [NativeMember("tdatMain")]
    public CText__TDat @TdatMain { get => new CText__TDat(Pointer+8); set { SdkMemory.Copy(value.Pointer,Pointer+8,8); } }
    [NativeMember("tkeyMission")]
    public CText__TKey @TkeyMission { get => new CText__TKey(Pointer+16); set { SdkMemory.Copy(value.Pointer,Pointer+16,8); } }
    [NativeMember("tdatMission")]
    public CText__TDat @TdatMission { get => new CText__TDat(Pointer+24); set { SdkMemory.Copy(value.Pointer,Pointer+24,8); } }
    [NativeMember("encoding")]
    public sbyte @Encoding { get => SdkMemory.Read<sbyte >(Pointer+32); set { SdkMemory.Write(Pointer+32,value); } }
    [NativeMember("haveTabl")]
    public sbyte @HaveTabl { get => SdkMemory.Read<sbyte >(Pointer+33); set { SdkMemory.Write(Pointer+33,value); } }
    [NativeMember("cderrorInitialized")]
    public sbyte @CderrorInitialized { get => SdkMemory.Read<sbyte >(Pointer+34); set { SdkMemory.Write(Pointer+34,value); } }
    [NativeMember("missionTableLoaded")]
    public sbyte @MissionTableLoaded { get => SdkMemory.Read<sbyte >(Pointer+35); set { SdkMemory.Write(Pointer+35,value); } }
    [NativeMember("missionTableName")]
    public NativeArray<sbyte> @MissionTableName { get => new NativeArray<sbyte>(Pointer+36,8); }
    [NativeMember("cderrorText")]
    public NativeArray<sbyte> @CderrorText { get => new NativeArray<sbyte>(Pointer+44,256); }
    [NativeMember("tabl")]
    public CText__Tabl @Tabl { get => new CText__Tabl(Pointer+300); set { SdkMemory.Copy(value.Pointer,Pointer+300,2404); } }
    public void @InitializeAt() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4064 >(4064)(Pointer); }
    public void @DestroyNative() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4065 >(4065)(Pointer); }
    public NativePointer<sbyte> @Get(NativePointer<sbyte> @key) { Game.CheckThread(); var __sdkResult=SdkBindings.Get<GeneratedDelegates.D4066 >(4066)(Pointer,@key.Pointer); return new NativePointer<sbyte>(__sdkResult); }
    public static void @readTag(NativePointer<sbyte> @buf,_iobuf? @file,NativePointer<int> @pFileOffset,bool @dontRead) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4067 >(4067)(@buf.Pointer,@file?.Pointer ?? IntPtr.Zero,@pFileOffset.Pointer,(@dontRead ? 1 : 0)); }
    public void @LoadMissionTable(NativePointer<sbyte> @tableName) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4068 >(4068)(Pointer,@tableName.Pointer); }
    public void @LoadMpack() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4069 >(4069)(Pointer); }
    public void @Load() { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4070 >(4070)(Pointer); }
    public void @Unload(bool @bUnloadMissionData) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4071 >(4071)(Pointer,(@bUnloadMissionData ? 1 : 0)); }
    public void @getMissionTableName(NativePointer<sbyte> @outStr) { Game.CheckThread(); SdkBindings.Get<GeneratedDelegates.D4072 >(4072)(Pointer,@outStr.Pointer); }
}
