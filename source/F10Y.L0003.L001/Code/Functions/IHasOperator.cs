using System;
using System.Collections.Generic;

using F10Y.T0002;


namespace F10Y.L0003.L001
{
    [FunctionsMarker]
    public partial interface IHasOperator
    {
        public Has<TOut> Convert<TIn, TOut>(
            Has<TIn> has_In,
            Func<TIn, TOut> converter)
        {
            var output = has_In
                ? this.From(
                    converter(has_In.Value),
                    has_In.Exists)
                : this.NotFound<TOut>()
                ;

            return output;
        }

        /// <inheritdoc cref="Has.Found{T}(T)"/>
        public Has<T> Found<T>(T value)
            => Has.Found(value);

        /// <inheritdoc cref="Has.From{T}(T, bool)"/>
        public Has<T> From<T>(T result, bool exists)
            => Has.From(result, exists);

        /// <inheritdoc cref="Has.From{T}(T)"/>
        public Has<T> From<T>(T result)
            => Has.From(result);

        /// <inheritdoc cref="Has.From_Array{T}(T[])"/>
        public Has<T[]> From_Array<T>(T[] result)
            => Has.From_Array(result);

        /// <inheritdoc cref="Has.From_Enumerable{T}(IEnumerable{T})"/>
        public Has<IEnumerable<T>> From_Enumerable<T>(IEnumerable<T> result)
            => Has.From_Enumerable(result);

        /// <inheritdoc cref="Has.NotFound{T}()"/>
        public Has<T> NotFound<T>()
            => Has.NotFound<T>();

        /// <inheritdoc cref="Has.NotFound{T}(T)"/>
        public Has<T> NotFound<T>(T value)
            => Has.NotFound<T>(value);
    }
}
