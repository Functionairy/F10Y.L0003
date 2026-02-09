using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;
using F10Y.T0011;

using F10Y.L0003.Extensions;

using For_System = System.Collections.Generic;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface ICollectionOperator :
        L0000.ICollectionOperator
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0000.ICollectionOperator _L0000 => L0000.CollectionOperator.Instance;

#pragma warning restore IDE1006 // Naming Styles


        ICollection<T> As_Collection<T>(IEnumerable<T> enumerable)
            => new Internal.CollectionWrapper<T>(enumerable.ToArray());

        IDistinctCollection<T> As_Distinct<T>(ICollection<T> collection)
            => new Internal.DistinctCollection<T>(collection);

        IDistinctReadOnlyCollection<T> As_ReadOnly<T>(IDistinctCollection<T> collection_Distinct)
            => new Internal.DistinctReadOnlyCollection<T>(collection_Distinct.AsEnumerable().ToArray());

        IDistinctCollection<T> Get_Distinct<T>(
            ICollection<T> collection,
            For_System.IEqualityComparer<T> equalityComparer)
            => collection
                .Distinct(equalityComparer)
                .As_Collection()
                .As_Distinct();

        IDistinctCollection<T> Get_Distinct<T>(ICollection<T> collection)
            => this.Get_Distinct(
                collection,
                Instances.EqualityComparers.For<T>().Default);
    }
}
