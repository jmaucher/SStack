using System;

namespace SStack.DataAnnotations
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class AutoIncrementAttribute : Attribute
	{
	}
}
