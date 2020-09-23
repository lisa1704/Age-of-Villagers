using System;
using System.Collections.Generic;
using System.Text;
using Age_of_Villagers;
using Age_of_Villagers.Nation_Factory_Creator;
using Age_of_Villagers.Nation;
using Xunit;
using System.Drawing;

namespace AgeOfVillagers.Test
{
    public class Inuit_Test
    {
        Inuit_Hunter inuitHunter = new Inuit_Hunter("Inuit Hunters");


        [Fact]
        public void InuitNameTest()
        {
            Assert.Equal("Inuit Hunters", inuitHunter.getName());
        }


        [Fact]
        public void InuitHunterTerrainColorTest()
        {
            string name = "Inuit Hunters";
            INation nation = new Inuit_Hunter(name);
            Color expected = Color.White;
            Color actual = nation.getTerrainColour();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void InuitHunterHouseTest()
        {
            Point point1 = new Point(100, 100);
           

            try
            {
                Inuit_House inuithouse = new Inuit_House(point1);
                Assert.True(true);
            }
            catch
            {
                Assert.False(true);
            }
        }


        [Fact]
        public void InuitHunterWSTest()
        {
            Point pt1 = new Point();
            Null_Item nullWaterResource = new Null_Item(pt1);
            Point actual = nullWaterResource.DrawNothing();
            Point expected = pt1;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InuitHunterTreeTest()
        {
            Point pt2 = new Point();
            Null_Item nullTree = new Null_Item(pt2);
            Point actual = nullTree.DrawNothing();
            Point expected = pt2;
            Assert.Equal(expected, actual);
        }
    }
}
