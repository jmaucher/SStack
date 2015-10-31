// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace SStack.Html.AntiXsrf
{
    // Provides an abstraction around the cryptographic subsystem for the anti-XSRF helpers.
    internal interface ICryptoSystem
    {
        string Protect(byte[] data);
        byte[] Unprotect(string protectedData);
    }
}
