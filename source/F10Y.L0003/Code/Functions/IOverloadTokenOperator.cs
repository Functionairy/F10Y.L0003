using System;

using F10Y.T0002;


namespace F10Y.L0003
{
    [FunctionsMarker]
    public partial interface IOverloadTokenOperator
    {
        public OverloadToken_Input<T> Input<T>()
            => OverloadToken_Input<T>.Instance;

        public IOverloadTokenOperator<T> Of_Type<T>()
            => OverloadTokenOperator<T>.Instance;

        public OverloadToken_Output<T> Output<T>()
            => OverloadToken_Output<T>.Instance;

        public OverloadToken<T> Token<T>()
            => OverloadToken<T>.Instance;
    }


    [FunctionsMarker]
    public partial interface IOverloadTokenOperator<T>
    {
        public OverloadToken_Input<T> Input => OverloadToken_Input<T>.Instance;

        public OverloadToken_Output<T> Output => OverloadToken_Output<T>.Instance;

        public OverloadToken<T> Token => OverloadToken<T>.Instance;
    }
}
