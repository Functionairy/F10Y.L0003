using System;
using System.Collections.Generic;


namespace F10Y.L0003.L001.Extensions
{
    public static class HasExtensions
    {
        public static bool Any_Found<T>(this IEnumerable<Has<T>> items)
            => Instances.HasOperator.Any_Found(items);

        public static bool Any_NotFound<T>(this IEnumerable<Has<T>> wasFounds)
        {
            var output = Instances.HasOperator.Any_NotFound(wasFounds);
            return output;
        }

        public static Has<TOut> Convert<TIn, TOut>(this Has<TIn> has_In,
            Func<TIn, TOut> converter)
            => Instances.HasOperator.Convert(
                has_In,
                converter);

        public static IEnumerable<TValue> ValuesFound<TValue>(this IEnumerable<Has<TValue>> wasFounds)
            => Instances.HasOperator.Get_ValuesFound(wasFounds);

        public static IEnumerable<Has<T>> Where_IsFound<T>(this IEnumerable<Has<T>> items)
            => Instances.HasOperator.Where_IsFound(items);
    }
}
