#if !SILVERLIGHT && !MONOTOUCH && !XBOX && !ANDROIDINDIE
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SStack.ServiceClient.Web
{
    [ServiceContract(Namespace = "http://services.SStack.net/", CallbackContract = typeof(IDuplexCallback))]
    public interface IDuplex
    {
        [OperationContract(Action = "*", ReplyAction = "*")]
        void BeginSend(Message msg);
    }
}
#endif
