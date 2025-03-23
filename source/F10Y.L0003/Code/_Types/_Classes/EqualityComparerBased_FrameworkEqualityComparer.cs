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
    public class EqualityComparerBased_FrameworkEqualityComparer<T> : Framework.IEqualityComparer<T>
    {
        #region Static

        public static EqualityComparerBased_FrameworkEqualityComparer<T> From(
            IEqualityComparer<T> equalityComparer)
        {
            var output = new EqualityComparerBased_FrameworkEqualityComparer<T>(equalityComparer);
            return output;
        }

        #endregion


        private IEqualityComparer<T> EqualityComparer { get; }


        public EqualityComparerBased_FrameworkEqualityComparer(
            IEqualityComparer<T> equalityComparer)
        {
            this.EqualityComparer = equalityComparer;
        }

        public bool Equals(T x, T y)
        {
            var areEqual = this.EqualityComparer.Equals(x, y);
            return areEqual;
        }

        public int GetHashCode(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
