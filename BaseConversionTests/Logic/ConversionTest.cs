using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseNumberConverter;

namespace BaseConversionTests.Logic
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void TestDecimalToBinary()
        {
            string formatted = BaseConverter.DecimalToBinary("4");
            Assert.AreEqual(formatted, "0b0_100");

            formatted = BaseConverter.DecimalToBinary("123");
            Assert.AreEqual(formatted, "0b0_1111011");

            formatted = BaseConverter.DecimalToBinary("0");
            Assert.AreEqual(formatted, "0b0_0");

            formatted = BaseConverter.DecimalToBinary("-16450");
            Assert.AreEqual(formatted, "-0b0_100000001000010");
        }

        [TestMethod]
        public void TestBinaryToDecimal()
        {
            string formatted = BaseConverter.BinaryToDecimal("-110");
            Assert.AreEqual(formatted, "-6");

            formatted = BaseConverter.BinaryToDecimal("1010");
            Assert.AreEqual(formatted, "10");
        }

        [TestMethod]
        public void TestDecimalToOctal()
        {
            string formatted = BaseConverter.DecimalToOctal("15");
            Assert.AreEqual(formatted, "0x0_17");

            formatted = BaseConverter.DecimalToOctal("-42");
            Assert.AreEqual(formatted, "-0x0_52");
        }

        [TestMethod]
        public void TestOctalToDecimal()
        {
            string formatted = BaseConverter.OctalToDecimal("52");
            Assert.AreEqual(formatted, "42");

            formatted = BaseConverter.OctalToDecimal("-17");
            Assert.AreEqual(formatted, "-15");
        }

        [TestMethod]
        public void TestBinaryToOctal()
        {
            string formatted = BaseConverter.BinaryToOctal("-1111"); // 15 is 17 in octal
            Assert.AreEqual(formatted, "-0x0_17");

            formatted = BaseConverter.BinaryToOctal("101010");
            Assert.AreEqual(formatted, "0x0_52");
        }

        [TestMethod]
        public void TestOctalToBinary()
        {
            string formatted = BaseConverter.OctalToBinary("52");
            Assert.AreEqual(formatted, "0b0_101010");

            formatted = BaseConverter.OctalToBinary("-17");
            Assert.AreEqual(formatted, "-0b0_1111");
        }
    }
}
