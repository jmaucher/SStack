using System;

namespace SStack.DesignPatterns.Serialization
{
    public interface IStringDeserializer
    {
        To Parse<To>(string serializedText);
        object Parse(string serializedText, Type type);
    }
}
