using AgeOfVillagers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers.Tests
{
    public class InuitTest
    {
        Point p = new Point();
        [Fact]
        public void ObjectTest()
        {
            INation expected = new InuitHunters();
            Village v = new Village();
            INation actual = v.GetVillage("Inuit Hunters");
            actual.Equals(expected);
        }
        [Fact]
        public void TreeTest()
        {
            InuitHunters tree = new InuitHunters();
            string actual = tree.DrawHouse(null, p);
            string expected = "Inuit Hunters can not plant trees";
            actual.Equals(expected);
        }
        [Fact]
        public void WaterTest()
        {
            InuitHunters water = new InuitHunters();
            string actual = water.DrawHouse(null, p);
            string expected = "Inuit Hunters relies on natural water sources so it is not possible to place water sources";
            actual.Equals(expected);
        }
        [Fact()]
        public void HouseTest()
        {
            InuitHunters house = new InuitHunters();
            string actual = house.DrawHouse(null, p);
            string expected = "Inuit House";
            actual.Equals(expected);
        }
        [Fact]
        public void InuitColorTest()
        {
            InuitHunters color = new InuitHunters();
            Color actual = color.DrawTerrain();
            Color expected = Color.White;

            actual.Equals(expected);
        }
    }
}
