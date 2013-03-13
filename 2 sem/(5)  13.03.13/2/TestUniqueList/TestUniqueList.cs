using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;

namespace TestUniqueList
{   
    [TestClass]
    public class TestUniqueList
    {
        private UniqueList list = null;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        public void TestFind()
        {
            Assert.IsFalse(list.Find(0));
            Assert.IsFalse(list.Find(10));
        }

        [TestMethod]
        public void TestInsert()
        {
            list.Insert(20, list.First());
            list.Insert(23, list.First());
            Assert.IsTrue(list.Find(20));
            Assert.IsTrue(list.Find(23));
        }

        [TestMethod]
        public void TestLength()
        {
            Assert.AreEqual(list.Length(), 0);
            list.Insert(12, list.First());
            Assert.AreEqual(list.Length(), 1);
            list.Insert(23, list.First());
            Assert.AreEqual(list.Length(), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(AddExistingNumberException))]
        public void TestDubleInsert()
        {
            list.Insert(10, list.First());
            Assert.AreEqual(list.Length(), 1);
            list.Insert(10, list.First());
            Assert.AreEqual(list.Length(), 1);
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveNotExistingNumberException))]
        public void TestRemoveNotExistingNumber()
        {
            list.Remove(0);
            list.Remove(34);
        }
    }
}
