using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreapNS;

namespace TreapTest
{
    [TestClass]
    public class TreapTest
    {
        [TestInitialize]
        public void Initialize()
        {
            treap = new Treap();
        }

        [TestMethod]
        public void TestAddAndFind()
        {
            Assert.AreEqual(false, treap.Find(4));
            treap.Add(4);
            treap.Add(57);
            Assert.AreEqual(true, treap.Find(4));
            Assert.AreEqual(true, treap.Find(57));
        }

        [TestMethod]
        public void TestRemoveAndRemoveNotExistItem()
        {
            treap.Add(467);
            treap.Add(5);
            Assert.AreEqual(true, treap.Find(467));
            Assert.AreEqual(true, treap.Find(5));
            treap.Remove(467);
            Assert.AreEqual(false, treap.Find(467));
            Assert.AreEqual(true, treap.Find(5));
            treap.Remove(5);
            Assert.AreEqual(false, treap.Find(467));
            Assert.AreEqual(false, treap.Find(5));
            treap.Remove(8);
        }

        [TestMethod]
        public void TestIteration()
        {
            treap.Add(467);
            treap.Add(5);
            treap.Add(56);
            treap.Add(96);
            treap.Add(96);
            treap.Add(7);
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 7;
            arr[2] = 56;
            arr[3] = 96;
            arr[4] = 467;
            int count = 0;
            foreach (int item in treap)
            {
                Assert.AreEqual(arr[count], item);
                count++;
            }
        }

        private Treap treap;
    }
}
