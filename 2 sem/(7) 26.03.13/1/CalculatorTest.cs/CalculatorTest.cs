using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace CalculatorTest.cs
{
    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAdd()
        {
            calc.GetNewNumber(1);
            calc.GetNewNumber(2);
            calc.Add();
            calc.GetNewNumber(3);
            calc.GetNewNumber(0);
            calc.GetNewNumber(0);
            calc.Count();
            Assert.AreEqual(312, calc.GetNumber());
        }

        [TestMethod]
        public void TestSubtract()
        {
            calc.GetNewNumber(1);
            calc.Subtract();
            calc.GetNewNumber(1);
            calc.GetNewNumber(0);
            calc.GetNewNumber(1);
            calc.Count();
            Assert.AreEqual(-100, calc.GetNumber());
        }

        [TestMethod]
        public void TestMultiply()
        {
            calc.GetNewNumber(1);
            calc.GetNewNumber(0);
            calc.Miltiply();
            calc.GetNewNumber(2);        
            calc.GetNewNumber(1);
            calc.Count();
            Assert.AreEqual(210, calc.GetNumber());
        }

        [TestMethod]
        public void TestDivide()
        {
            calc.GetNewNumber(1);
            calc.GetNewNumber(0);
            calc.GetNewNumber(2);
            calc.Divide();
            calc.GetNewNumber(2);
            calc.Count();
            Assert.AreEqual(51, calc.GetNumber());
        }

        [TestMethod]
        public void TestAddThreeNumber()
        {
            calc.GetNewNumber(1);
            calc.GetNewNumber(0);
            calc.Add();
            calc.GetNewNumber(2);
            calc.GetNewNumber(1);
            calc.Add();
            calc.GetNewNumber(9);
            calc.Count();
            Assert.AreEqual(40, calc.GetNumber());
        }

        [TestMethod]
        public void TestMultiplyThreeNumber()
        {
            calc.GetNewNumber(1);
            calc.GetNewNumber(0);
            calc.Miltiply();
            calc.GetNewNumber(2);
            calc.GetNewNumber(1);
            calc.Miltiply();
            calc.GetNewNumber(2);
            calc.Count();
            Assert.AreEqual(420, calc.GetNumber());
        }

        private Calculator calc;
    }
}
