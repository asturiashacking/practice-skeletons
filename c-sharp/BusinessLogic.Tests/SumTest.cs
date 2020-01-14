using BusinessLogic;
using NUnit.Framework;
using System;

namespace BusinessLogic.Tests
{
    [TestFixture]
    public class SumTest
    {
        private readonly Sum _Sum;

        public SumTest()
        {
            _Sum = new Sum();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumOperatorsTest()
        {
            double op1 = 2;
            double op2 = 2.5;

            double result = _Sum.SumOperators(op1, op2);

            Assert.AreEqual((op1 + op2), result, "Sum should 4.5");
        }

        [TestCase(1, 2)]
        public void SumOperatorsTest2(double op1, double op2)
        {
            double expectedResult = op1 + op2;
            double result = _Sum.SumOperators(op1, op2);

            Assert.AreEqual((op1 + op2), result, "Sum should 4.5");
        }
    }
}