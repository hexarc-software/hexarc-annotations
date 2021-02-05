using System;

namespace Hexarc.Annotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.ReturnValue | AttributeTargets.Parameter)]
    public sealed class NullableReferenceAttribute : Attribute { }
}
