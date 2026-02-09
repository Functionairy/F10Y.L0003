using System;


namespace F10Y.L0003
{
    public class EqualityOperator : IEqualityOperator
    {
        #region Infrastructure

        public static IEqualityOperator Instance { get; } = new EqualityOperator();


        private EqualityOperator()
        {
        }

        #endregion
    }
}
