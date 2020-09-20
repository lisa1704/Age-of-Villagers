using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using Age_of_Villagers.Nation;
using Age_of_Villagers.House;
using Age_of_Villagers.NationFactory;
using Age_of_Villagers.Village_Saving;
using Age_of_Villagers.Tree;
using Age_of_Villagers.Water_Resource;


namespace Age_of_Villagers.Tests
{
   public class EgyptianKingsTest
    
    {

        EgyptianKings egyptKings = new EgyptianKings("Egyptian Kings");


        [Fact]
        public void EgyptianKingNameTest()
        {
            Assert.Equal("Egyptian Kings", egyptKings.getName());
        }


        [Fact]

        public void EgyptianTerrainColorTest()
        {
            string name = "Egyptian Kings";
            INation nation = new EgyptianKings(name);
            Color expected = Color.Yellow;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void EgyptianHouseTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(92, 112);
            Point pt3 = new Point(103, 115);
            Point pt4 = new Point(108, 108);

            try
            {
                EgyptianHouse egyptHouse = new EgyptianHouse(pt1, pt2, pt3, pt4);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }



        [Fact]

        public void EgyptianTreeTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(97, 92);
            Point pt3 = new Point(103, 92);
            Point pt4 = new Point(95, 84);
            Point pt5 = new Point(104, 83);
            Point pt6 = new Point(92, 86);
            Point pt7 = new Point(99, 83);
            Point pt8 = new Point(101, 84);
            Point pt9 = new Point(108, 84);

            try
            {
                EgyptianTree egyptTree = new EgyptianTree(pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }


        [Fact]

        public void EgyptianWaterTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(112, 112);
            
            try
            {
                EgyptianWell egyptWell = new EgyptianWell(pt1, pt2);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }

    }
}
