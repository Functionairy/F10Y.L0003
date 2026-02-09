using System;
using System.Collections.Generic;

using For_System = System.Collections.Generic;


namespace F10Y.L0003.Extensions
{
    public static class ReadOnlyCollectionExtensions
    {
        public static IDistinctReadOnlyCollection<TValue> As_DistinctReadOnly<TValue>(this IReadOnlyCollection<TValue> collection_ReadOnly)
            => Instances.ReadOnlyCollectionOperator.As_Distinct(collection_ReadOnly);
    }
}
