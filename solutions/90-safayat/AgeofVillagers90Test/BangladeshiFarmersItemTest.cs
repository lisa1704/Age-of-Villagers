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
            object bdHouseTestObj = bangladeshiFarmers.TestDrawHouse(point);
            bdHouseTestObj.Equals(bdHouseTest);
        }
        [TestMethod]
        public void TestBDTree()
        {
            BangladeshFarmersTree bdTreeTest = new BangladeshFarmersTree(point);
            BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers();
            object bdTreeTestObj = bangladeshiFarmers.TestDrawTree(point);
            bdTreeTestObj.Equals(bdTreeTest);
        }
        [TestMethod]
        public void TestBDWaterSource()
        {
            BangladeshiFarmersWaterSource bdWSTest = new BangladeshiFarmersWaterSource(point);
            BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers();
            object bdWaterSourceTestObj = bangladeshiFarmers.TestDrawWaterSource(point);
            bdWaterSourceTestObj.Equals(bdWSTest);
        }

    }
}
