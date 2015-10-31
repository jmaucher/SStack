using System;
using System.Web.UI;
using SStack.Common.Utils;
using SStack.ServiceHost;
using SStack.ServiceModel.Serialization;
using SStack.Text;
using SStack.WebHost.Endpoints.Support.Metadata.Controls;

namespace SStack.WebHost.Endpoints.Metadata
{
    public class JsonMetadataHandler : BaseMetadataHandler
    {
        public override Format Format { get { return Format.Json; } }
		
		protected override string CreateMessage(Type dtoType)
        {
            var requestObj = ReflectionUtils.PopulateObject(dtoType.CreateInstance());
            return JsonDataContractSerializer.Instance.SerializeToString(requestObj);
        }

        protected override void RenderOperations(HtmlTextWriter writer, IHttpRequest httpReq, ServiceMetadata metadata)
        {
            var defaultPage = new OperationsControl
            {
				Title = EndpointHost.Config.ServiceName,
                OperationNames = metadata.GetOperationNamesForMetadata(httpReq, Format),
                MetadataOperationPageBodyHtml = EndpointHost.Config.MetadataOperationPageBodyHtml,
            };

            defaultPage.RenderControl(writer);
        }
    }
}
