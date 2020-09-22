using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers.Tests
{
    public class EgyptianTest
    {
        Point p = new Point();
        [Fact]
        public void ObjectTest()
        {
            INation expected = new EgyptianKing();
            Village v = new Village();
            INation actual = v.GetVillage("Egyptian King");
            actual.Equals(expected);
        }
        [Fact]
        public void TreeTest()
        {
            EgyptianKing tree = new EgyptianKing();
            string actual = tree.DrawHouse(null, p);
            string expected = "Egyptian Tree";
            actual.Equals(expected);
        }
        [Fact]
        public void WaterTest()
        {
            EgyptianKing water = new EgyptianKing();
            string actual = water.DrawHouse(null, p);
            string expected = "Egyptian River";
            actual.Equals(expected);
        }

        [Fact()]
        public void HouseTest()
        {
            EgyptianKing house = new EgyptianKing();
            string actual = house.DrawHouse(null, p);
            string expected = "Egyptian House";
            actual.Equals(expected);
        }

        [Fact]
        public void ColorTest()
        {
            EgyptianKing color = new EgyptianKing();
            Color actual = color.DrawTerrain();
            Color expected = Color.Gold;

            actual.Equals(expected);
        }
    }
}
