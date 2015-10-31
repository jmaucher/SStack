using System.ServiceModel.Channels;

namespace SStack.ServiceHost
{
    public interface IRequiresSoapMessage
    {
        Message Message { get; set; }
    }
}
