#if !SILVERLIGHT && !MONOTOUCH && !XBOX && !ANDROIDINDIE
using System.ServiceModel;
using System.ServiceModel.Channels;
using SStack.ServiceHost;

namespace SStack.ServiceClient.Web
{
    [ServiceContract(Namespace = "http://services.SStack.net/")]
    public interface ISyncReply
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        Message Send(Message requestMsg);
    }
}
#endif
