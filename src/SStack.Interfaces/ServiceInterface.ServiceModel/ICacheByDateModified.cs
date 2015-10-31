using System;

namespace SStack.ServiceInterface.ServiceModel
{
	public interface ICacheByDateModified
	{
		DateTime? LastModified { get; }
	}
}
