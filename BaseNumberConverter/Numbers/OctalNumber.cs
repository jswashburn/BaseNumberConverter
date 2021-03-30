using System.Text.RegularExpressions;
using System;

namespace BaseNumberConverter.Numbers
{
    public class OctalNumber : Number
    {
        public OctalNumber(string value) : base(value)
        {
            _value = Formatter.Format(value, Formatter.OctalPrefix, value.StartsWith("-"));
        }

        protected override void ValidateInput(string value)
        {
            Regex octal = new Regex(@"^-?[1-7]+[0-7]*$", RegexOptions.Compiled);
            if (!octal.IsMatch(value))
                throw new FormatException($"Value '{value}' is not a valid Octal (base 8) number.");
        }

        public override string ToOctalString()
        {
            return _value;
        }

        public override string ToBinaryString()
        {
            return BaseConverter.OctalToBinary(_value);
        }

        public override string ToDecimalString()
        {
            return BaseConverter.OctalToDecimal(_value);
        }
    }
}
