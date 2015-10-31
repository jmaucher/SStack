using System;

namespace SStack.ServiceClient.Web
{
    [Obsolete("Moved to SStack.Common.Web.HttpMethods")]
    public static class HttpMethod
    {
        public const string Get = "GET";
        public const string Put = "PUT";
        public const string Post = "POST";
        public const string Delete = "DELETE";
        public const string Options = "OPTIONS";
        public const string Head = "HEAD";
        public const string Patch = "PATCH";
    }
}
