using System.Collections.Generic;
using SStack.WebHost.Endpoints;

namespace SStack.Html
{
	public interface ITemplatePage
	{
        IViewEngine ViewEngine { get; set; }
        IAppHost AppHost { get; set; }
		T Get<T>();
		Dictionary<string, object> ScopeArgs { get; set; }
	}
}
