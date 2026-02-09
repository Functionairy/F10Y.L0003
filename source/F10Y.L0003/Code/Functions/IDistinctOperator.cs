using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IDistinctOperator
    {
        IDistinctCollection<T> As_Distinct<T>(ICollection<T> collection)
            => Instances.CollectionOperator.As_Distinct(collection);

        IDistinctEnumerable<T> As_Distinct<T>(IEnumerable<T> enumerable)
            => Instances.EnumerableOperator.As_Distinct(enumerable);
    }
}
