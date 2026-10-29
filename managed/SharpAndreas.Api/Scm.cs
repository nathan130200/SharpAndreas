using System.Runtime.InteropServices;
using System.Text;

namespace SharpAndreas;

/// <summary>A numeric SCM local variable. May be used as an input/output argument.</summary>
public sealed class ScmVariable
{
    public int Int32 { get; set; }
    public float Single { get => BitConverter.Int32BitsToSingle(Int32); set => Int32 = BitConverter.SingleToInt32Bits(value); }
    public ScmVariable(int value = 0) => Int32 = value;
}

public readonly struct ScmArgument
{
    internal readonly byte Type;
    internal readonly int Bits;
    internal readonly string? Text;
    internal readonly ScmVariable? Variable;
    private ScmArgument(byte type, int bits = 0, string? text = null, ScmVariable? variable = null)
    { Type = type; Bits = bits; Text = text; Variable = variable; }
    public static implicit operator ScmArgument(int value) => new(1, value);
    public static implicit operator ScmArgument(bool value) => new(1, value ? 1 : 0);
    public static implicit operator ScmArgument(float value) => new(6, BitConverter.SingleToInt32Bits(value));
    public static implicit operator ScmArgument(string value) => new(14, text: value ?? throw new ArgumentNullException(nameof(value)));
    public static implicit operator ScmArgument(ScmVariable value) => new(3, variable: value ?? throw new ArgumentNullException(nameof(value)));
    public static implicit operator ScmArgument(Entity value) => new(1, (value ?? throw new ArgumentNullException(nameof(value))).Handle);
    /// <summary>An SCM fixed eight-byte text label (for example a GXT key).</summary>
    public static ScmArgument Label(string value) => new(9, text: value ?? throw new ArgumentNullException(nameof(value)));
}

public static class Scm
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate int InvokeCallback([In] byte[] code, int codeSize, [In, Out] int[] locals, int localCount, out int condition);
    private static InvokeCallback invoke = null!;
    internal static void Bind(IntPtr callback) => invoke = Marshal.GetDelegateForFunctionPointer<InvokeCallback>(callback);

    /// <summary>Executes one synchronous stock SA opcode. The return value is the SCM condition flag, not a success flag.</summary>
    public static bool Call(ushort opcode, params ScmArgument[] arguments)
    {
        Game.CheckThread();
        ArgumentNullException.ThrowIfNull(arguments);
        if (arguments.Length > 64) throw new ArgumentException("At most 64 SCM parameters are supported.", nameof(arguments));
        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream, Encoding.ASCII);
        writer.Write(opcode);
        var variables = new List<ScmVariable>();
        foreach (var argument in arguments)
        {
            writer.Write(argument.Type);
            switch (argument.Type)
            {
                case 1: case 6: writer.Write(argument.Bits); break;
                case 3:
                    int index = variables.IndexOf(argument.Variable!);
                    if (index < 0) { index = variables.Count; variables.Add(argument.Variable!); }
                    if (index >= 32) throw new ArgumentException("At most 32 distinct numeric SCM variables are supported.");
                    writer.Write((ushort)index);
                    break;
                case 9: case 14:
                    string text = argument.Text!;
                    int limit = argument.Type == 9 ? 8 : 255;
                    if (text.Length > limit || text.Any(c => c == '\0' || c > 127))
                        throw new ArgumentException($"SCM strings require at most {limit} non-null ASCII characters.");
                    byte[] encoded = Encoding.ASCII.GetBytes(text);
                    if (argument.Type == 14) writer.Write((byte)encoded.Length);
                    writer.Write(encoded);
                    if (argument.Type == 9) writer.Write(new byte[8 - encoded.Length]);
                    break;
                default: throw new ArgumentException("Uninitialized SCM argument.");
            }
        }
        writer.Write((byte)0); // Terminator for vararg commands; ignored by fixed-arity commands.
        byte[] code = stream.ToArray();
        if (code.Length > 4096) throw new ArgumentException("SCM command exceeds 4096 bytes.");
        int[] locals = new int[32];
        for (int i = 0; i < variables.Count; i++) locals[i] = variables[i].Int32;
        int status = invoke(code, code.Length, locals, locals.Length, out int condition);
        if (status < 0) throw new InvalidOperationException($"SCM 0x{opcode:X4} rejected ({status}). Use synchronous stock opcodes with their exact signatures; WAIT/jumps/script control and CLEO opcodes are unsupported.");
        for (int i = 0; i < variables.Count; i++) variables[i].Int32 = locals[i];
        return condition != 0;
    }
    public static bool Call(ScmOpcode opcode, params ScmArgument[] arguments) => Call((ushort)opcode, arguments);
}

/// <summary>Common stock SA commands. Additional stock commands can be invoked by numeric opcode.</summary>
public enum ScmOpcode : ushort
{
    Nop = 0x0000, SetLocalInt = 0x0006, SetLocalFloat = 0x0007,
    CreateChar = 0x009A, DeleteChar = 0x009B, GetCharCoordinates = 0x00A0, SetCharCoordinates = 0x00A1,
    CreateCar = 0x00A5, DeleteCar = 0x00A6, GetCarCoordinates = 0x00AA, SetCarCoordinates = 0x00AB,
    StoreCarCharIsIn = 0x00D9, IsCharInAnyCar = 0x00DF,
    CreateObject = 0x0107, DeleteObject = 0x0108,
    GetCharHeading = 0x0172, SetCharHeading = 0x0173, GetCarHeading = 0x0174, SetCarHeading = 0x0175,
    GetObjectHeading = 0x0176, SetObjectHeading = 0x0177, SetPlayerControl = 0x01B4,
    GetObjectCoordinates = 0x01BB, SetObjectCoordinates = 0x01BC, GetGameTimer = 0x01BD,
    MarkCharAsNoLongerNeeded = 0x01C2, MarkCarAsNoLongerNeeded = 0x01C3, MarkObjectAsNoLongerNeeded = 0x01C4,
    GetPlayerChar = 0x01F5, SetCharHealth = 0x0223, SetCarHealth = 0x0224, GetCharHealth = 0x0226, GetCarHealth = 0x0227,
    RequestModel = 0x0247, HasModelLoaded = 0x0248, MarkModelAsNoLongerNeeded = 0x0249, IsPlayerPlaying = 0x0256,
    AddArmourToChar = 0x035F, DoesObjectExist = 0x03CA, GetCarModel = 0x0441, GetCharArmour = 0x04DD,
    DoesCharExist = 0x056D, DoesVehicleExist = 0x056E, GetCharModel = 0x0665, GetPlayerGroup=0x07AF, GetObjectModel = 0x0984
}
