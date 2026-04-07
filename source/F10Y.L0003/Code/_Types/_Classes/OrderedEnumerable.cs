using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    /// <summary>
    /// An enumerable in order.
    /// </summary>
    /// <remarks>
    /// The .NET standard library's implementation type for the <see cref="System.Linq.IOrderedEnumerable{TElement}"/> interface is
    /// only accessible through the <see cref="Enumerable.OrderBy{TSource, TKey}(IEnumerable{TSource}, Func{TSource, TKey})"/> method.
    /// So, functionally inaccessible.
    /// If you want to create your own ordered enumerables you are out of luck.
    /// This class solves that issue.
    /// </remarks>
    [UtilityTypeMarker]
    public class OrderedEnumerable<T> : EnumerableWrapper<T>, IOrderedEnumerable<T>
    {
        public OrderedEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        {
        }

        public IOrderedEnumerable<T> CreateOrderedEnumerable<TKey>(Func<T, TKey> key_Selector, IComparer<TKey> comparer, bool descending)
            => Instances.EnumerableOperator.Create_OrderedEnumerable(
                this,
                key_Selector,
                comparer,
                descending);
    }
}
