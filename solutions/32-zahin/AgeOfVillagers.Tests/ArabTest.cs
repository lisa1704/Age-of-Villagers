using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers.Tests
{
    public class ArabTest
    {
        Point p = new Point();
        [Fact]
        public void ObjectTest()
        {
            INation expected = new ArabBedouin();
            Village v = new Village();
            INation actual = v.GetVillage("Arab Bedouin");
            actual.Equals(expected);
        }
        [Fact]
        public void TreeTest()
        {
            ArabBedouin tree = new ArabBedouin();
            string actual = tree.DrawHouse(null, p);
            string expected = "Arab Tree";
            actual.Equals(expected);
        }
        [Fact]
        public void WaterTest()
        {
            ArabBedouin water = new ArabBedouin();
            string actual = water.DrawHouse(null, p);
            string expected = "Bedouin villages do not build their own water source";
            actual.Equals(expected);
        }

        [Fact()]
        public void HouseTest()
        {
            ArabBedouin house = new ArabBedouin();
            string actual = house.DrawHouse(null, p);
            string expected = "Arab House";
            actual.Equals(expected);
        }


        [Fact]
        public void ColorTest()
        {
            ArabBedouin color = new ArabBedouin();
            Color actual = color.DrawTerrain();
            Color expected = Color.LightGoldenrodYellow;

            actual.Equals(expected);
        }

    }
}
