using System;

namespace SStack.DesignPatterns.Model
{
	public interface IHasUserSession
	{
		Guid UserId { get; }

		Guid SessionId { get; }
	}
}
