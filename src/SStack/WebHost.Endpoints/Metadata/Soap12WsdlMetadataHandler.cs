using SStack.WebHost.Endpoints.Support.Metadata;
using SStack.WebHost.Endpoints.Support.Templates;

namespace SStack.WebHost.Endpoints.Metadata
{
	public class Soap12WsdlMetadataHandler : WsdlMetadataHandlerBase
	{
		protected override WsdlTemplateBase GetWsdlTemplate()
		{
			return new Soap12WsdlTemplate();
		}
	}
}
