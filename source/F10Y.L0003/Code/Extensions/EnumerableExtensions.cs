using System;
using System.Collections.Generic;

using For_System = System.Collections.Generic;


namespace F10Y.L0003.Extensions
{
    public static class EnumerableExtensions
    {
        public static ICollection<TValue> As_Collection<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.CollectionOperator.As_Collection(enumerable);

        public static IDistinctEnumerable<TValue> As_Distinct<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.As_Distinct(enumerable);

        public static IDistinctEnumerable<TValue> As_DistinctEnumerable<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.As_Distinct(enumerable);

        public static IDistinctCollection<TValue> To_DistinctCollection<TValue>(this IEnumerable<TValue> enumerable,
            For_System.IEqualityComparer<TValue> equalityComparer)
            => Instances.EnumerableOperator.To_DistinctCollection(enumerable, equalityComparer);

        public static IDistinctCollection<TValue> To_DistinctCollection<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.To_DistinctCollection(enumerable);

        public static IDistinctCollection<TValue> To_DistinctCollection<TValue>(this IDistinctEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.To_DistinctCollection(enumerable);

        public static IDistinctReadOnlyCollection<TValue> To_DistinctReadOnlyCollection<TValue>(this IDistinctEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.To_DistinctReadOnlyCollection(enumerable);

        public static IDistinctEnumerable<TValue> Get_Distinct<TValue>(this IEnumerable<TValue> enumerable,
            For_System.IEqualityComparer<TValue> equalityComparer)
            => Instances.EnumerableOperator.Get_Distinct(
                enumerable,
                equalityComparer);

        public static IDistinctEnumerable<TValue> Get_Distinct<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.Get_Distinct(enumerable);

        public static DistinctArray<TValue> To_Array_Distinct<TValue>(this IDistinctEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.To_Array_Distinct(enumerable);

        public static DistinctArray<TValue> To_Array_Distinct<TValue>(this IEnumerable<TValue> enumerable,
            For_System.IEqualityComparer<TValue> equalityComparer)
            => Instances.EnumerableOperator.To_Array_Distinct(
                enumerable,
                equalityComparer);

        public static IDistinctEnumerable<TValue> To_Distinct<TValue>(this IEnumerable<TValue> enumerable,
            For_System.IEqualityComparer<TValue> equalityComparer)
            => Instances.EnumerableOperator.Get_Distinct(
                enumerable,
                equalityComparer);

        public static IDistinctEnumerable<TValue> To_Distinct<TValue>(this IEnumerable<TValue> enumerable)
            => Instances.EnumerableOperator.Get_Distinct(enumerable);
    }
}
