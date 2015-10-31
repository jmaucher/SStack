using System.Net;
using SStack.ServiceHost;
using SStack.WebHost.Endpoints.Extensions;
using SStack.WebHost.Endpoints.Formats;

namespace SStack.WebHost.Endpoints.Support.Markdown
{
    public class MarkdownHandler : EndpointHandlerBase
    {
        public MarkdownFormat MarkdownFormat { get; set; }
        public MarkdownPage MarkdownPage { get; set; }
        public object Model { get; set; }

        public string PathInfo { get; set; }

        public MarkdownHandler(string pathInfo)
        {
            PathInfo = pathInfo;
        }

        public override void ProcessRequest(IHttpRequest httpReq, IHttpResponse httpRes, string operationName)
        {
            if (MarkdownFormat == null)
                MarkdownFormat = MarkdownFormat.Instance;

            var contentPage = MarkdownPage ?? MarkdownFormat.FindByPathInfo(PathInfo);
            if (contentPage == null)
            {
                httpRes.StatusCode = (int)HttpStatusCode.NotFound;
                httpRes.EndHttpHandlerRequest();
                return;
            }

            MarkdownFormat.ReloadModifiedPageAndTemplates(contentPage);

            if (httpReq.DidReturn304NotModified(contentPage.GetLastModified(), httpRes))
                return;

            var model = Model;
            if (model == null)
                httpReq.Items.TryGetValue("Model", out model);

            MarkdownFormat.ProcessMarkdownPage(httpReq, contentPage, model, httpRes);
        }

        public override object CreateRequest(IHttpRequest request, string operationName)
        {
            return null;
        }

        public override object GetResponse(IHttpRequest httpReq, IHttpResponse httpRes, object request)
        {
            return null;
        }
    }
}
