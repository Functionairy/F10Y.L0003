using System;

using F10Y.T0004;

// Note: unable to alias the open generic type System.Collections.Generic.IEqualityComparer<T>, because C# does not allow aliasing open generic types.
// But we can alias the namespace.
using Framework = System.Collections.Generic;


namespace F10Y.L0003
{
    /// <summary>
    /// An implementation of the simplified <see cref="IEqualityComparer{T}"/> interface that just wraps an instance of the full <see cref="Framework.IEqualityComparer{T}"/>.
    /// </summary>
    [UtilityTypeMarker]
    public class FrameworkEqualityComparerBased_EqualityComparer<T> : IEqualityComparer<T>
    {
        #region Static

        public static FrameworkEqualityComparerBased_EqualityComparer<T> Default => new FrameworkEqualityComparerBased_EqualityComparer<T>(
            Framework.EqualityComparer<T>.Default);


        public static FrameworkEqualityComparerBased_EqualityComparer<T> From(
            Framework.IEqualityComparer<T> equalityComparer)
        {
            var output = new FrameworkEqualityComparerBased_EqualityComparer<T>(equalityComparer);
            return output;
        }

        #endregion


        private Framework.IEqualityComparer<T> EqualityComparer { get; }


        public FrameworkEqualityComparerBased_EqualityComparer(
            Framework.IEqualityComparer<T> equalityComparer)
        {
            this.EqualityComparer = equalityComparer;
        }

        public bool Equals(T x, T y)
        {
            var areEqual = this.EqualityComparer.Equals(x, y);
            return areEqual;
        }
    }
}
