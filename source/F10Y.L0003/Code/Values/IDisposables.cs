using System;

using F10Y.T0003;


namespace F10Y.L0003
{
    [ValuesMarker]
    public partial interface IDisposables
    {
        /// <summary>
        /// The singleton <see cref="EmptyDisposable.Instance"/> instance.
        /// </summary>
        EmptyDisposable Empty => EmptyDisposable.Instance;
    }
}
