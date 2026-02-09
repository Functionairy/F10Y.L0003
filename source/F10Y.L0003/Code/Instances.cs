using System;


namespace F10Y.L0003
{
    public static class Instances
    {
        public static IArrayOperator ArrayOperator => L0003.ArrayOperator.Instance;
        public static ICollectionOperator CollectionOperator => L0003.CollectionOperator.Instance;
        public static L0000.ICountOperator CountOperator => L0000.CountOperator.Instance;
        public static IDictionaryOperator DictionaryOperator => L0003.DictionaryOperator.Instance;
        public static IEnumerableOperator EnumerableOperator => L0003.EnumerableOperator.Instance;
        public static IEqualityComparerOperator EqualityComparerOperator => L0003.EqualityComparerOperator.Instance;
        public static L0000.IEqualityComparers EqualityComparers => L0000.EqualityComparers.Instance;
        public static L0000.IHashCodeOperator HashCodeOperator => L0000.HashCodeOperator.Instance;
        public static L0000.IHashSetOperator HashSetOperator => L0000.HashSetOperator.Instance;
        public static IReadOnlyCollectionOperator ReadOnlyCollectionOperator => L0003.ReadOnlyCollectionOperator.Instance;
    }
}