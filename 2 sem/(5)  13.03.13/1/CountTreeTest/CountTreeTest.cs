using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace CountTreeTest
{
    [TestClass]
    public class CountTreeTest
    {
        CountTree tree = null;

        [TestInitialize]
        public void Initialize()
        {
            tree = null;
        }

        [TestMethod]
        public void TestAdd()
        {
            tree = new CountTree("example_2.txt");
            Assert.AreEqual(tree.Count(), 2);
        }

        [TestMethod]
        public void TestSubtract()
        {
            tree = new CountTree("example_0.txt");
            Assert.AreEqual(tree.Count(), 0);
        }
    }
}
