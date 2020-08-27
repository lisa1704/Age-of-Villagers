using System;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = Age_Of_Villagers.Rectangle;

namespace Age_Of_Villagers_UnitTest.Items
{
    [TestClass]
    public class InuitHunters_ItemSize_Tests
    {

            Point location;
            Rectangle bBox;
            ItemSize houseSize;


            public InuitHunters_ItemSize_Tests()
            {
                location = new Point(0, 0);
                houseSize = new ItemSize(16, 16);
              


            }
        [TestMethod()]
        public void GetBBox_Inuit_House_Test()
        {

            InuitHuntersHouse house = new InuitHuntersHouse(location,houseSize);
            bBox =house.GetBBox();


            Assert.AreEqual(16, bBox.GetWidth());
            Assert.AreEqual(16, bBox.GetHeight());

        }
    }
}
