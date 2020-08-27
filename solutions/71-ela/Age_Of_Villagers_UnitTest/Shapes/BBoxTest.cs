using Age_Of_Villagers;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Age_Of_Villagers.Tests
{
    [TestClass()]
    public class BBoxTest
    {
        

        [TestMethod()]
        public void GetBBox_BangladeshiFarmer_WaterSourceTest()
        {
            Point p = new Point(0, 0);
            ItemSize isize = new ItemSize(24, 16);

            BangladeshiFarmersWaterSource w = new BangladeshiFarmersWaterSource(p, isize);
            Rectangle r = w.GetBBox();


            Assert.AreEqual(24, r.GetWidth());
            Assert.AreEqual(16, r.GetHeight());
           
        }

      


    }
}

