using System;
using Xunit;
using System.Drawing;
using Age_of_Villagers.Nation;
using Age_of_Villagers.House;

namespace Age_of_Villagers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Initial_test()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void BangladeshiTerrainColor()
        {
            string name = "Bangladeshi Farmers" ;
            INation nation = new BangladeshiFarmer(name);
            Color expected = Color.PaleGreen;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void EgyptianKingTerrainColor()
        {
            string name = "Egyptian Kings";
            INation nation = new EgyptianKings(name);
            Color expected = Color.Yellow;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


        [Fact]

        public void ArabBedouinTerrainColor()
        {
            string name = "Arab Bedouin";
            INation nation = new ArabBedouin(name);
            Color expected = Color.LightYellow;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }



        [Fact]

        public void InuitHunterTerrainColor()
        {
            string name = "Inuit Hunters";
            INation nation = new InuitHunter(name);
            Color expected = Color.White;
            Color actual = nation.getTerrainColor();
            Assert.Equal(expected, actual);
        }


    }
}
