using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace CountTreeTest
{
    [TestClass]
    public class CountTreeTest
    {
        private CountTree tree = null;

        [TestMethod]
        public void TestSimpleAdd()
        {
            tree = new CountTree("../../example_2.txt");
            Assert.AreEqual(tree.Count(), 2);
        }

        [TestMethod]
        public void TestSubtractAndMultiply()
        {
            tree = new CountTree("../../example_0.txt");
            Assert.AreEqual(tree.Count(), 0);
        }

        [TestMethod]
        public void TestDivide()
        {
            tree = new CountTree("../../example_3.txt");
            Assert.AreEqual(tree.Count(), 3);
        }

        [TestMethod]
        public void TestLeftNode()
        {
            tree = new CountTree("../../example_3.txt");
            Assert.AreEqual(tree.Root().Left.Action(), 9);
        }

        [TestMethod]
        public void Test_6()
        {
            tree = new CountTree("../../example_6.txt");
            Assert.AreEqual(tree.Count(), 6);
        }

        [TestMethod]
        public void Test_4()
        {
            tree = new CountTree("../../example_4.txt");
            Assert.AreEqual(tree.Count(), 4);
        }
    }
}
