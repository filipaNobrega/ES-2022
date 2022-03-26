using Exercise4;
using FluentAssertions;
using NUnit.Framework;

namespace Exercise4Tests
{
    [TestFixture]
    public class FahrenheitTemperatureTests
    {
        [Test]
        public void Convert_Returns_Valid_Celsius_Conversion()
        {
            var temperature = new FahrenheitTemperature(98.6);
            var fahrenheit = temperature.Convert();
            fahrenheit.Should().Be(37);
        }
    }
}