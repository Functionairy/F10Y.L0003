using System;

using F10Y.T0004;


namespace F10Y.L0003
{
    /// <summary>
    /// <overload-token-description>
    /// A struct (so that no instance actually has to be created for out parameters), with a dummy type parameter (meant to specify the output type of the function),
    /// meant for use as an input argument to a function allowing for easy function overload specification.
    /// </overload-token-description>
    /// If used as an "out" parameter, then it signifies the output type of the method is overloaded.
    /// If used as a regular input parameter, then it signifies the input type(s) of the method are overloaded.
    /// <para>
    /// NOTE: if a function overload provides an overload token, the caller should <string>always</string> take care to specify the type (instead of using the "var" keyword)
    /// even if there is currently only one function overload with an overload token.
    /// This is because there might be more in the future, and if someone adds another in the future, all your call sites will now be ambiguous!
    /// </para>
    /// However, generally the variable name of the overload token can be omitted (use the "_" discard variable name).
    /// </summary>
    /// <remarks>
    /// Since C# does not differentiate function overloads based on output parameter type, only input parameter types,
    /// well make an input parameter that specifies the output type so that function overloads are still differentiated.
    /// </remarks>
    /// <typeparam name="T">Dummy type parameter, meant to specify the type of a function in overloads.</typeparam>
    [UtilityTypeMarker]
    public readonly struct OverloadToken<T>
    {
        public static OverloadToken<T> Instance { get; } = new OverloadToken<T>();
    }

    [UtilityTypeMarker]
    public readonly struct OverloadToken<T1, T2>
    {
        public static OverloadToken<T1, T2> Instance { get; } = new OverloadToken<T1, T2>();
    }

    [UtilityTypeMarker]
    public readonly struct OverloadToken<T1, T2, T3>
    {
        public static OverloadToken<T1, T2, T3> Instance { get; } = new OverloadToken<T1, T2, T3>();
    }

    [UtilityTypeMarker]
    public readonly struct OverloadToken
    {

    }
}
