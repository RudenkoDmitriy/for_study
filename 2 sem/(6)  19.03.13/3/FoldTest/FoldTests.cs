using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3;
using System.Collections.Generic;

namespace FoldTest
{
    [TestClass]
    public class FoldTests
    {
        [TestMethod]
        public void Test_1()
        {
            Assert.AreEqual(6, (Fold.FoldFunc(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem)));
        }

        [TestMethod]
        public void Test_2()
        {
            Assert.AreEqual(10, (Fold.FoldFunc(new List<int>() { 1, 2, 3, 4 }, 0, (acc, elem) => acc + elem)));
        }
    }
}
