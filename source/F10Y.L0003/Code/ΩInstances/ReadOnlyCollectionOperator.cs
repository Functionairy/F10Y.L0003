using System;


namespace F10Y.L0003
{
    public class ReadOnlyCollectionOperator : IReadOnlyCollectionOperator
    {
        #region Infrastructure

        public static IReadOnlyCollectionOperator Instance { get; } = new ReadOnlyCollectionOperator();


        private ReadOnlyCollectionOperator()
        {
        }

        #endregion
    }
}
