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
        [TestCase(2469, "")]
        [TestCase(3172, "---")]
        [TestCase(4317, "*--")]
        [TestCase(5371, "*---")]
        [TestCase(1357, "----")]
        [TestCase(7315, "*---")]
        [TestCase(5731, "**--")]
        [TestCase(5713, "****")]
        public void Answer_InputValue_OutputCorrect(int input, string expected)
        {
            string output = this._codeBreaker.Answer(input);

            Assert.AreEqual(expected, output);
        }
    }
}
