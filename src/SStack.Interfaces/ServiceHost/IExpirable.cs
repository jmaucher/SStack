using System;

namespace SStack.WebHost.Endpoints.Support.Markdown
{
	public interface IExpirable
	{
		DateTime? LastModified { get; }
	}
}
