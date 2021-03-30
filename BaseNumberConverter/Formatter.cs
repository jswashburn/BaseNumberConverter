namespace BaseNumberConverter
{
    public static class Formatter
    {
        public const string BinaryPrefix = "0b0_";
        public const string OctalPrefix = "0x0_";
        public const string DecimalPrefix = "";

        public static string Format(string unformatted, string prefix, bool negative)
            => $"{(negative ? "-" : "")}{prefix}{unformatted}";

        public static string RemoveFormatting(string formatted)
        {
            string unformatted = formatted
                .Replace(BinaryPrefix, "").Replace(OctalPrefix, "")
                .TrimStart('-');
            return unformatted;
        }
    }
}
