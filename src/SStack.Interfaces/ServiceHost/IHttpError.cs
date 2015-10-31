namespace SStack.ServiceHost
{
	public interface IHttpError : IHttpResult
	{
		string Message { get; }
		string ErrorCode { get; }
	}
}
