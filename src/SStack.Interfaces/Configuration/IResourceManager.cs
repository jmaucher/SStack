using System.Collections.Generic;

namespace SStack.Configuration
{
	public interface IResourceManager
	{
		string GetString(string name);

		IList<string> GetList(string key);

		IDictionary<string, string> GetDictionary(string key);

		T Get<T>(string name, T defaultValue);
	}
}
