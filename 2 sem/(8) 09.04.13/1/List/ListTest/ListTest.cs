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
            list.Insert(10, list.First());
            Assert.AreEqual(10, list.Retrieve(list.First().Next));
        }

        [TestMethod]
        public void TestFind()
        {
            Assert.AreEqual(false, list.Find(2));
            list.Insert(2, list.First());
            Assert.AreEqual(true, list.Find(2));
        }

        [TestMethod]
        [ExpectedException(typeof(ListEmptyException))]
        public void TestException()
        {
            list.Remove(list.First());
        }

        [TestMethod]
        public void TestRemove()
        {
            ListElement<int> pos = list.First();
            list.Insert(4, pos);
            pos = pos.Next;
            Assert.AreEqual(true, list.Find(4));
            list.Remove(pos);
            Assert.AreEqual(false, list.Find(4));
        }

        [TestMethod]
        public void TestForeach()
        {
            ListElement<int> pos = list.First();
            list.Insert(1, pos);
            pos = pos.Next;
            list.Insert(2, pos);
            pos = pos.Next;
            list.Insert(3, pos);
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
            var pos = list.First();
            list.Insert('v', pos);
            pos = pos.Next;
            list.Insert('c', pos);
            pos = pos.Next;
            list.Insert('d', pos);
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
