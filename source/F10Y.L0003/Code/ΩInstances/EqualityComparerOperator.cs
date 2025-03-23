using System;


namespace F10Y.L0003
{
    public class EqualityComparerOperator : IEqualityComparerOperator
    {
        #region Infrastructure

        public static IEqualityComparerOperator Instance { get; } = new EqualityComparerOperator();


        private EqualityComparerOperator()
        {
        }

        #endregion
    }
}
