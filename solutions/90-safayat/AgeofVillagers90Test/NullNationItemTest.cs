using System;
using System.Drawing;
using AgeOfVillagers90;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeofVillagers90Test
{
    [TestClass]
    public class NullNationItemTest
    {
        readonly Graphics g;
        Point point = new Point(10, 10);
        [TestMethod]
        public void TestNNHouse()
        {
            INation nation = new NullNation();
            object obj = nation.DrawHouse(g, point);
            NullVillageItem TestNullHouse = new NullVillageItem();
            TestNullHouse.Equals(obj);
        }

        [TestMethod]
        public void TestNNTree()
        {
            INation nation = new NullNation();
            object obj = nation.DrawTree(g, point);
            NullVillageItem TestNullTree = new NullVillageItem();
            TestNullTree.Equals(obj);
        }
        [TestMethod]
        public void TestNNws()
        {
            INation nation = new NullNation();
            object obj = nation.DrawWaterSource(g, point);
            NullVillageItem TestNullws = new NullVillageItem();
            TestNullws.Equals(obj);
        }



    }
}
