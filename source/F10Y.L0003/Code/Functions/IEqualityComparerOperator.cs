using System;

using F10Y.T0002;
using F10Y.T0011;

using For_System = System.Collections.Generic;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IEqualityComparerOperator :
        L0000.IEqualityComparerOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IEqualityComparerOperator _L0000 => L0000.EqualityComparerOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        FrameworkEqualityComparerBased_EqualityComparer<T> Default_For<T>()
            => this.From(For_System.EqualityComparer<T>.Default);

        EqualityComparerBased_FrameworkEqualityComparer<T> From<T>(
            IEqualityComparer<T> equalityComparer)
            => EqualityComparerBased_FrameworkEqualityComparer<T>.From(equalityComparer);

        EqualityComparerBased_FrameworkEqualityComparer<T> From<T>(
            IEqualityComparer<T> equalityComparer,
            Func<T, int> hashCodeGenerator)
            => EqualityComparerBased_FrameworkEqualityComparer<T>.From(
                equalityComparer,
                hashCodeGenerator);

        FrameworkEqualityComparerBased_EqualityComparer<T> From<T>(
            For_System.IEqualityComparer<T> equalityComparer)
            => FrameworkEqualityComparerBased_EqualityComparer<T>.From(equalityComparer);

        FunctionBased_EqualityComparer<T[]> From_ToArray<T>(IEqualityComparer<T> instance_equalityComparer)
        {
            var output = new FunctionBased_EqualityComparer<T[]>((x, y) =>
            {
                var output = Instances.ArrayOperator.Are_Equal(x, y, instance_equalityComparer.Equals);
                return output;
            });

            return output;
        }

        FunctionBased_EqualityComparer<T> From_Function<T>(Func<T, T, bool> equalityFunction)
            => new FunctionBased_EqualityComparer<T>(equalityFunction);
    }
}
