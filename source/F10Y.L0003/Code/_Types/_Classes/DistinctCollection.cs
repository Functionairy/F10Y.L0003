using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    [UtilityTypeMarker]
    public class DistinctCollection<T> : CollectionWrapper<T>, IDistinctCollection<T>
    {
        public DistinctCollection(ICollection<T> collection)
            : base(collection)
        {
        }
    }
}
