using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// Indicates (but does not guarantee) that a read-only collection contains distinct elements.
    /// External (or extension) methods can be used to verify/ensure that elements are actually distinct if desired (and the cost of computation is justified).
    /// </summary>
    /// <remarks>
    /// Conceptually similar to <see cref="IReadOnlyDictionary{TKey, TValue}"/>, but indicates the property of being distict in addition to being read-only.
    /// </remarks>
    [UtilityTypeMarker]
    public interface IDistinctReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
    }
}
