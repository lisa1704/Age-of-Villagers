using System;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = Age_Of_Villagers.Rectangle;

namespace Age_Of_Villagers_UnitTest.Items
{
    [TestClass]
    public class BangladeshiFarmers_ItemSize_Tests
    {
        Point location;
        Rectangle bBox;
        ItemSize houseSize, treeSize, waterSourceSize;


        public BangladeshiFarmers_ItemSize_Tests()
        {
            location = new Point(0, 0); 
            houseSize=new ItemSize(16, 16);
            treeSize = new ItemSize(16, 24);
            waterSourceSize= new ItemSize(24, 16);


        }
        [TestMethod()]
        public void GetBBox_BangladeshiFarmer_HouseTest()
        {
           

            BangladeshiFarmersHouse house = new BangladeshiFarmersHouse(location,houseSize);
            bBox= house.GetBBox();


            Assert.AreEqual(16, bBox.GetWidth());
            Assert.AreEqual(16, bBox.GetHeight());


        }
        [TestMethod()]
        public void GetBBox_BangladeshiFarmer_WaterSourceTest()
        {

            BangladeshiFarmersWaterSource waterSource = new BangladeshiFarmersWaterSource(location, waterSourceSize);
            bBox= waterSource.GetBBox();


            Assert.AreEqual(24, bBox.GetWidth());
            Assert.AreEqual(16, bBox.GetHeight());

        }

        [TestMethod()]
        public void GetBBox_BangladeshiFarmer_TreeTest()
        {
           
           BangladeshiFarmersTree tree = new BangladeshiFarmersTree(location, treeSize);
           bBox= tree.GetBBox();


            Assert.AreEqual(16, bBox.GetWidth());
            Assert.AreEqual(24, bBox.GetHeight());

        }
    }
}
