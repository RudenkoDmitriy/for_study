using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;
using System.Collections.Generic;

namespace FilterTests
{
    [TestClass]
    public class FilterTests
    {
        private List<int> list;
        private List<int> listResult;

        [TestInitialize]
        public void Initialize()
        {
            list = null;
            listResult = null;
        }

        [TestMethod]
        public void Test_1()
        {
            list = new List<int> { 1, 2, 3 };
            listResult = Filter.FilterList(list, x => Convert.ToBoolean(x % 2)); // this function return all odd numbers
            Assert.AreEqual(listResult.Count, 2);
            foreach (int i in listResult)
            {
                if (!Convert.ToBoolean((i % 2)))
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void Test_2()
        {
            list = new List<int> { 0, 1, 2, 3, 4 };
            listResult = Filter.FilterList(list, x => Convert.ToBoolean(x)); // this function return all numbers > 0
            Assert.AreEqual(listResult.Count, 4);
            foreach (int i in listResult)
            {
                if (!Convert.ToBoolean(i))
                {
                    Assert.Fail();
                }
            }
        }
    }
}
