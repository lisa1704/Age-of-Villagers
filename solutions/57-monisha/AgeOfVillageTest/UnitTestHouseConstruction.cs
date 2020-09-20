using System;
using System.Drawing;
using AgeOfVillagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeOfVillageTest
{
    [TestClass]
    public class UnitTestHouseConstruction
    {
        Point pt = new Point(16, 16);
        [TestMethod]
        public void TestBangladeshiHouseConstruction()
        {           
            BangladeshiHouse BDHouseTest = new BangladeshiHouse(pt);
            string house = BDHouseTest.CheckHouse();
            string testString = "BDHouse Constructed";

            Assert.AreEqual(house, testString);
        }
    }
}
