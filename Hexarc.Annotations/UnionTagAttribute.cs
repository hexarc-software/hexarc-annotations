﻿namespace Hexarc.Annotations;

using System;

[AttributeUsage(AttributeTargets.Class)]
public sealed class UnionTagAttribute : Attribute
{
    public String TagPropertyName { get; }

    public UnionTagAttribute(String tagPropertyName) =>
        this.TagPropertyName = tagPropertyName;
}
