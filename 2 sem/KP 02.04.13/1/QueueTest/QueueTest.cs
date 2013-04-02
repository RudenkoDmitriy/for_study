using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;

namespace QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestInitialize]
        public void Initialize()
        {
            queue = new Queue<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void TestException()
        {
            queue.Dequeue();
        }

        [TestMethod]
        public void TestAdd()
        {
            queue.Enqueue(10, 1);
            Assert.AreEqual(10, queue.Dequeue());
        }

        [TestMethod]
        public void TestPriority()
        {
            queue.Enqueue(10, 1);
            queue.Enqueue(12, 3);
            queue.Enqueue(10, 2);
            Assert.AreEqual(12, queue.Dequeue());
        }

        [TestMethod]
        public void TestEnqueueWithEqualPriority()
        {
            queue.Enqueue(10, 1);
            queue.Enqueue(11, 2);
            queue.Enqueue(12, 2);
            queue.Enqueue(100, 1);
            Assert.AreEqual(11, queue.Dequeue());
        }

        private Queue<int> queue;
    }
}
