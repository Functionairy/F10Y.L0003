using System;


namespace F10Y.L0003.L001.Extensions
{
    public static class HasExtensions
    {
        public static Has<TOut> Convert<TIn, TOut>(this Has<TIn> has_In,
            Func<TIn, TOut> converter)
            => Instances.HasOperator.Convert(
                has_In,
                converter);
    }
}
