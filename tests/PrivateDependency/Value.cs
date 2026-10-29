using System.Reflection;
public static class PrivateValue
{
    public static string Marker => typeof(PrivateValue).Assembly.GetCustomAttribute<AssemblyMetadataAttribute>()!.Value!;
}
