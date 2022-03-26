using Exercise5;
using NUnit.Framework;

namespace Exercise5Tests
{
    [TestFixture()]
    public class CurrencyCalculatorTests
    {
        [TestCase(152, 126.16)]
        public void ConvertToEurosTest(double value, double expected)
        {
            var result = CurrencyCalculator.ConvertToEuros(value);
            Assert.AreEqual(expected, result);
        }

        [TestCase(50, 60)]
        public void ConvertToPoundsTest(double value, double expected)
        {
            var result = CurrencyCalculator.ConvertToPounds(value);
            Assert.AreEqual(expected, result);
        }
    }
}