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
using System.Reflection;

namespace SStack.Text.Common
{
    internal static class ParseUtils
    {
        public static object NullValueType(Type type)
        {
            return ReflectionExtensions.GetDefaultValue(type);
        }

        public static object ParseObject(string value)
        {
            return value;
        }

        public static object ParseEnum(Type type, string value)
        {
            return Enum.Parse(type, value, false);
        }

        public static ParseStringDelegate GetSpecialParseMethod(Type type)
        {
            if (type == typeof(Uri))
                return x => new Uri(x.FromCsvField());

            //Warning: typeof(object).IsInstanceOfType(typeof(Type)) == True??
            if (type.InstanceOfType(typeof(Type)))
                return ParseType;

            if (type == typeof(Exception))
                return x => new Exception(x);

            if (type.IsInstanceOf(typeof(Exception)))
                return DeserializeTypeUtils.GetParseMethod(type);

            return null;
        }

        public static Type ParseType(string assemblyQualifiedName)
        {
            return AssemblyUtils.FindType(assemblyQualifiedName.FromCsvField());
        }
    }

}
