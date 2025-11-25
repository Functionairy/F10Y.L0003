using System;

using F10Y.T0002;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IDisposableOperator
    {
        /// <summary>
        /// Gets the singleton <see cref="EmptyDisposable.Instance"/> instance.
        /// </summary>
        /// <returns></returns>
        public EmptyDisposable Empty()
            => EmptyDisposable.Instance;
    }
}
