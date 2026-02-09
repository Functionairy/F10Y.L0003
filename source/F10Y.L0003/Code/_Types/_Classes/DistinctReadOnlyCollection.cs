using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    [UtilityTypeMarker]
    public class DistinctReadOnlyCollection<T> : ReadOnlyCollectionWrapper<T>, IDistinctReadOnlyCollection<T>
    {
        public DistinctReadOnlyCollection(IReadOnlyCollection<T> readOnlyCollection)
            : base(readOnlyCollection)
        {
        }
    }
}
