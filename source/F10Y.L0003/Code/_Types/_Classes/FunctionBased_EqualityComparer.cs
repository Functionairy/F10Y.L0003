using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// An implementation of the simplified <see cref="IEqualityComparer{T}"/> interface that just wraps a function.
    /// </summary>
    [UtilityTypeMarker]
    public class FunctionBased_EqualityComparer<T> : IEqualityComparer<T>
    {
        private Func<T, T, bool> EqualityFunction { get; }


        public FunctionBased_EqualityComparer(
            Func<T, T, bool> equalityFunction)
        {
            this.EqualityFunction = equalityFunction;
        }

        public bool Equals(T x, T y)
        {
            var areEqual = this.EqualityFunction(x, y);
            return areEqual;
        }
    }
}
