using System;


namespace F10Y.L0003
{
    public class DisposableOperator : IDisposableOperator
    {
        #region Infrastructure

        public static IDisposableOperator Instance { get; } = new DisposableOperator();


        private DisposableOperator()
        {
        }

        #endregion
    }
}
