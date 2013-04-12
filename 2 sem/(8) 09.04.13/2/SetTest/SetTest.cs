using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2;

namespace SetTest
{
    [TestClass]
    public class SetTest
    {
        [TestInitialize]
        public void Initialize()
        {
            set1 = new Set<int>();
            set2 = new Set<int>();
        }

        [TestMethod]
        public void TestAdd()
        {
            set1.Add(23);
            set1.Add(45);
            set1.Add(45);
            set1.Add(6);
            var arr = new int[3];
            int i = 0;
            foreach (int x in set1)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(23, arr[0]);
            Assert.AreEqual(45, arr[1]);
            Assert.AreEqual(6, arr[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(DeleteNotExistElementException))]
        public void TestRemoveNotExistElement()
        {
            set1.Remove(9);
        }

        [TestMethod]
        public void TestRemove()
        {
            set1.Add(23);
            set1.Add(45);
            set1.Add(89);
            set1.Remove(45);
            var arr = new int[2];
            int i = 0;
            foreach (int x in set1)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(23, arr[0]);
            Assert.AreEqual(89, arr[1]);
        }

        [TestMethod]
        public void TestFind()
        {
            set1.Add(23);
            Assert.AreEqual(false, set1.Find(10));
            Assert.AreEqual(true, set1.Find(23));
        }

        [TestMethod]
        public void TestUnion()
        {
            set1.Add(4);
            set1.Add(34);
            set1.Add(2);
            set2.Add(9);
            set2.Add(4);
            set2.Add(34);
            var set = new Set<int>();
            set = set1.Union(set2);
            var arr = new int[4];
            int i = 0;
            foreach (int x in set)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(9, arr[0]);
            Assert.AreEqual(4, arr[1]);
            Assert.AreEqual(34, arr[2]);
            Assert.AreEqual(2, arr[3]);
        }

        [TestMethod]
        public void TestIntersection()
        {
            set1.Add(4);
            set1.Add(34);
            set1.Add(2);
            set2.Add(9);
            set2.Add(4);
            set2.Add(34);
            var set = new Set<int>();
            set = set1.Intersection(set2);
            var arr = new int[2];
            int i = 0;
            foreach (int x in set)
            {
                arr[i] = x;
                ++i;
            }
            Assert.AreEqual(4, arr[0]);
            Assert.AreEqual(34, arr[1]);
        }

        private Set<int> set1;
        private Set<int> set2;
    }
}
