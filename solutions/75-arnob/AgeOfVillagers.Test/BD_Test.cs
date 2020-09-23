using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Age_of_Villagers.Bangladeshi_Farmer_Item;
using Age_of_Villagers.Nation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeOfVillagers.Test
{
    [TestClass()]
    public class BD_Test
    {
        Bangladeshi_Farmer bdFarmer = new Bangladeshi_Farmer("Bangladeshi Farmers");


        [Fact]
        public void BangladeshiNameTest()
        {
            Assert.AreEqual("Bangladeshi Farmers", bdFarmer.getName());
        }



        [Fact]

        public void BangladeshiHouseTest()
        {
           
            Point point3 = new Point(108, 108);

            try
            {
                BDfarmer_House bdhouse = new BDfarmer_House(point3);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(true);
            }
        }



        [Fact]

        public void BangladeshiTerrainColorTest()
        {
            string name = "Bangladeshi Farmers";
            INation nation = new Bangladeshi_Farmer(name);
            Color expected = Color.PaleGreen;
            Color actual = nation.getTerrainColour();
            Assert.AreEqual(expected, actual);
        }



        [Fact]

        public void BangladeshiTreeTest()
        {
            Point point1 = new Point(100, 100);


            try
            {
                BDfarmer_Tree bdtree = new BDfarmer_Tree(point1);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(true);
            }
        }


        [Fact]


        public void BangladeshiWaterResourceTest()
        {
            Point pt1 = new Point(100, 100);


            try
            {
                BDfarmer_WaterSource bdPond = new BDfarmer_WaterSource(pt1);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(true);
            }
        }
    }
}