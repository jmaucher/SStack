using System;
using SStack.Common.Extensions;
using SStack.ServiceInterface.ServiceModel;

namespace SStack.ServiceInterface
{
    public class ServiceResponseException
        : Exception
    {
        public ServiceResponseException()
        {
        }

        public ServiceResponseException(string message)
            : base(message)
        {
        }

        public ServiceResponseException(string errorCode, string errorMessage)
            : base(GetErrorMessage(errorCode, errorMessage))
        {
            this.ErrorCode = errorCode;
        }

        public ServiceResponseException(string errorCode, string errorMessage, string SStackTrace)
            : base(errorMessage)
        {
            this.ErrorCode = errorCode;
            this.SStackTrace = SStackTrace;
        }

        public ServiceResponseException(ResponseStatus responseStatus)
            : base(GetErrorMessage(responseStatus.ErrorCode, responseStatus.Message))
        {
            this.ErrorCode = responseStatus.ErrorCode;
        }

        private static string GetErrorMessage(string errorCode, string errorMessage)
        {
            return errorMessage ?? (errorCode != null ? errorCode.ToEnglish() : null); 
        }

        public string ErrorCode { get; set; }

        public string SStackTrace { get; set; }
    }
}
