using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1;
using System.Collections.Generic;

namespace MapTests
{
    [TestClass]
    public class MapTests
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
        public void TestLenght()
        {
            listResult = new List<int> { 2, 4, 6 };
            list = Map.MapFunc(new List<int> { 1, 2, 3 }, x => x * 2);
            Assert.AreEqual(list.Count, listResult.Count);
        }

        [TestMethod]
        public void CountTest_1()
        {
            listResult = new List<int> { 2, 4, 6 };
            list = Map.MapFunc(new List<int> { 1, 2, 3 }, x => x * 2);

            for (int i = 0; i < list.Count; ++i)
            {
                Assert.AreEqual(list[i], listResult[i]);
            }
        }

        [TestMethod]
        public void CountTest_2()
        {
            listResult = new List<int> { 7, 7, 7, 7 };
            list = Map.MapFunc(new List<int> { 1, 2, 3, 5 }, x => 7);

            for (int i = 0; i < list.Count; ++i)
            {
                Assert.AreEqual(list[i], listResult[i]);
            }
        }


    }
}
