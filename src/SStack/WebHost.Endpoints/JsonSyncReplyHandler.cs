using SStack.Common.Web;
using SStack.ServiceHost;

namespace SStack.WebHost.Endpoints
{
    public class JsonAsyncOneWayHandler : GenericHandler
    {
        public JsonAsyncOneWayHandler()
            : base(ContentType.Json, EndpointAttributes.OneWay | EndpointAttributes.Json, Feature.Json)
        {
        }
    }

    public class JsonSyncReplyHandler : GenericHandler
    {
        public JsonSyncReplyHandler()
            : base(ContentType.Json, EndpointAttributes.Reply | EndpointAttributes.Json, Feature.Json)
        {
        }
    }
}
