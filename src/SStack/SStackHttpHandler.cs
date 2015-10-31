using System.Web;
using SStack.ServiceHost;
using SStack.WebHost.Endpoints.Extensions;
using SStack.WebHost.Endpoints.Support;

namespace SStack
{
    public class SStackHttpHandler : IHttpHandler, ISStackHttpHandler
    {
        ISStackHttpHandler SStackHandler;

        public SStackHttpHandler(ISStackHttpHandler SStackHandler)
        {
            this.SStackHandler = SStackHandler;
        }

        public virtual void ProcessRequest(HttpContext context)
        {
            ProcessRequest(
                context.Request.ToRequest(), 
                context.Response.ToResponse(),
                null);
        }

        public bool IsReusable
        {
            get { return false; }
        }

        public virtual void ProcessRequest(IHttpRequest httpReq, IHttpResponse httpRes, string operationName)
        {
            SStackHandler.ProcessRequest(httpReq, httpRes, operationName ?? httpReq.OperationName);
        }
    }
}
