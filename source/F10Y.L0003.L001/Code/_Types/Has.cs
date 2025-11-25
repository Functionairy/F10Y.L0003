using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0004;


namespace F10Y.L0003.L001
{
    /// <summary>
    /// Return type for methods testing whether a value exists, and if so, returning the value.
    /// </summary>
    /// <typeparam name="TValue">The type of the result.</typeparam>
    /// <remarks>
    /// This is useful for replacing methods like:
    /// <code>
    /// bool Has(searchable, search, out T value_OrDefault)
    /// </code>
    /// with:
    /// <code>
    /// Has&lt;T&gt; Has(searchable, search)
    /// </code>
    /// Suggestion in Stack Overflow: <see href="https://stackoverflow.com/questions/18716928/how-to-write-a-async-method-with-out-parameter"/>.
    /// </remarks>
    [UtilityTypeMarker]
    public class Has<TValue>
    {
        #region Static

        public static implicit operator bool(Has<TValue> has)
            => has.Exists;

        public static implicit operator TValue(Has<TValue> has)
            => has.Value;

        #endregion


        public bool Exists { get; private set; }

        public TValue Value { get; private set; }


        public Has(TValue result, bool exists)
        {
            this.Exists = exists;
            this.Value = result;
        }

        public override string ToString()
        {
            var representation = $"{this.Exists}, {this.Value}";
            return representation;
        }
    }


    /// <summary>
    /// Static class is provided in case clients do not want to use instances methodology.
    /// </summary>
    public static class Has
    {
        public static Has<T> Found<T>(T value)
            => Has.From(value, true);

        public static Has<T> From<T>(T result, bool exists)
        {
            var wasFound = new Has<T>(result, exists);
            return wasFound;
        }

        /// <summary>
        /// If the value is the default value, then the value does not exist.
        /// </summary>
        /// <remarks>
        /// Compares the value to the default for the type of the value using the default equality comparer (<see cref="EqualityComparer{T}.Default"/>).
        /// If you instead want to indicate that a value <strong>was</strong> found, but that the default value was found, use <see cref="From{T}(T, bool)"/>.
        /// </remarks>
        public static Has<T> From<T>(T value_OrDefault)
        {
            var exists = Instances.DefaultOperator.Is_NotDefault(value_OrDefault);

            var wasFound = Has.From(value_OrDefault, exists);
            return wasFound;
        }

        /// <summary>
        /// Was found only if the array is non-null and non-empty.
        /// </summary>
        public static Has<T[]> From_Array<T>(T[] result)
        {
            var exists = Instances.ArrayOperator.Is_NotNullOrEmpty(result);

            var output = Has.From(result, exists);
            return output;
        }

        public static Has<IEnumerable<T>> From_Enumerable<T>(IEnumerable<T> result)
        {
            var exists = Instances.EnumerableOperator.Is_NotNullOrEmpty(result);

            var output = Has.From(result, exists);
            return output;
        }

        /// <summary>
        /// One-stop shop for values that are not found.
        /// </summary>
        public static Has<T> NotFound<T>()
        {
            var wasFound = new Has<T>(default, false);
            return wasFound;
        }

        /// <summary>
        /// Allow specifying a value, but also that the value was not found.
        /// </summary>
        public static Has<T> NotFound<T>(T value)
        {
            var wasFound = new Has<T>(value, false);
            return wasFound;
        }
    }
}
