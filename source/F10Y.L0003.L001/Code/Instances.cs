using System;


namespace F10Y.L0003.L001
{
    public static class Instances
    {
        public static L0000.IArrayOperator ArrayOperator => L0000.ArrayOperator.Instance;
        public static L0000.IDefaultOperator DefaultOperator => L0000.DefaultOperator.Instance;
        public static L0000.IEnumerableOperator EnumerableOperator => L0000.EnumerableOperator.Instance;
        public static IHasOperator HasOperator => L001.HasOperator.Instance;
    }
}