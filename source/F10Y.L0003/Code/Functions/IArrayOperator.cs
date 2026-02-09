using System;

using F10Y.T0002;
using F10Y.T0011;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IArrayOperator :
        L0000.IArrayOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.IArrayOperator _L0000 => L0000.ArrayOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        DistinctArray<T> As_Distinct<T>(T[] array)
            => new DistinctArray<T>(array);
    }
}
