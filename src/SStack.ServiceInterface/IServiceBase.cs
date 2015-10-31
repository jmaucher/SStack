using SStack.ServiceHost;
using SStack.WebHost.Endpoints;

namespace SStack.ServiceInterface
{
    public interface IServiceBase : IResolver
    {
        IResolver GetResolver();

        /// <summary>
        /// Resolve an alternate Web Service from SStack's IOC container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T ResolveService<T>();

        IRequestContext RequestContext { get; }
    }
}
