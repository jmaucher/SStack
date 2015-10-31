using System;
using Proxy = SStack.Common.ByteArrayExtensions;

namespace SStack.Common.Extensions
{
    [Obsolete("Use SStack.Common.ByteArrayExtensions")]
    public static class ByteArrayExtensions
    {
        public static bool AreEqual(this byte[] b1, byte[] b2)
        {
            return Proxy.AreEqual(b1, b2);
        }
    }
}
