namespace SharpAndreas;

/// <summary>Opt into Tick and captured async continuations while GTA is paused.</summary>
[AttributeUsage(AttributeTargets.Class,Inherited=true,AllowMultiple=false)]
public sealed class TickWhenPausedAttribute:Attribute { }
