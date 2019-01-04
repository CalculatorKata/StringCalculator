using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace CalculatorKataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Step1()
        {
            CalculatorKata calculatorKata = new CalculatorKata();
            Assert.AreEqual(calculatorKata.Add(" "), 0);
        }

        [TestMethod]
        public void Step2()
        {
            CalculatorKata calculatorKata = new CalculatorKata();
            Assert.AreEqual(calculatorKata.Add("0"), 0);
        }

        [TestMethod]
        public void Step3()
        {
            CalculatorKata calculatorKata = new CalculatorKata();
            Assert.AreEqual(calculatorKata.Add("1,3"), 4);
        }

        [TestMethod]
        public void Step4()
        {
            CalculatorKata calculatorKata = new CalculatorKata();
            Assert.AreEqual(calculatorKata.Add("3,-5,3,9"), 15);
        }

    }
}