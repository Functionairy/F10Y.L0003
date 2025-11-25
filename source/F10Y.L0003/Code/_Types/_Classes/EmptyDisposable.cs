using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// An empty disposable whose <see cref="Dispose"/> method does nothing.
    /// </summary>
    [UtilityTypeMarker]
    public sealed class EmptyDisposable : IDisposable
    {
        #region Static

        public static EmptyDisposable Instance { get; } = new EmptyDisposable();

        #endregion


        private EmptyDisposable()
        {
        }

        /// <inheritdoc/>
        public void Dispose()
        {
        }
    }
}
