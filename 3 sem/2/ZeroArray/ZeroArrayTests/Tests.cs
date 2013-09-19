using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroArray;

namespace ZeroArrayTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 4, 5, 0, 5, 0, 0 };
            Assert.AreEqual(3, ZeroArray.ZeroArray.NumberOfZeroItems(arr));
        }
    }
}
