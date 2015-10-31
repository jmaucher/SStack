using System.Web;
using SStack.ServiceHost;

namespace SStack.WebHost.Endpoints.Support
{
	public interface ISStackHttpHandler
	{
		void ProcessRequest(IHttpRequest httpReq, IHttpResponse httpRes, string operationName);
	}
}
