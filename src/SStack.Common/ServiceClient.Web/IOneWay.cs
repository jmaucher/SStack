#if !SILVERLIGHT && !MONOTOUCH && !XBOX && !ANDROIDINDIE
using System.ServiceModel;
using System.ServiceModel.Channels;
using SStack.ServiceHost;

namespace SStack.ServiceClient.Web
{
    [ServiceContract(Namespace = "http://services.SStack.net/")]
    public interface IOneWay
    {
        [OperationContract(Action = "*", IsOneWay = true)]
        void SendOneWay(Message requestMsg);
    }
}
#endif
