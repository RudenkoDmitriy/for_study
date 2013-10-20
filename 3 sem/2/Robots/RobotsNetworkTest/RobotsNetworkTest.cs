using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots;

namespace RobotsNetworkTest
{
    [TestClass]
    public class RobotsNetworkTest
    {
        [TestMethod]
        public void Test1()
        {
            rn = new RobotsNetwork("..\\..\\..\\test1.txt");
            Assert.IsTrue(rn.isDestroy());
        }

        [TestMethod]
        public void Test2()
        {
            rn = new RobotsNetwork("..\\..\\..\\test2.txt");
            Assert.IsTrue(rn.isDestroy());
        }

        [TestMethod]
        public void Test3()
        {
            rn = new RobotsNetwork("..\\..\\..\\test3.txt");
            Assert.IsFalse(rn.isDestroy());
        }

        private RobotsNetwork rn;
    }
}
