using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// Tests two instances for equality.
    /// </summary>
    /// <remarks>
    /// Simplified equality comparer separate from <see cref="System.Collections.Generic.IEqualityComparer{T}"/>,
    /// int that this type does not require defining the <see cref="System.Collections.Generic.IEqualityComparer{T}.GetHashCode(T)"/> method,
    /// just the <see cref="System.Collections.Generic.IEqualityComparer{T}.Equals(T, T)"/> method.
    /// </remarks>
    [UtilityTypeMarker]
    public interface IEqualityComparer<in T>
    {
        bool Equals(T x, T y);
    }
}
