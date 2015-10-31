using System.Collections.Generic;
using System.IO;
using SStack.Markdown;

namespace SStack.WebHost.Endpoints.Support.Markdown
{
	public interface ITemplateWriter
	{
		void Write(MarkdownViewBase instance, TextWriter textWriter, Dictionary<string, object> scopeArgs);
	}
}
