using System;


namespace F10Y.L0003.L001
{
    public class HasOperator : IHasOperator
    {
        #region Infrastructure

        public static IHasOperator Instance { get; } = new HasOperator();


        private HasOperator()
        {
        }

        #endregion
    }
}
