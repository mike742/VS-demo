using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExceptionCases()
        {
            VS_demo.Program.SetBalance(0);

            try
            {
                VS_demo.Program.Debit(10);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "balance == 0");
                return;
            }

            Assert.Fail("No exception was thrown");
        }


        [TestMethod]
        public void Devide_PositiveNumbers_RerurnsPositiveResult()
        {
            // AAA A-arrange; A-Act; A-assert
            int expected = 25;
            int num = 100;
            int denom = 4;

            // act
            int actual = VS_demo.Program.Devide(num, denom);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Devide_NegativeNumeratorPositiveDenominator_RerurnsNegativeResult()
        {
            // AAA A-arrange; A-Act; A-assert
            int expected = -25;
            int num = -100;
            int denom = 4;

            // act
            int actual = VS_demo.Program.Devide(num, denom);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Devide_NegativeNumbers_RerurnsPositiveResult()
        {
            // AAA A-arrange; A-Act; A-assert
            int expected = 25;
            int num = -100;
            int denom = -4;

            // act
            int actual = VS_demo.Program.Devide(num, denom);

            Assert.AreEqual(expected, actual);
        }
    }
}
