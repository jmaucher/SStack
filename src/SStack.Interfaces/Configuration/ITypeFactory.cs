using System;

namespace SStack.Configuration
{
	public interface ITypeFactory
	{
		object CreateInstance(Type type);
	}
}
