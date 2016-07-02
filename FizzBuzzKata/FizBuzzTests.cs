using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata
{
    [TestClass]
    public class FizBuzzTests
    {

        [TestMethod]
        public void TestReturnsNumbersIfNotDivisibleByFiveOrThree()
        {
            Assert.AreEqual("1", new FizzBuzz(1).Value());
        }
        
        [TestMethod]
        public void TestReturnsFizzIfDivisibleByThree()
        {
            Assert.AreEqual("Fizz", new FizzBuzz(3).Value());
        }
    }
}
