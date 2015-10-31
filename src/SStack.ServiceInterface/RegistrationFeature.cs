using System;
using SStack.FluentValidation;
using SStack.ServiceInterface.Auth;
using SStack.WebHost.Endpoints;

namespace SStack.ServiceInterface
{
    /// <summary>
    /// Enable the Registration feature and configure the RegistrationService.
    /// </summary>
    public class RegistrationFeature : IPlugin
    {
        public string AtRestPath { get; set; }

        public RegistrationFeature()
        {
            this.AtRestPath = "/register";
        }

        public void Register(IAppHost appHost)
        {
            appHost.RegisterService<RegistrationService>(AtRestPath);
            appHost.RegisterAs<RegistrationValidator, IValidator<Registration>>();
        }
    }
}
