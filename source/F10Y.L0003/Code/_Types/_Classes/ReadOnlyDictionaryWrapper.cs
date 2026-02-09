using System;
using System.Collections;
using System.Collections.Generic;

using F10Y.T0004;


namespace F10Y.L0003.Internal
{
    /// <summary>
    /// A simple wrapper around an instance of the <see cref="IReadOnlyDictionary{TKey, TValue}"/> type.
    /// </summary>
    [UtilityTypeMarker]
    public class ReadOnlyDictionaryWrapper<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        private IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary { get; }

        public IEnumerable<TKey> Keys => this.ReadOnlyDictionary.Keys;

        public IEnumerable<TValue> Values => this.ReadOnlyDictionary.Values;

        public int Count => this.ReadOnlyDictionary.Count;

        public TValue this[TKey key] => this.ReadOnlyDictionary[key];


        public ReadOnlyDictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
        {
            this.ReadOnlyDictionary = dictionary;
        }

        public bool ContainsKey(TKey key)
            => this.ReadOnlyDictionary.ContainsKey(key);

        public bool TryGetValue(TKey key, out TValue value)
            => this.ReadOnlyDictionary.TryGetValue(key, out value);

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            => this.ReadOnlyDictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => this.ReadOnlyDictionary.GetEnumerator();
    }
}
