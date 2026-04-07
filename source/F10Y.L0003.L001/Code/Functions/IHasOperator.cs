using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;

using F10Y.L0003.L001.Extensions;


namespace F10Y.L0003.L001
{
    [FunctionsMarker]
    public partial interface IHasOperator
    {
        bool Any_Found<T>(IEnumerable<Has<T>> items)
        {
            var output = items
                .Where_IsFound()
                .Any();

            return output;
        }

        bool Any_NotFound<T>(IEnumerable<Has<T>> items)
        {
            var output = items
                .Select(this.Is_NotFound)
                .Any();

            return output;
        }

        Has<TOut> Convert<TIn, TOut>(
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
        Has<T> Found<T>(T value)
            => Has.Found(value);

        /// <inheritdoc cref="Has.From{T}(T, bool)"/>
        Has<T> From<T>(T result, bool exists)
            => Has.From(result, exists);

        /// <inheritdoc cref="Has.From{T}(T)"/>
        Has<T> From<T>(T result)
            => Has.From(result);

        /// <inheritdoc cref="Has.From_Array{T}(T[])"/>
        Has<T[]> From_Array<T>(T[] result)
            => Has.From_Array(result);

        /// <inheritdoc cref="Has.From_Enumerable{T}(IEnumerable{T})"/>
        Has<IEnumerable<T>> From_Enumerable<T>(IEnumerable<T> result)
            => Has.From_Enumerable(result);

        T Get_Result<T>(Has<T> has)
        {
            return this.Get_Result_OrExceptionIfNotFound(has);
        }

        T Get_Result_OrExceptionIfNotFound<T>(Has<T> has)
        {
            var output = this.Get_Result_OrExceptionIfNotFound(has,
                () => new Exception("Result did not exist."));

            return output;
        }

        T Get_Result_OrExceptionIfNotFound<T>(Has<T> has,
            Func<Exception> exceptionConstructor)
        {
            if (!has)
            {
                var exception = exceptionConstructor();
                throw exception;
            }

            return has.Value;
        }

        T Get_Result_OrExceptionIfNotFound<T>(Has<T> has,
            string message)
        {
            if (!has)
            {
                var exception = Instances.ExceptionOperator.From(message);
                throw exception;
            }

            return has.Value;
        }

        bool Is_Found<T>(Has<T> has)
        {
            return has.Exists;
        }

        bool Is_NotFound<T>(Has<T> has)
        {
            var output = !has.Exists;
            return output;
        }

        /// <inheritdoc cref="Has.NotFound{T}()"/>
        Has<T> NotFound<T>()
            => Has.NotFound<T>();

        /// <inheritdoc cref="Has.NotFound{T}(T)"/>
        Has<T> NotFound<T>(T value)
            => Has.NotFound<T>(value);

        IEnumerable<TValue> Get_ValuesFound<TValue>(IEnumerable<Has<TValue>> items)
        {
            var output = items
                .Where_IsFound()
                .Select(this.Get_Result)
                ;

            return output;
        }

        IEnumerable<Has<T>> Where_IsFound<T>(IEnumerable<Has<T>> items)
        {
            var output = items
                .Where(this.Is_Found)
                ;

            return output;
        }

        IEnumerable<Has<T>> Where_IsNotFound<T>(IEnumerable<Has<T>> items)
        {
            var output = items
                .Where(this.Is_NotFound)
                ;

            return output;
        }
    }
}
