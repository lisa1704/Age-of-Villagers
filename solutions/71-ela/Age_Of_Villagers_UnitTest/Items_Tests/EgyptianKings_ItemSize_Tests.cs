using System;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = Age_Of_Villagers.Rectangle;

namespace Age_Of_Villagers_UnitTest.Items
{
    [TestClass]
    public class EgyptianKings_ItemSize_Tests
    {
        Point location;
        Rectangle bBox;
        ItemSize houseSize, treeSize, waterSourceSize;


        public EgyptianKings_ItemSize_Tests()
        {
            location = new Point(0, 0);
            houseSize = new ItemSize(16, 16);
            treeSize = new ItemSize(16, 24);
            waterSourceSize = new ItemSize(12, 12);


        }
        [TestMethod()]
        public void GetBBox_EgyptianKings_HouseTest()
        {


            EgyptianKingsHouse house = new EgyptianKingsHouse(location, houseSize);
            bBox = house.GetBBox();

            Assert.AreEqual(16, bBox.GetHeight());

            Assert.AreEqual(16, bBox.GetWidth());
           

        }
        [TestMethod()]
        public void GetBBox_EgyptianKings_WaterSourceTest()
        {

            EgyptianKingsWaterSource waterSource = new EgyptianKingsWaterSource(location, waterSourceSize);
            bBox = waterSource.GetBBox();


            Assert.AreEqual(12, bBox.GetWidth());
            Assert.AreEqual(12, bBox.GetHeight());

        }

        [TestMethod()]
        public void GetBBox_EgyptianKings_TreeTest()
        {

            EgyptianKingsTree tree = new EgyptianKingsTree(location, treeSize);
            bBox = tree.GetBBox();

            Assert.AreEqual(24, bBox.GetHeight());
            Assert.AreEqual(16, bBox.GetWidth());


        }
    }
}

