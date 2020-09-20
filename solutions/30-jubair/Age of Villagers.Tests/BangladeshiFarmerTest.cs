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
    public class BangladeshiFarmerTest
    {

        INation nation = new BangladeshiFarmer("Bangladeshi Farmers");

        BangladeshiFarmer bdFarmer = new BangladeshiFarmer("Bangladeshi Farmers");


        [Fact]
        public void BangladeshiNameTest()
        {
            Assert.Equal("Bangladeshi Farmers", bdFarmer.getName());
        }



        [Fact]

        public void BangladeshiHouseTest()
        {
            Point point1 = new Point(100, 92);
            Point point2 = new Point(92, 100);
            Point point3 = new Point(108, 108);

            try
            {
                BangladeshiHouse bdhouse = new BangladeshiHouse(point1, point2, point3);
                Assert.True(true);
            }
            catch
            {
                Assert.False(true);
            }
        }



        [Fact]

        public void BangladeshiTerrainColorTest()
        {
            string name = "Bangladeshi Farmers";
            INation nation = new BangladeshiFarmer(name);
            Color expected = Color.PaleGreen;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }



        [Fact]

        public void BangladeshiTreeTest()
        {
            Point point1 = new Point(100, 100);
            Point point2 = new Point(109, 120);
            Point point3 = new Point(115, 112);
            Point point4 = new Point(107, 108);

            try
            {
                BangladeshiTree bdtree = new BangladeshiTree(point1, point2, point3,point4);
                Assert.True(true);
            }
            catch
            {
                Assert.False(true);
            }
        }


        [Fact]


        public void BangladeshiWaterResourceTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(94, 112);
            Point pt3 = new Point(100, 118);
            Point pt4 = new Point(109, 112);
            Point pt5 = new Point(112, 118);
            Point pt6 = new Point(118, 106);
            Point pt7 = new Point(115, 97);
            Point pt8 = new Point(106, 103);
            Point pt9 = new Point(106, 98);

            try
            {
                BangladeshiPond bdPond = new BangladeshiPond(pt1, pt2, pt3, pt4,pt5,pt6,pt7,pt8,pt9);
                Assert.True(true);
            }
            catch
            {
                Assert.False(true);
            }
        }


    }

}
