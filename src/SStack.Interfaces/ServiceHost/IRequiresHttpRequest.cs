using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SStack.ServiceHost
{
	public interface IRequiresHttpRequest
	{
		IHttpRequest HttpRequest { get; set; }
	}
}
