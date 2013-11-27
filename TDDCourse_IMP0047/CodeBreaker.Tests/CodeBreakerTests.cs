using NUnit.Framework;


namespace CodeBreaker.Tests
{
    [TestFixture]
    public class CodeBreakerTests
    {
        private CodeBreaker _codeBreaker;

        [SetUp]
        public void Setup()
        {
            this._codeBreaker = new CodeBreaker();
        }

        [Test]
        [TestCase(1234, "--")]
        public void Answer_InputValue_OutputCorrect(int input, string expected)
        {
            string output = this._codeBreaker.Answer(input);

            Assert.AreEqual(expected, output);
        }
    }
}
