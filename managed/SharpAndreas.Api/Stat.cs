namespace SharpAndreas;
/// <summary>Persistent game statistics. Use the storage type appropriate to the selected stock statistic.</summary>
public static class Stat
{
    private static void Check(StatType type) {if(!Enum.IsDefined(type))throw new ArgumentOutOfRangeException(nameof(type));}
    public static int GetInt(StatType type) {Check(type);return Commands.Int(0x0652,(int)type);}
    public static float GetFloat(StatType type) {Check(type);return Commands.Float(0x0653,(int)type);}
    public static void SetInt(StatType type,int value) {Check(type);Scm.Call((ushort)0x0629,(int)type,value);}
    public static void SetFloat(StatType type,float value) {Check(type);Commands.Finite(value);Scm.Call((ushort)0x062A,(int)type,value);}
    public static void IncrementInt(StatType type,int amount,bool showMessage=true) {Check(type);Scm.Call(showMessage?(ushort)0x0623:(ushort)0x0A10,(int)type,amount);}
    public static void IncrementFloat(StatType type,float amount,bool showMessage=true) {Check(type);Commands.Finite(amount);Scm.Call(showMessage?(ushort)0x0624:(ushort)0x0A1F,(int)type,amount);}
}
