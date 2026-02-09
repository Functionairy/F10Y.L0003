using System;
using System.Collections.Generic;

using For_System = System.Collections.Generic;


namespace F10Y.L0003.Extensions
{
    public static class CollectionExtensions
    {
        public static IDistinctCollection<TValue> As_Distinct<TValue>(this ICollection<TValue> collection)
            => Instances.CollectionOperator.As_Distinct(collection);

        public static IDistinctCollection<TValue> As_DistinctCollection<TValue>(this ICollection<TValue> collection)
            => Instances.CollectionOperator.As_Distinct(collection);

        public static IDistinctReadOnlyCollection<T> As_ReadOnly<T>(this IDistinctCollection<T> collection_Distinct)
            => Instances.CollectionOperator.As_ReadOnly(collection_Distinct);

        public static IDistinctCollection<TValue> Get_Distinct<TValue>(this ICollection<TValue> collection,
            For_System.IEqualityComparer<TValue> equalityComparer)
            => Instances.CollectionOperator.Get_Distinct(
                collection,
                equalityComparer);

        public static IDistinctCollection<TValue> Get_Distinct<TValue>(this ICollection<TValue> collection)
            => Instances.CollectionOperator.Get_Distinct(collection);
    }
}
