using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    [UtilityTypeMarker]
    public class DistinctArray<T> : Internal.ArrayWrapper<T>, IDistinctArray<T>
    {
        public DistinctArray(T[] array)
            : base(array)
        {
        }
    }
}
