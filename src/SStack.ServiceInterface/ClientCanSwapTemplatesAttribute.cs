using System;
using SStack.ServiceHost;

namespace SStack.ServiceInterface
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class ClientCanSwapTemplatesAttribute : RequestFilterAttribute
    {
        public override void Execute(IHttpRequest req, IHttpResponse res, object requestDto)
        {
            req.Items["View"] = req.GetParam("View");
            req.Items["Template"] = req.GetParam("Template");
        }
    }
}
