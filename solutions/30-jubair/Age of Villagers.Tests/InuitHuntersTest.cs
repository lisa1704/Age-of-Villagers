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
    public class InuitHuntersTest
    
    {
        InuitHunter inuitHunter = new InuitHunter("Inuit Hunters");


        [Fact]
        public void InuitHunterNameTest()
        {
            Assert.Equal("Inuit Hunters", inuitHunter.getName());
        }


        [Fact]
        public void InuitHunterTerrainColorTest()
        {
            string name = "Inuit Hunters";
            INation nation = new InuitHunter(name);
            Color expected = Color.White;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void InuitHunterHouseTest()
        {
            Point point1 = new Point(100, 100);
            Point point2 = new Point(116, 100);

            try
            {
                InuitHouse inuithouse = new InuitHouse(point1, point2);
                Assert.True(true);
            }
            catch
            {
                Assert.False(true);
            }
        }


        [Fact]
        public void InuitHunterWaterResourceTest()
        {
            Point pt1 = new Point();
            NullVillageComponent nullWaterResource = new NullVillageComponent(pt1);
            Point actual = nullWaterResource.DrawNothing();
            Point expected = pt1;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InuitHunterTreeTest()
        {
            Point pt2 = new Point();
            NullVillageComponent nullTree = new NullVillageComponent(pt2);
            Point actual = nullTree.DrawNothing();
            Point expected = pt2;
            Assert.Equal(expected, actual);
        }


    }
}
