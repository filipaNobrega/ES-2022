using NUnit.Framework;
using System.Globalization;

namespace Exercise2.Tests
{
    [TestFixture()]
    public class SentenceUtilsTests
    {
        [TestCase("This is a sentence", "This Is A Sentence")]
        [TestCase("this is a sentence", "This Is A Sentence")]
        [TestCase("abc def ghi", "Abc Def Ghi")]
        [TestCase("wAr aNd pEaCe", "War And Peace")]
        public void ToTitleCaseTest(string input, string expected)
        {
            string result = input.ToTitleCase();
            Assert.AreEqual(expected, result);
        }
    }
}