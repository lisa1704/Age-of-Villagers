using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AgeOfVillagers90;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BangladeshiFarmers bdfarmerTest = new BangladeshiFarmers();
            string s = bdfarmerTest.BangladeshiFarmerTest();
            Assert.AreEqual("Bangladeshi", s);
        }
    }
}
