using SStack.Text;

namespace SStack.Html
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString AsRawJson<T>(this T model)
        {
            return MvcHtmlString.Create(model.ToJson());
        }

        public static MvcHtmlString AsRaw<T>(this T model)
        {
            return MvcHtmlString.Create(
                (model != null ? model : default(T)).ToString());
        }
    }
}
