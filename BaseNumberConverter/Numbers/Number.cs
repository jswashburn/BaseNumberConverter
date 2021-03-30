using System;

namespace BaseNumberConverter.Numbers
{
    public abstract class Number : INumber
    {
        protected string _value;

        public Number(string value)
        {
            ValidateInput(value);
        }

        protected abstract void ValidateInput(string value);

        public abstract string ToBinaryString();

        public abstract string ToDecimalString();

        public abstract string ToOctalString();
    }
}
