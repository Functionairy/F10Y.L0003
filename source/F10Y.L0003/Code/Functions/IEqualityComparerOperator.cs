using System;

using F10Y.T0002;

using Framework = System.Collections.Generic;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IEqualityComparerOperator
    {
        public FrameworkEqualityComparerBased_EqualityComparer<T> Default_For<T>()
            => this.From(Framework.EqualityComparer<T>.Default);

        public EqualityComparerBased_FrameworkEqualityComparer<T> From<T>(
            IEqualityComparer<T> equalityComparer)
            => EqualityComparerBased_FrameworkEqualityComparer<T>.From(equalityComparer);

        public EqualityComparerBased_FrameworkEqualityComparer<T> From<T>(
            IEqualityComparer<T> equalityComparer,
            Func<T, int> hashCodeGenerator)
            => EqualityComparerBased_FrameworkEqualityComparer<T>.From(
                equalityComparer,
                hashCodeGenerator);

        public FrameworkEqualityComparerBased_EqualityComparer<T> From<T>(
            Framework.IEqualityComparer<T> equalityComparer)
            => FrameworkEqualityComparerBased_EqualityComparer<T>.From(equalityComparer);

        public FunctionBased_EqualityComparer<T[]> From_ToArray<T>(IEqualityComparer<T> instance_equalityComparer)
        {
            var output = new FunctionBased_EqualityComparer<T[]>((x, y) =>
            {
                var output = Instances.ArrayOperator.Are_Equal(x, y, instance_equalityComparer.Equals);
                return output;
            });

            return output;
        }

        public FunctionBased_EqualityComparer<T> From_Function<T>(Func<T, T, bool> equalityFunction)
            => new FunctionBased_EqualityComparer<T>(equalityFunction);
    }
}
