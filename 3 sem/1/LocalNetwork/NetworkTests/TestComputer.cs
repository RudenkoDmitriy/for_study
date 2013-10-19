using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocalNetwork;
using System.Collections.Generic;

namespace NetworkTests
{
    [TestClass]
    public class TestComputer
    {
        [TestMethod]
        public void TestInfectAndConstructor()
        {
            Computer c = new Computer('w', 0, RandNext);
            Assert.AreEqual(c.OperationSystem, Computer.OS.Windows);
            Assert.IsFalse(c.Virus);
            c.Infection();
            c.Infection();
            c.Infection();
            Assert.IsTrue(c.Virus);
        }

        private Random rand = new Random(1565456);
        private int RandNext()
        {
            return rand.Next(0, 100);
        }
    }
}
