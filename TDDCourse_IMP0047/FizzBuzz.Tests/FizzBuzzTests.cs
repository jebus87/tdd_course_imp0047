using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(1,"1") ]
        [TestCase(2, "2")]
        [TestCase(3, "fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]
        [TestCase(6, "fizz")]
        [TestCase(10, "buzz")]
        [TestCase(15, "fizzbuzz")]
        public void Answer_InputEqualValue_OutputCorrect(int input, string expected)
        {
            string output = this._fizzBuzz.Answer(input);

            Assert.AreEqual(expected, output);
        }
    }
}
