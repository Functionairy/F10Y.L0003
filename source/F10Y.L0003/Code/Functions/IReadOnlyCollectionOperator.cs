using System;
using System.Collections.Generic;
using F10Y.T0002;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IReadOnlyCollectionOperator
    {
        IDistinctReadOnlyCollection<T> As_Distinct<T>(IReadOnlyCollection<T> collection_ReadOnly)
            => new Internal.DistinctReadOnlyCollection<T>(collection_ReadOnly);
    }
}
