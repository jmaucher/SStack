#if !SILVERLIGHT && !MONOTOUCH && !XBOX && !ANDROIDINDIE
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SStack.ServiceClient.Web
{
    [ServiceContract(Namespace = "http://services.SStack.net/")]
    public interface IDuplexCallback
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        void OnMessageReceived(Message msg);
    }
}
#endif
