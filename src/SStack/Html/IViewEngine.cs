using System.IO;
using SStack.ServiceHost;

namespace SStack.Html
{
    public interface IViewEngine
    {
        bool HasView(string viewName, IHttpRequest httpReq = null);
        string RenderPartial(string pageName, object model, bool renderHtml, StreamWriter writer = null, HtmlHelper htmlHelper = null);
        bool ProcessRequest(IHttpRequest httpReq, IHttpResponse httpRes, object dto);
    }
}
