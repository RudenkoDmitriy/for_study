using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;

namespace ListTest
{
    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }

        [TestMethod]
        public void TestInsert()
        {
            list.Insert(10, 0);
            Assert.AreEqual(10, list.First.Next.Value);
        }

        [TestMethod]
        public void TestFind()
        {
            Assert.AreEqual(false, list.Find(2));
            list.Insert(2, 0);
            Assert.AreEqual(true, list.Find(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ListEmptyException))]
        public void TestException()
        {
            list.Remove(0);
        }

        [TestMethod]
        public void TestRemove()
        {
            list.Insert(4, 0);
            list.Insert(45, 1);
            Assert.AreEqual(true, list.Find(4));
            list.Remove(0);
            Assert.AreEqual(false, list.Find(4));
        }

        [TestMethod]
        public void TestForeach()
        {
            ListElement<int> pos = list.First;
            list.Insert(1, 0);
            pos = pos.Next;
            list.Insert(2, 1);
            pos = pos.Next;
            list.Insert(3, 2);
            var arr = new int[3];
            int i = 0;
            foreach(int x in list)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(1, arr[0]);
            Assert.AreEqual(2, arr[1]);
            Assert.AreEqual(3, arr[2]);
        }

        [TestMethod]
        public void TestChar()
        {
            var list = new List<char>();
            list.Insert('v', 0);
            list.Insert('c', 1);
            list.Insert('d', 2);
            var arr = new char[3];
            int i = 0;
            foreach (char x in list)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual('v', arr[0]);
            Assert.AreEqual('c', arr[1]);
            Assert.AreEqual('d', arr[2]);
        }

        private List<int> list;
    }
}
