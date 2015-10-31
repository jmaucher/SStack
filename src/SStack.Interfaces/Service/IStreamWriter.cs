using System.IO;

namespace SStack.Service
{
	public interface IStreamWriter
	{
		void WriteTo(Stream responseStream);
	}
}
