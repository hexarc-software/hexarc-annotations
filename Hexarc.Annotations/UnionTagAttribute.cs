using System;

namespace Hexarc.Annotations
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class UnionTagAttribute : Attribute
    {
        public String TagPropertyName { get; }

        public UnionTagAttribute(String tagPropertyName) =>
            this.TagPropertyName = tagPropertyName;
    }
}
