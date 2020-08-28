using System;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = Age_Of_Villagers.Rectangle;

namespace Age_Of_Villagers_UnitTest.Items
{


    [TestClass]
    public class ArabBeduin_ItemSize_Tests
    {

        Point location;
        Rectangle bBox;
        ItemSize houseSize, treeSize;


        public ArabBeduin_ItemSize_Tests()
        {
            location = new Point(0, 0);
            houseSize = new ItemSize(16, 16);
            treeSize = new ItemSize(16, 24);



        }
        [TestMethod()]
        public void GetBBox_ArabBeduin_HouseTest()
        {


            ArabBeduinHouse house = new ArabBeduinHouse(location, houseSize);
            bBox = house.GetBBox();


            Assert.AreEqual(16, bBox.GetWidth());
            Assert.AreEqual(16, bBox.GetHeight());


        }


        [TestMethod()]
        public void GetBBox_ArabBeduin_TreeTest()
        {

            ArabBeduinTree tree = new ArabBeduinTree(location, treeSize);
            bBox = tree.GetBBox();


            Assert.AreEqual(16, bBox.GetWidth());
            Assert.AreEqual(24, bBox.GetHeight());

        }
    }
}

