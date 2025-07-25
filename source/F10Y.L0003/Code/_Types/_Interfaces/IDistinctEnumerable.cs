using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// Indicates (but does not guarantee) that an enumerable contains distinct elements.
    /// External (or extension) methods can be used to verify/ensure that elements are actually distinct if desired (and the cost of computation is justified).
    /// </summary>
    /// <remarks>
    /// Conceptually similar to <see cref="IReadOnlyCollection{T}"/>, but indicates the property of being distict instead of being read-only.
    /// </remarks>
    [UtilityTypeMarker]
    public interface IDistinctEnumerable<out T> : IEnumerable<T>
    {
    }
}
