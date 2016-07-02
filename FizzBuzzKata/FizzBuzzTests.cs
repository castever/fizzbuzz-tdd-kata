using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata
{
    [TestClass]
    public class FizzBuzzTests
    {

        [TestMethod]
        public void TestReturnsNumbersIfNotDivisibleByFiveOrThree()
        {
            Assert.AreEqual("1", new FizzBuzz(1).Value());
            Assert.AreEqual("2", new FizzBuzz(2).Value());
            Assert.AreEqual("4", new FizzBuzz(4).Value());
            Assert.AreEqual("98", new FizzBuzz(98).Value());
        }   
        
        [TestMethod]
        public void TestReturnsFizzIfDivisibleByThree()
        {
            Assert.AreEqual("Fizz", new FizzBuzz(3).Value());
            Assert.AreEqual("Fizz", new FizzBuzz(6).Value());
            Assert.AreEqual("Fizz", new FizzBuzz(9).Value());
            Assert.AreEqual("Fizz", new FizzBuzz(33).Value());
        }

        [TestMethod]
        public void TestReturnsBuzzIfDivisibleByFive()
        {
            Assert.AreEqual("Buzz", new FizzBuzz(5).Value());
            Assert.AreEqual("Buzz", new FizzBuzz(25).Value());
            Assert.AreEqual("Buzz", new FizzBuzz(100).Value());
        }

        [TestMethod]
        public void TestReturnsFizzBuzzIfDivisibleByThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", new FizzBuzz(15).Value());
            Assert.AreEqual("FizzBuzz", new FizzBuzz(75).Value());
            Assert.AreEqual("FizzBuzz", new FizzBuzz(45).Value());
        }
    }
}
