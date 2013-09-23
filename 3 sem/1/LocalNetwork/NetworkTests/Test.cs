using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocalNetwork;
using System.Collections.Generic;

namespace NetworkTests
{
    [TestClass]
    public class TestGraph
    {
        [TestMethod]
        public void TestTraverse1()
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 4);
            Stack<int> s = g.Traverse();
            int[] arr = { 4, 3, 2, 1, 0 };
            int count = 0;
            foreach (int x in s)
            {
                Assert.AreEqual(x, arr[count]);
                count++;
            }
        }

        [TestMethod]
        public void TestTraverse2()
        {
            Graph g = new Graph(4);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            Stack<int> s = g.Traverse();
            int[] arr = { 3, 1, 2, 0 };
            int count = 0;
            foreach (int x in s)
            {
                Assert.AreEqual(x, arr[count]);
                count++;
            }
        }
    }

    [TestClass]
    public class TestComputer
    {
        [TestMethod]
        public void TestInfectAndConstructor()
        {
            Computer c = new Computer('w', 0, false);
            Assert.AreEqual(c.OperationSystem, Computer.OS.Windows);
            Assert.IsFalse(c.Virus);
            c.Infection();
            c.Infection();
            c.Infection();
            Assert.IsTrue(c.Virus);
        }
    }

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
    }
}
