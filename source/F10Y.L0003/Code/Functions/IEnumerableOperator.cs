using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0000.Extensions;
using F10Y.L0003.Extensions;

using For_System = System.Collections.Generic;


namespace F10Y.L0003
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IEnumerableOperator :
        L0000.IEnumerableOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEnumerableOperator _L0000 => L0000.EnumerableOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// For an enumerable that is already distinct, simply wrap it.
        /// </summary>
        IDistinctEnumerable<T> As_Distinct<T>(IEnumerable<T> enumerable)
            => new Internal.DistinctEnumerable<T>(enumerable);

        IOrderedEnumerable<T> As_OrderedEnumerable<T>(IEnumerable<T> enumerable)
            => new Internal.OrderedEnumerable<T>(enumerable);

        IOrderedEnumerable <T> Create_OrderedEnumerable<T, TKey>(
            IEnumerable<T> values,
            Func<T, TKey> key_Selector,
            IComparer<TKey> comparer,
            bool descending)
            => values.OrderBy(
                key_Selector,
                comparer)
                .Modify_If(
                    descending,
                    x => x.Reverse());

        IDistinctCollection<T> To_DistinctCollection<T>(
            IEnumerable<T> enumerable,
            For_System.IEqualityComparer<T> equalityComparer)
            => enumerable
                .To_Distinct(equalityComparer)
                .To_DistinctCollection();

        DistinctArray<T> To_Array_Distinct<T>(
            IEnumerable<T> enumerable,
            For_System.IEqualityComparer<T> equalityComparer)
            => enumerable
                .To_Distinct(equalityComparer)
                .To_Array_Distinct();

        DistinctArray<T> To_Array_Distinct<T>(IDistinctEnumerable<T> enumerable_Distinct)
            => enumerable_Distinct
                .ToArray()
                .As_Distinct();

        IDistinctCollection<T> To_DistinctCollection<T>(IEnumerable<T> enumerable)
            => this.To_DistinctCollection(
                enumerable,
                Instances.EqualityComparers.For<T>().Default);

        IDistinctCollection<T> To_DistinctCollection<T>(IDistinctEnumerable<T> enumerable_Distinct)
            => enumerable_Distinct
                .ToArray()
                .As_DistinctCollection();

        IDistinctReadOnlyCollection<T> To_DistinctReadOnlyCollection<T>(IDistinctEnumerable<T> enumerable_Distinct)
            => enumerable_Distinct
                .ToArray()
                .As_DistinctReadOnly();

        IDistinctEnumerable<T> Get_Distinct<T>(
            IEnumerable<T> enumerable,
            For_System.IEqualityComparer<T> equalityComparer)
            => this.To_Distinct(enumerable, equalityComparer);

        IDistinctEnumerable<T> Get_Distinct<T>(IEnumerable<T> enumerable)
            => this.Get_Distinct(
                enumerable,
                Instances.EqualityComparers.For<T>().Default);

        IDistinctEnumerable<T> To_Distinct<T>(
            IEnumerable<T> enumerable,
            For_System.IEqualityComparer<T> equalityComparer)
            => enumerable
                .Distinct(equalityComparer)
                .As_Distinct();

        IDistinctEnumerable<T> To_Distinct<T>(IEnumerable<T> enumerable)
            => this.To_Distinct(
                enumerable,
                Instances.EqualityComparers.For<T>().Default);
    }
}
