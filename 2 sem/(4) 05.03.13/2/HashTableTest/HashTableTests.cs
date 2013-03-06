using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;

namespace HashTableTest
{
    [TestClass]
    public class HashTableTests
    {
        HashTable ht = null;
        
        [TestInitialize]
        public void Initialize()
        {
            Hash1 temp = new Hash1();
            ht = new HashTable(temp);
        }
        
        [TestMethod]
        public void TestFind()
        {
            Assert.IsFalse(ht.Find(23));
            Assert.IsFalse(ht.Find(0));
        }

        [TestMethod]
        public void TestAdd()
        {
            ht.Add(2);
            ht.Add(9);
            Assert.IsTrue(ht.Find(9));
            Assert.IsTrue(ht.Find(2));
        }

        [TestMethod]
        public void TestRemove()
        {
            ht.Add(23);
            Assert.IsTrue(ht.Find(23));
            ht.Remove(23);
            Assert.IsFalse(ht.Find(23));
            ht.Remove(221);
        }

        [TestMethod]
        public void TestAddBigNumber()
        {
            ht.Add(1235546510);
            Assert.IsTrue(ht.Find(1235546510));
        }

        [TestMethod]
        public void TestOtherHash()
        {
            Hash2 temp = new Hash2();
            ht = new HashTable(temp);
            ht.Add(234);
            Assert.IsTrue(ht.Find(234));
            Assert.IsFalse(ht.Find(3));
            ht.Remove(234);
            Assert.IsFalse(ht.Find(234));
        }

        [TestMethod]
        public void TestAdd100()
        {
            ht.Add(100);
        }
    }
}
