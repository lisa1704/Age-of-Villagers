using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Age_of_Villagers;
using Age_of_Villagers.Arab_bedouin;
using Age_of_Villagers.Nation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AgeOfVillagers.Test
{[TestClass()]
   public class Arab_Test
   
    
        {
            Arab_Bedouin arab = new Arab_Bedouin("Arab Bedouin");



        [Fact]

        public void ArabBedouinHouseTest()
        {
            Point pt1 = new Point(100, 100);
            

            try
            {
                Arab_House arabHouse = new Arab_House(pt1);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }



        [Fact]

        public void ArabBedouinTreeTest()
        {
            Point pt1 = new Point(100, 100);
            

            try
            {
                Arab_Tree arabTree = new Arab_Tree(pt1);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }


        [Fact]
        public void ArabWaterResourceTest()
        {
            Point p = new Point();
            Null_Item nullWaterResource = new Null_Item(p);
            Point actual = nullWaterResource.DrawNothing();
            Point expected = p;
            Assert.AreEqual(expected, actual);
        }
    }

}

