using Exercise4;
using FluentAssertions;
using NUnit.Framework;

namespace Exercise4Tests
{
    [TestFixture]
    public class CelsiusTemperatureTests
    {
        [Test]
        public void Convert_Returns_Valid_Fahrenheit_Conversion()
        {
            var temperature = new CelsiusTemperature(37);
            var fahrenheit = temperature.Convert();
            fahrenheit.Should().Be(98.6);
        }
    }
}