using System;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BangladeshiFarmers l = new BangladeshiFarmers();
            string s = l.testHouse();
           
            Assert.AreEqual(s, "BDHouse Constructed");
        }
    }
}
