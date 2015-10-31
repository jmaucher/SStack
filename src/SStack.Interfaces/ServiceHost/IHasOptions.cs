using System.Collections.Generic;

namespace SStack.ServiceHost
{
	public interface IHasOptions
	{
		IDictionary<string, string> Options { get; }
	}
}
