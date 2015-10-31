using System;
using SStack.ServiceClient.Web;
using SStack.ServiceHost;
using SStack.Text;

namespace SStack.ServiceInterface
{
    /// <summary>
    /// Useful base functionality for IAsyncServices by serializing the request
    /// into the message queue configured by the AppHost if one is configured. 
    /// 
    /// This allows the request to persist for longer than the request duration 
    /// and can defer the execution of the async request under optimal execution.
    /// 
    /// If one is not configured it will Execute the request immediately as per normal.
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    [Obsolete("IAsyncService hae been merged into ServiceBase")]
    public abstract class AsyncServiceBase<TRequest> 
        : ServiceBase<TRequest>, IAsyncService<TRequest>
    {
        /// <summary>
        /// Persists the request into the registered message queue if configured, 
        /// otherwise calls Execute() to handle the request immediately.
        /// </summary>
        /// <param name="request"></param>
        public override object ExecuteAsync(TRequest request)
        {
            return WebRequestUtils.GetErrorResponseDtoType(request).CreateInstance();
        }
        

    }


}
