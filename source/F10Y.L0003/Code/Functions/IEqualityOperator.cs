using System;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;

using For_System = System.Collections.Generic;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IEqualityOperator :
        L0000.IEqualityOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEqualityOperator _L0000 => L0000.EqualityOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <remarks>
        ///// Tuples are used to ensure there are the same number of elements in each set.
        ///// </remarks>
        //bool Are_Equal_OrderIndependentSets<T>(
        //    IDistinctEnumerable<(T, T)> pairs,
        //    For_System.IEqualityComparer<T> equalityComparer)
        //{
        //    var a = pairs.Select(pair => pair.Item1);
        //    var b = pairs.Select(pair => pair.Item1);

        //    var output = this.Are_Equal_OrderIndependentSets_UncheckedCounts(
        //        a,
        //        b,
        //        equalityComparer);

        //    return output;
        //}

        /// <summary>
        /// 
        /// </summary>
        bool Are_Equal_OrderIndependentSets<T>(
            IDistinctEnumerable<T> a,
            IDistinctEnumerable<T> b,
            For_System.IEqualityComparer<T> equalityComparer)
        {
            var areEqual_Counts = Instances.CountOperator.Are_Equal_Counts(
                a,
                b);

            if (!areEqual_Counts)
            {
                return false;
            }

            var output = this.Are_Equal_OrderIndependentSets_UncheckedCounts(a, b, equalityComparer);
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Input enumerables are assumed to be the same length.
        /// </remarks>
        bool Are_Equal_OrderIndependentSets_UncheckedCounts<T>(
            IDistinctEnumerable<T> a,
            IDistinctEnumerable<T> b,
            For_System.IEqualityComparer<T> equalityComparer)
        {
            var target_HashSet = Instances.HashSetOperator.From_ExceptionIfDuplicate(
                a,
                equalityComparer);

            foreach (var item in b)
            {
                Instances.HashSetOperator.Remove(
                    target_HashSet,
                    item);
            }

            var any_Remaining = target_HashSet.Any();

            if (any_Remaining)
            {
                return false;
            }

            // Else.
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        bool Are_Equal_OrderIndependentSets<T>(
            IDistinctCollection<T> a,
            IDistinctCollection<T> b,
            For_System.IEqualityComparer<T> equalityComparer)
        {
            var areEqual_Counts = Instances.CountOperator.Are_Equal_Counts(
                a,
                b);

            if (!areEqual_Counts)
            {
                return false;
            }

            var output = this.Are_Equal_OrderIndependentSets_UncheckedCounts(a, b, equalityComparer);
            return output;
        }
    }
}
