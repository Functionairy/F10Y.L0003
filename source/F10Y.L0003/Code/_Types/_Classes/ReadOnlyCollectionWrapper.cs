using System;
using System.Collections;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    /// <summary>
    /// A simple wrapper around an instance of the <see cref="IEnumerable{T}"/> type.
    /// </summary>
    [UtilityTypeMarker]
    public class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T>
    {
        private IReadOnlyCollection<T> ReadOnlyCollection { get; }

        public int Count => this.ReadOnlyCollection.Count;


        public ReadOnlyCollectionWrapper(IReadOnlyCollection<T> collection)
        {
            this.ReadOnlyCollection = collection;
        }

        public IEnumerator<T> GetEnumerator()
            => this.ReadOnlyCollection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.ReadOnlyCollection.GetEnumerator();
    }
}
