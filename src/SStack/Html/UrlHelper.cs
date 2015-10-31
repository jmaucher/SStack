using System.Web;

namespace SStack.Html
{
	public class UrlHelper
	{
		public string Content(string url)
		{
		    return VirtualPathUtility.ToAbsolute(url);
		}
	}
}
