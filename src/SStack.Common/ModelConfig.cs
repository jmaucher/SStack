using System;
using SStack.Common.Utils;

namespace SStack
{
    public class ModelConfig<T>
    {
        public static void Id(Func<T, object> getIdFn)
        {
            IdUtils<T>.CanGetId = getIdFn;
        }
    }
}
