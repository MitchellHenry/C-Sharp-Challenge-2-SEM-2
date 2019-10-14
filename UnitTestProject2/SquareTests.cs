using System;
using NUnit.Framework;
using SEM_2_CHALLENGE_2_CSharp;

namespace UnitTestProject2
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        [TestCase(5, 25)]
        [TestCase(7, 49)]
        [TestCase(15, 225)]
        public void GetArea_IsCalled_CorrectReturnValue (double input, double expected)
        {
            Square s = new Square("red", input);
            Assert.AreEqual(expected, s.GetArea());
        }

        [Test]
        [TestCase(5, 20)]
        [TestCase(7, 28)]
        [TestCase(15, 60)]
        public void GetPerimiter_IsCalled_CorrectReturnValue(double input, double expected)
        {
            Square s = new Square("red", input);
            Assert.AreEqual(expected, s.GetPerimeter());
        }
    }
}
