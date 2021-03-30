using System;

namespace BaseNumberConverter
{
    public static class BaseConverter
    {
        #region ToDecimal
        public static string BinaryToDecimal(string value)
        {
            string decimalValue = DecimalFromNumber(value, 2).ToString();
            return Formatter.Format(decimalValue, Formatter.DecimalPrefix, value.StartsWith("-"));
        }

        public static string OctalToDecimal(string value)
        {
            string decimalValue = DecimalFromNumber(value, 8).ToString();
            return Formatter.Format(decimalValue, Formatter.DecimalPrefix, value.StartsWith("-"));
        }
        #endregion

        #region ToBinary
        public static string DecimalToBinary(string value)
        {
            string binaryValue = DecimalToBase(value, 2);
            return Formatter.Format(binaryValue, Formatter.BinaryPrefix, value.StartsWith("-"));
        }

        public static string OctalToBinary(string value)
        {
            string decimalValue = DecimalFromNumber(value, 8).ToString();
            string binaryValue = DecimalToBase(decimalValue, 2);
            return Formatter.Format(binaryValue, Formatter.BinaryPrefix, value.StartsWith("-"));
        }
        #endregion

        #region ToOctal
        public static string DecimalToOctal(string value)
        {
            string octalValue = DecimalToBase(value, 8);
            return Formatter.Format(octalValue, Formatter.OctalPrefix, value.StartsWith("-"));
        }

        public static string BinaryToOctal(string value)
        {
            string decimalValue = DecimalFromNumber(value, 2).ToString();
            string octalValue = DecimalToBase(decimalValue, 8);
            return Formatter.Format(octalValue, Formatter.OctalPrefix, value.StartsWith("-"));
        }
        #endregion

        #region Converters
        public static long DecimalFromNumber(string number, int numberBase) //TODO: negatives
        {
            number = Formatter.RemoveFormatting(number);
            long total = 0;
            for (int digitIndex = 0; digitIndex < number.Length; digitIndex++)
            {
                long digitValue = long.Parse(number[digitIndex].ToString());
                long placeValue = (long)Math.Pow(numberBase, number.Length - digitIndex - 1);

                total += digitValue * placeValue;
            }

            return total;
        }

        static string DecimalToBase(string value, int baseValue)
        {
            long decimalValue = long.Parse(value);
            if (decimalValue == 0)
                return "0";

            if (decimalValue < 0)
                decimalValue *= -1;

            string converted = "";
            while (decimalValue >= 1)
            {
                // Append the remainder (1 or 0) to our output string
                converted = converted.Insert(0, (decimalValue % baseValue).ToString());
                decimalValue /= baseValue;
            }

            return converted;
        }
        #endregion
    }
}
