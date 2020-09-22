using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers.Tests
{
    public class BangladeshiTest
    {
        Point p = new Point();
        [Fact]
        public void ObjectTest()
        {
            INation expected = new BangladeshiFarmers();
            Village v = new Village();
            INation actual = v.GetVillage("Bangladeshi Farmers");
            actual.Equals(expected);
        }
        [Fact]
        public void TreeTest()
        {
            BangladeshiFarmers tree = new BangladeshiFarmers();
            string actual = tree.DrawHouse(null, p);
            string expected = "Bangladeshi Tree";
            actual.Equals(expected);
        }
        [Fact]
        public void WaterTest()
        {
            BangladeshiFarmers water = new BangladeshiFarmers();
            string actual = water.DrawHouse(null, p);
            string expected = "Bangladeshi River";
            actual.Equals(expected);
        }

        [Fact()]
        public void HouseTest()
        {
            BangladeshiFarmers house = new BangladeshiFarmers();
            string actual = house.DrawHouse(null, p);
            string expected = "Bangladeshi House";
            actual.Equals(expected);
        }
        [Fact]
        public void ColorTest()
        {
            BangladeshiFarmers color = new BangladeshiFarmers();
            Color actual = color.DrawTerrain();
            Color expected = Color.PaleGreen;

            actual.Equals(expected);
        }
    }
}
