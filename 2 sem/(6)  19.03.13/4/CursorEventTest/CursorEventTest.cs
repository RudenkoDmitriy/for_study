using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4;

namespace CursorEvenrTest
{
    [TestClass]
    public class CursorEventTest
    {
        static CursorEvent cEv = new CursorEvent();
        EventArgs eArgs = new EventArgs();
        MoveCursore c = new MoveCursore(cEv);

        [TestMethod]
        public void Left()
        {
            int temp = Console.CursorLeft;
            temp--;
            cEv.EventLeft(eArgs);
            Assert.AreEqual(temp, Console.CursorLeft);
        }

        [TestMethod]
        public void Right()
        {
            int temp = Console.CursorLeft;
            temp++;
            cEv.EventRight(eArgs);
            Assert.AreEqual(temp, Console.CursorLeft);
        }

        [TestMethod]
        public void Up()
        {
            int temp = Console.CursorTop;
            temp--;
            cEv.EventUp(eArgs);
            Assert.AreEqual(temp, Console.CursorTop);
        }

        [TestMethod]
        public void Down()
        {
            int temp = Console.CursorTop;
            temp++;
            cEv.EventDown(eArgs);
            Assert.AreEqual(temp, Console.CursorTop);
        }
    }
}
