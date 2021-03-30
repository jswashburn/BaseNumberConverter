using System;

namespace BaseNumberConverter.Numbers
{
    public class DecimalNumber : Number
    {
        public DecimalNumber(string value) : base(value) { }

        protected override void ValidateInput(string value)
        {
            if (!long.TryParse(value, out var v))
                throw new FormatException($"Value '{value}' not could not be parsed to 64 bit integer (long)");
            else
                _value = v.ToString();
        }

        public override string ToDecimalString()
        {
            return _value;
        }

        public override string ToBinaryString()
        {
            return BaseConverter.DecimalToBinary(_value);
        }

        public override string ToOctalString()
        {
            return BaseConverter.DecimalToOctal(_value);
        }
    }
}
