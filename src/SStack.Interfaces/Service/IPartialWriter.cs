using System.IO;
using SStack.ServiceHost;

namespace SStack.Service
{
	public interface IPartialWriter
	{
        /// <summary>
        /// Whether this HttpResult allows Partial Response
        /// </summary>
        bool IsPartialRequest { get; }

        /// <summary>
        /// Write a partial content result
        /// </summary>
        void WritePartialTo(IHttpResponse response);
	}
}
