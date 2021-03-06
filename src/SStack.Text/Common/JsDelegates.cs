//
// https://github.com/SStack/SStack.Text
// SStack.Text: .NET C# POCO JSON, JSV and CSV Text Serializers.
//
// Authors:
//   Demis Bellot (demis.bellot@gmail.com)
//
// Copyright 2012 SStack Ltd.
//
// Licensed under the same terms of SStack: new BSD license.
//

using System;
using System.Collections.Generic;
using System.IO;

namespace SStack.Text.Common
{
    internal delegate void WriteListDelegate(TextWriter writer, object oList, WriteObjectDelegate toStringFn);

    internal delegate void WriteGenericListDelegate<T>(TextWriter writer, IList<T> list, WriteObjectDelegate toStringFn);

    internal delegate void WriteDelegate(TextWriter writer, object value);

    internal delegate ParseStringDelegate ParseFactoryDelegate();

    public delegate void WriteObjectDelegate(TextWriter writer, object obj);

    public delegate void SetPropertyDelegate(object instance, object propertyValue);

    public delegate object ParseStringDelegate(string stringValue);

    public delegate object ConvertObjectDelegate(object fromObject);

    public delegate object ConvertInstanceDelegate(object obj, Type type);

    public delegate void DeserializationErrorDelegate(object instance, Type propertyType, string propertyName, string propertyValueStr, Exception e);
}
