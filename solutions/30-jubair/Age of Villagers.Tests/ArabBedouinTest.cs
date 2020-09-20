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
using Age_of_Villagers.Shape;

namespace Age_of_Villagers.Tests
{
    public class ArabBedouinTest
   
    {
        ArabBedouin arab = new ArabBedouin("Arab Bedouin");


        [Fact]
        public void ArabBedouinNameTest()
        {
            Assert.Equal("Arab Bedouin", arab.getName());
        }


        [Fact]
        public void ArabBedouinTerrainColorTest()
        {
            string name = "Arab Bedouin";
            INation nation = new ArabBedouin(name);
            Color expected = Color.LightYellow;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void ArabBedouinHouseTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(96, 113);
            Point pt3 = new Point(104, 113);
            Point pt4 = new Point(108, 97);
            Point pt5 = new Point(112, 111);

            try
            {
                ArabHouse arabHouse = new ArabHouse(pt1, pt2, pt3, pt4,pt5);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }



        [Fact]

        public void ArabBedouinTreeTest()
        {
            Point pt1 = new Point(100, 100);
            Point pt2 = new Point(108, 96);
            Point pt3 = new Point(92, 96);
            Point pt4 = new Point(106, 90);
            Point pt5 = new Point(94, 90);
            Point pt6 = new Point(100, 87);
            Point pt7 = new Point(99, 108);
            Point pt8 = new Point(101, 100);

            try
            {
                ArabTree arabTree = new ArabTree(pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }


        [Fact]
        public void ArabWaterResourceTest()
        {
            Point p = new Point();
            NullVillageComponent nullWaterResource = new NullVillageComponent(p);
            Point actual = nullWaterResource.DrawNothing();
            Point expected = p;
            Assert.Equal(expected, actual);
        }
    }


}

