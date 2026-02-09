using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;

using F10Y.L0003.Extensions;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IDictionaryOperator
    {
        IDistinctCollection<TKey> Get_Keys_AsDistinctCollection<TKey, TValue>(IDictionary<TKey, TValue> dictionary)
            => dictionary.Keys.As_Distinct();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Uses <see cref="Get_Keys_AsDistinctCollection{TKey, TValue}(IDictionary{TKey, TValue})"/> as the default.
        /// </remarks>
        IDistinctCollection<TKey> Get_Keys<TKey, TValue>(IDictionary<TKey, TValue> dictionary)
            => this.Get_Keys_AsDistinctCollection(dictionary);

        IDistinctCollection<TKey> Get_Keys_AsDistinctCollection<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary)
            => dictionary.Keys
                .To_DistinctCollection();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Uses <see cref="Get_Keys_AsDistinctCollection{TKey, TValue}(IReadOnlyDictionary{TKey, TValue})"/> as the default.
        /// </remarks>
        IDistinctCollection<TKey> Get_Keys<TKey, TValue>(IReadOnlyDictionary<TKey, TValue> dictionary)
            => this.Get_Keys_AsDistinctCollection(dictionary);
    }
}
