using System;
using System.Collections.Generic;

using For_System = System.Collections.Generic;


namespace F10Y.L0003.Extensions
{
    public static class ArrayExtensions
    {
        public static DistinctArray<TValue> As_Distinct<TValue>(this TValue[] array)
            => Instances.ArrayOperator.As_Distinct(array);
    }
}
