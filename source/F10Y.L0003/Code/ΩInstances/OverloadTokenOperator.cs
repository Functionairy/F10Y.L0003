using System;


namespace F10Y.L0003
{
    public class OverloadTokenOperator : IOverloadTokenOperator
    {
        #region Infrastructure

        public static IOverloadTokenOperator Instance { get; } = new OverloadTokenOperator();


        private OverloadTokenOperator()
        {
        }

        #endregion
    }


    public class OverloadTokenOperator<T> : IOverloadTokenOperator<T>
    {
        #region Infrastructure

        public static IOverloadTokenOperator<T> Instance { get; } = new OverloadTokenOperator<T>();


        private OverloadTokenOperator()
        {
        }

        #endregion
    }
}
