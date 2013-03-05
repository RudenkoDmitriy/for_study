using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace StackTest
{
    [TestClass]
    public class StackTests
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack();
        }

        private Stack stack = null;

        [TestMethod]
        public void TestPushAndPop()
        {
            stack.Push(12);
            stack.Push(8);
            stack.Push(3);
            Assert.AreEqual(stack.Pop(), 3);
            Assert.AreEqual(stack.Pop(), 8);
            Assert.AreEqual(stack.Pop(), 12);
        }

        [TestMethod]
        public void TestTop()
        {
            stack.Push(23);
            Assert.AreEqual(stack.Top(), 23);
            stack.Push(324);
            Assert.AreEqual(stack.Top(), 324);
        }

        [TestMethod]
        public void TestPopEmpty()
        {
            Assert.AreEqual(stack.Pop(), 0);
        }
    }
}
