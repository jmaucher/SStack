using System;

namespace SStack.ServiceHost
{
	public interface IRequestAttributes
	{
		bool AcceptsGzip { get; }

		bool AcceptsDeflate { get; }
	}
}
