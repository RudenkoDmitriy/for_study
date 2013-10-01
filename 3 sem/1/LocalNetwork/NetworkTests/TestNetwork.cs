using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocalNetwork;
using System.Collections.Generic;

namespace NetworkTests
{
    [TestClass]
    public class TestNetwork
    {
        [TestMethod]
        public void TestConstructor()
        {
            Network net = new Network("..\\..\\..\\test.txt", false);
            Assert.AreEqual(net.NumberOfComputers, 5);
            Assert.AreEqual(net.ListOfComputers[2].OperationSystem, Computer.OS.Mac);
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(3, 4);
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    Assert.AreEqual(g.Matrix[i][j], net.Graph.Matrix[i][j]);
        }

        [TestMethod]
        public void TestStep()
        {
            Network net = new Network("..\\..\\..\\test.txt", false);
            net.Step();
            net.Step();
            net.Step();
            Assert.AreEqual(net.ListOfComputers[0].Virus, true);
            Assert.AreEqual(net.ListOfComputers[1].Virus, false);
            Assert.AreEqual(net.ListOfComputers[2].Virus, true);
            Assert.AreEqual(net.ListOfComputers[3].Virus, false);
            Assert.AreEqual(net.ListOfComputers[4].Virus, true);
        }
    }
}
