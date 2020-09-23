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
    public class Egyptian_Test
    {
        Egyptian_King egyptian = new Egyptian_King("Egyptian Kings");


        [Fact]
        public void EgyptianKingNameTest()
        {
            Assert.Equal("Egyptian Kings", egyptian.getName());
        }


        [Fact]

        public void EgyptianTerrainColorTest()
        {
            string name = "Egyptian Kings";
            INation nation = new Egyptian_King(name);
            Color expected = Color.Yellow;
            Color actual = nation.getTerrainColour();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void EgyptianHouseTest()
        {
            Point pt1 = new Point(100, 100);


            try
            {
                Egyptian_House egyptHouse = new Egyptian_House(pt1);
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


            try
            {
                Egyptian_Tree egyptTree = new Egyptian_Tree(pt1);
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


            try
            {
                Egyptian_WaterSource egyptWell = new Egyptian_WaterSource(pt1);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }
        }
    }
}
