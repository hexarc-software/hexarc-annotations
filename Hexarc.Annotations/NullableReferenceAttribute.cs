namespace Hexarc.Annotations;

using System;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.ReturnValue | AttributeTargets.Parameter)]
public sealed class NullableReferenceAttribute : Attribute { }
