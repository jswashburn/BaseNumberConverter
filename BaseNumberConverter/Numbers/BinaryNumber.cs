using System.Text.RegularExpressions;
using System;

namespace BaseNumberConverter.Numbers
{
    public class BinaryNumber : Number
    {
        public BinaryNumber(string value) : base(value) 
        {
            _value = Formatter.Format(value, Formatter.BinaryPrefix, value.StartsWith("-"));
        }

        protected override void ValidateInput(string value)
        {
            Regex binary64 = new Regex(@"^-?[01]{1,64}$", RegexOptions.Compiled);
            if (!binary64.IsMatch(value))
                throw new FormatException($"Value '{value}' not a valid 64-bit binary number");
        }

        public override string ToBinaryString()
        {
            return _value;
        }

        public override string ToDecimalString()
        {
            return BaseConverter.BinaryToDecimal(_value);
        }

        public override string ToOctalString()
        {
            return BaseConverter.BinaryToOctal(_value);
        }
    }
}
