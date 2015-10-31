using System;

namespace SStack
{
	public interface IViewPage
	{
		bool IsCompiled { get; }

		void Compile(bool force=false);
	}
}

