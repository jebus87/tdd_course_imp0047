using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RomanConverted;


namespace RomanConvertedTest
{
    [TestFixture]
    public class RomanConvertedTest
    {
        private RomanConverted.RomanConverted _romanconverted;

        [SetUp]
        public void Setup()
        {
            this._romanconverted = new RomanConverted.RomanConverted();
        }

        [Test]
        [TestCase(0, "Número Desconocido")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(50, "L")]
        [TestCase(70, "LXX")]
       // [TestCase(72, "LXXII")]
        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(500, "D")]
        [TestCase(550, "DL")]
        [TestCase(800, "DCCC")]
        [TestCase(1000, "M")]
        public void Answer_InputEqualValue_OutputCorrect(int input, string expected)
        {
            string output = this._romanconverted.Answer(input);

            Assert.AreEqual(expected, output);
        }
    }
}
