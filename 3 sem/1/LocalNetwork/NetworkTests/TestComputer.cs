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
            Computer c = new Computer('w', 0);
            Assert.AreEqual(c.OperationSystem, Computer.OS.Windows);
            Assert.IsFalse(c.Virus);
            c.Infection(100);
            c.Infection(100);
            c.Infection(100);
            Assert.IsTrue(c.Virus);
        }
    }
}
