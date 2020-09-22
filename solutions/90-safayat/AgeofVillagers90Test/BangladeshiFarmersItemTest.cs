using System;
using System.Drawing;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class BangladeshiFarmersItemTest
    {
        Point point = new Point(10, 10);
        [TestMethod]
        public void TestBDHouse()
        {
            BangladeshiFarmerHouse bdHouseTest = new BangladeshiFarmerHouse(point);
            BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers();
            object bdHouseTestObj = bangladeshiFarmers.testDrawHouse(point);
            bdHouseTestObj.Equals(bdHouseTest);
        }
        [TestMethod]
        public void TestBDTree()
        {
            BangladeshFarmersTree bdTreeTest = new BangladeshFarmersTree(point);
            BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers();
            object bdTreeTestObj = bangladeshiFarmers.testDrawTree(point);
            bdTreeTestObj.Equals(bdTreeTest);
        }
        [TestMethod]
        public void TestBDWaterSource()
        {
            BangladeshiFarmersWaterSource bdWSTest = new BangladeshiFarmersWaterSource(point);
            BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers();
            object bdWaterSourceTestObj = bangladeshiFarmers.testDrawWaterSource(point);
            bdWaterSourceTestObj.Equals(bdWSTest);
        }

    }
}
