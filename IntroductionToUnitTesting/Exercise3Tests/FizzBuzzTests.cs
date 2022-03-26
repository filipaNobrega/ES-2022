using Exercise3;
using FluentAssertions;
using NUnit.Framework;

namespace Exercise3Tests
{
    [TestFixture()]
    public class FizzBuzzTests
    {
        [Test()]
        public void ComputeTest_One()
        {
            var result = FizzBuzz.Compute(1);
            result.Should().BeEquivalentTo("1");
        }
        [Test()]
        public void ComputeTest_Fifteen()
        {
            var result = FizzBuzz.Compute(15);
            result.Should().BeEquivalentTo(
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz");
        }
    }
}