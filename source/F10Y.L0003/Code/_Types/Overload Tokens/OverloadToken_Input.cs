using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// <inheritdoc cref="OverloadToken{T}" path="/summary"/>
    /// <para>
    /// This -input overload token is a complement to the <see cref="OverloadToken_Input{T}"/> type,
    /// which is handles the common case where an asynchronous method would like to specify its output type,
    /// but cannot use an "out" parameter to do so
    /// (since asynchronous methods are not allowed to use "out" parameters in .NET).
    /// </para>
    /// <para>The complement to this type is <see cref="OverloadToken_Output{T}"/>.</para>
    /// </summary>
    /// <inheritdoc cref="OverloadToken{T}" path="/remarks"/>
    /// <typeparam name="T"><inheritdoc cref="OverloadToken{T}" path="/typeparam[@name='T']"/></typeparam>
    [UtilityTypeMarker]
    public readonly struct OverloadToken_Input<T>
    {
        public static OverloadToken_Input<T> Instance { get; } = new OverloadToken_Input<T>();
    }

    [UtilityTypeMarker]
    public readonly struct OverloadToken_Input<T1, T2>
    {
        public static OverloadToken_Input<T1, T2> Instance { get; } = new OverloadToken_Input<T1, T2>();
    }
}
