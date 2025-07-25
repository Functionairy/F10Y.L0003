using System;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    [UtilityTypeMarker]
    public class DistinctEnumerable<T> : EnumerableWrapper<T>, IDistinctEnumerable<T>
    {
        public DistinctEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        {
        }
    }
}
