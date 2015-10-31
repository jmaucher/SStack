using System;

namespace SStack.Service
{
	public interface IServiceClientAsync : IRestClientAsync
	{
		void SendAsync<TResponse>(object request, Action<TResponse> onSuccess, Action<TResponse, Exception> onError);
	}
}
