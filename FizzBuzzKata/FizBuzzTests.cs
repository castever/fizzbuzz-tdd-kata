using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata
{
    [TestClass]
    public class FizBuzzTests
    {

        [TestMethod]
        public void TestReturnsNumbersIfNotDivisibleByFiveOrThree()
        {
            string expected = "1";
            int number = 1;
            FizzBuzz fizzBuzz = new FizzBuzz(number);
            Assert.AreEqual(expected, fizzBuzz.Value());
        }
    }
}
