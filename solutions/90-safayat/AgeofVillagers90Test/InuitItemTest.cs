using System;
using System.Drawing;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class InuitItemTest
    {
        Point point = new Point(10, 10);
        [TestMethod]
        public void TestIHHouse()
        {
            InuitHouse ihHouseTest = new InuitHouse(point);
            InuitHunters egyptianKings = new InuitHunters();
            object ihHouseTestObj = egyptianKings.testDrawHouse(point);
            ihHouseTestObj.Equals(ihHouseTest);
        }
    }
}
