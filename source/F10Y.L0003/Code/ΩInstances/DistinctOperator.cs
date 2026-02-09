using System;


namespace F10Y.L0003
{
    public class DistinctOperator : IDistinctOperator
    {
        #region Infrastructure

        public static IDistinctOperator Instance { get; } = new DistinctOperator();


        private DistinctOperator()
        {
        }

        #endregion
    }
}
