using System;


namespace F10Y.L0003
{
    public class Disposables : IDisposables
    {
        #region Infrastructure

        public static IDisposables Instance { get; } = new Disposables();


        private Disposables()
        {
        }

        #endregion
    }
}
