using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Answer_InputEqual1_OutputEqual1()
        {
            FizzBuzz fb = new FizzBuzz();
            string output = fb.Answer(1);
            Assert.AreEqual("1", output);
        }

    }
}
