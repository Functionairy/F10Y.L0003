using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// <inheritdoc cref="OverloadToken{T}" path="/summary"/>
    /// <para>
    /// The -output overload token is meant to solve the problem where asynchronous functions <strong>cannot</strong> have "out" parameters.
    /// Ordinarily with a <see cref="OverloadToken{T}"/>, the output type of the function would be specified with an "out" overload token paramter,
    /// as opposed to a regular input overload token parameter (which allows specifying the input type of a function overload).
    /// However, since asynchronous functions cannot have "out" parameters, only regular input parameters, this type makes it explicit that while the parameter <strong>is</strong> an input parameter,
    /// it is meant to specify the output of the function.
    /// </para>
    /// <para>The complement to this type is <see cref="OverloadToken_Input{T}"/>.</para>
    /// </summary>
    /// <inheritdoc cref="OverloadToken{T}" path="/remarks"/>
    /// <typeparam name="T"><inheritdoc cref="OverloadToken{T}" path="/typeparam[@name='T']"/></typeparam>
    [UtilityTypeMarker]
    public readonly struct OverloadToken_Output<T>
    {
        public static OverloadToken_Output<T> Instance { get; } = new OverloadToken_Output<T>();
    }
}
