using System;
using System.Collections.Generic;

namespace SStack.DesignPatterns.Model
{
	public interface IHasNamedList<T> : IHasNamed<IList<T>>
	{
	}
}
