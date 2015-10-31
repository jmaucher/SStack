using System.Collections.Generic;
using System.Web;
using SStack.Common;
using SStack.ServiceHost;
using SStack.Text;
using SStack.WebHost.Endpoints.Extensions;

namespace SStack.WebHost.Endpoints.Support
{
    public class ForbiddenHttpHandler
        : ISStackHttpHandler, IHttpHandler
    {
		public bool? IsIntegratedPipeline { get; set; }
		public string WebHostPhysicalPath { get; set; }
		public List<string> WebHostRootFileNames { get; set; }
		public string ApplicationBaseUrl { get; set; }
		public string DefaultRootFileName { get; set; }
		public string DefaultHandler { get; set; }

        public void ProcessRequest(IHttpRequest request, IHttpResponse response, string operationName)
        {
            response.ContentType = "text/plain";
            response.StatusCode = 403;

		    response.EndHttpHandlerRequest(skipClose: true, afterBody: r => {
                r.Write("Forbidden\n\n");

                r.Write("\nRequest.HttpMethod: " + request.HttpMethod);
                r.Write("\nRequest.PathInfo: " + request.PathInfo);
                r.Write("\nRequest.QueryString: " + request.QueryString);
                r.Write("\nRequest.RawUrl: " + request.RawUrl);

                if (IsIntegratedPipeline.HasValue)
                    r.Write("\nApp.IsIntegratedPipeline: " + IsIntegratedPipeline);
                if (!WebHostPhysicalPath.IsNullOrEmpty())
                    r.Write("\nApp.WebHostPhysicalPath: " + WebHostPhysicalPath);
                if (!WebHostRootFileNames.IsEmpty())
                    r.Write("\nApp.WebHostRootFileNames: " + TypeSerializer.SerializeToString(WebHostRootFileNames));
                if (!ApplicationBaseUrl.IsNullOrEmpty())
                    r.Write("\nApp.ApplicationBaseUrl: " + ApplicationBaseUrl);
                if (!DefaultRootFileName.IsNullOrEmpty())
                    r.Write("\nApp.DefaultRootFileName: " + DefaultRootFileName);
                if (!DefaultHandler.IsNullOrEmpty())
                    r.Write("\nApp.DefaultHandler: " + DefaultHandler);
                if (!SStackHttpHandlerFactory.DebugLastHandlerArgs.IsNullOrEmpty())
                    r.Write("\nApp.DebugLastHandlerArgs: " + SStackHttpHandlerFactory.DebugLastHandlerArgs);
            });
		}

        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            response.ContentType = "text/plain";
            response.StatusCode = 403;

            response.EndHttpHandlerRequest(skipClose:true, afterBody: r=> {
                r.Write("Forbidden\n\n");

                r.Write("\nRequest.HttpMethod: " + request.HttpMethod);
                r.Write("\nRequest.PathInfo: " + request.PathInfo);
                r.Write("\nRequest.QueryString: " + request.QueryString);
                r.Write("\nRequest.RawUrl: " + request.RawUrl);

                if (IsIntegratedPipeline.HasValue)
                    r.Write("\nApp.IsIntegratedPipeline: " + IsIntegratedPipeline);
                if (!WebHostPhysicalPath.IsNullOrEmpty())
                    r.Write("\nApp.WebHostPhysicalPath: " + WebHostPhysicalPath);
                if (!WebHostRootFileNames.IsEmpty())
                    r.Write("\nApp.WebHostRootFileNames: " + TypeSerializer.SerializeToString(WebHostRootFileNames));
                if (!ApplicationBaseUrl.IsNullOrEmpty())
                    r.Write("\nApp.ApplicationBaseUrl: " + ApplicationBaseUrl);
                if (!DefaultRootFileName.IsNullOrEmpty())
                    r.Write("\nApp.DefaultRootFileName: " + DefaultRootFileName);
            });
		}

        public bool IsReusable
        {
            get { return true; }
        }
    }
}
