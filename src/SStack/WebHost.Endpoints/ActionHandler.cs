using System;
using System.Web;
using SStack.ServiceHost;
using SStack.WebHost.Endpoints.Extensions;
using SStack.WebHost.Endpoints.Support;

namespace SStack.WebHost.Endpoints
{
    public class ActionHandler : ISStackHttpHandler, IHttpHandler 
    {
        public string OperationName { get; set; }

        public Func<IHttpRequest, IHttpResponse, object> Action { get; set; }

        public ActionHandler(Func<IHttpRequest, IHttpResponse, object> action, string operationName=null)
        {
            Action = action;
            OperationName = operationName;
        }

        public void ProcessRequest(IHttpRequest httpReq, IHttpResponse httpRes, string operationName)
        {
            if (Action == null)
                throw new Exception("Action was not supplied to ActionHandler");
            
            if (httpReq.OperationName == null)
                httpReq.SetOperationName(OperationName);

            var response = Action(httpReq, httpRes);
            httpRes.WriteToResponse(httpReq, response);
        }

        public void ProcessRequest(HttpContext context)
        {
            ProcessRequest(context.Request.ToRequest(OperationName), 
                context.Response.ToResponse(),
                OperationName);
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}
