using System;
using System.Drawing;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class EgyptianKingsItemTest
    {
        Point point = new Point(10, 10);
        [TestMethod]
        public void TestEKHouse()
        {
            EgyptianHouse ekHouseTest = new EgyptianHouse(point);
            EgyptianKings egyptianKings = new EgyptianKings();
            object ekHouseTestObj = egyptianKings.testDrawHouse(point);
            ekHouseTestObj.Equals(ekHouseTest);
        }
        [TestMethod]
        public void TestEKTree()
        {
            EgyptianTree ekTreeTest = new EgyptianTree(point);
            EgyptianKings egyptianKings = new EgyptianKings();
            object ekTreeTestObj = egyptianKings.testDrawTree(point);
            ekTreeTestObj.Equals(ekTreeTest);
        }
        [TestMethod]
        public void TestEKWaterSource()
        {
            EgytianWaterSource ekWSTest = new EgytianWaterSource(point);
            EgyptianKings egyptianKings = new EgyptianKings();
            object ekWSTestObj = egyptianKings.testDrawTree(point);
            ekWSTestObj.Equals(ekWSTest);
        }
    }
}
