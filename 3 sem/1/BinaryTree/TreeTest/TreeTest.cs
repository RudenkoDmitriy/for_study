using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree;

namespace TreeTest
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        [TestInitialize]
        public void Initialize()
        {
            tree = new Tree();
        }

        [TestMethod]
        public void TestAdd()
        {
            tree.Add(5);
            tree.Add(6);
            tree.Add(3);
            tree.Add(3);
            tree.Add(78);
            tree.Add(-100);
            int count = 0;
            int[] arr = { -100, 3, 5, 6, 78 };
            foreach (int item in tree)
            {
                Assert.AreEqual(arr[count], item);
                count++;
            }
        }

        [TestMethod]
        public void TestRemove()
        {
            tree.Add(5);
            tree.Add(6);
            tree.Add(3);
            tree.Add(3);
            tree.Add(78);
            tree.Add(-100);
            tree.Remove(3);
            tree.Remove(6);
            int count = 0;
            int[] arr = { -100, 5, 78 };
            foreach (int item in tree)
            {
                Assert.AreEqual(arr[count], item);
                count++;
            }
        }

        [TestMethod]
        public void TestHardRemove()
        {
            tree.Add(5);
            tree.Add(6);
            tree.Add(3);
            tree.Add(3);
            tree.Add(78);
            tree.Add(-100);
            tree.Add(232);
            tree.Add(66);
            tree.Add(323);
            tree.Add(7);
            tree.Add(8);
            tree.Add(55);
            tree.Remove(3);
            tree.Remove(6);
            tree.Remove(323);
            tree.Remove(7);
            tree.Remove(-100);
            tree.Remove(78);
            int count = 0;
            int[] arr = { -100, 5, 8, 55, 66, 232};
            foreach (int item in tree)
            {
                Assert.AreEqual(arr[count], item);
                count++;
            }
        }
      
        private Tree tree;
    }
}
