using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillagers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 gameForm = new Form1();
            Assert.AreEqual("", gameForm.getStatus());
        }
    }
}
