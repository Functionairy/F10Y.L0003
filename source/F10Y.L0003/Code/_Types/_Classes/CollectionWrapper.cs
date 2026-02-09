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
    public class CollectionWrapper<T> : ICollection<T>
    {
        private ICollection<T> Collection { get; }

        public int Count => this.Collection.Count;
        public bool IsReadOnly => this.Collection.IsReadOnly;


        public CollectionWrapper(ICollection<T> collection)
        {
            this.Collection = collection;
        }

        public IEnumerator<T> GetEnumerator()
            => this.Collection.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.Collection.GetEnumerator();

        public void Add(T item)
            => this.Collection.Add(item);

        public void Clear()
            => this.Collection.Clear();

        public bool Contains(T item)
            => this.Collection.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
            => this.Collection.CopyTo(array, arrayIndex);

        public bool Remove(T item)
            => this.Collection.Remove(item);
    }
}
