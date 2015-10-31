namespace SStack.CacheAccess
{
	public interface IDeflateProvider
	{
		byte[] Deflate(string text);
		
		string Inflate(byte[] gzBuffer);
	}
}
