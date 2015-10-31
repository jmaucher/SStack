namespace SStack.ServiceInterface
{
    public class Config
    {
        /// <summary>
        /// Would've preferred to use [assembly: ContractNamespace] attribute but it is not supported in Mono
        /// </summary>
        //public const string DefaultNamespace = "http://schemas.sericestack.net/examples/types";
        public const string DefaultNamespace = "http://schemas.SStack.net/types";

        public const string SStackBaseUri = "http://localhost:20000";
        public const string AbsoluteBaseUri = SStackBaseUri + "/";
    }
}
