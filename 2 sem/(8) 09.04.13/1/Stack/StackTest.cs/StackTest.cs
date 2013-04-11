using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(StackEmptyException))]
        public void EmptyStackTest()
        {
            stack.Pop();
        }

        [TestMethod]
        public void TestPushAndTop()
        {
            stack.Push(3);
            Assert.AreEqual(3, stack.Top());
            Assert.AreEqual(3, stack.Top());
        }

        [TestMethod]
        public void TestPushSomeElementsAndPop()
        {
            stack.Push(45);
            stack.Push(8);
            stack.Push(7);
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(8, stack.Pop());
            Assert.AreEqual(45, stack.Top());
        }

        [TestMethod]
        public void TestChar()
        {
            var stack = new Stack<char>();
            stack.Push('v');
            stack.Push('n');
            Assert.AreEqual('n', stack.Pop());
            Assert.AreEqual('v', stack.Pop());
        }

        private Stack<int> stack;
    }
}
