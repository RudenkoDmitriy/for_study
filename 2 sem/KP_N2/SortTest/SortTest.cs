using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KP_N2;

namespace SortTest
{
    [TestClass]
    public class SortTest
    {        
        [TestMethod]
        public void TestChar()
        {
            char[] arr = {'h', 'a', 'd', 'b', 'c', 'e'};
            BubbleSort<char>.Sort(ref arr);
            Assert.AreEqual('a', arr[0]);
            Assert.AreEqual('b', arr[1]);
            Assert.AreEqual('c', arr[2]);
            Assert.AreEqual('d', arr[3]);
            Assert.AreEqual('e', arr[4]);
            Assert.AreEqual('h', arr[5]);
        }

        [TestMethod]
        public void TestInt()
        {
            int[] arr = { 34, 56, 34, 78, 0, 14, 90 };
            BubbleSort<int>.Sort(ref arr);
            Assert.AreEqual(0, arr[0]);
            Assert.AreEqual(14, arr[1]);
            Assert.AreEqual(34, arr[2]);
            Assert.AreEqual(34, arr[3]);
            Assert.AreEqual(56, arr[4]);
            Assert.AreEqual(78, arr[5]);
            Assert.AreEqual(90, arr[6]);
        }

        [TestMethod]
        public void TestBigInt()
        {
            int[] arr = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                arr[i] = 99 - i;
            }
            BubbleSort<int>.Sort(ref arr);
            for (int i = 0; i < 100; ++i)
            {
                Assert.AreEqual(i, arr[i]);
            }
        }
    }
}
