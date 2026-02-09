using System;
using System.Collections.Generic;

using For_System = System.Collections.Generic;


namespace F10Y.L0003.Extensions
{
    public static class DictionaryExtensions
    {
        public static IDistinctCollection<TKey> Get_Keys_AsDistinctCollection<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Get_Keys_AsDistinctCollection(dictionary);

        public static IDistinctCollection<TKey> Get_Keys<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Get_Keys(dictionary);

        public static IDistinctCollection<TKey> Get_Keys_AsDistinctCollection<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Get_Keys_AsDistinctCollection(dictionary);

        public static IDistinctCollection<TKey> Get_Keys<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary)
            => Instances.DictionaryOperator.Get_Keys(dictionary);
    }
}
