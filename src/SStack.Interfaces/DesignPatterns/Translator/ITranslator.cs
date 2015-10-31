namespace SStack.DesignPatterns.Translator
{
    public interface ITranslator<To, From>
    {
        To Parse(From from);
    }
}
