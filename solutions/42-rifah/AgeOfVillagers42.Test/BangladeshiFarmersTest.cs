using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using AgeOfVillagers.Bangladeshi_Farmers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class BangladeshiFarmersTest
    {
        [TestMethod]
        public void BackgroundColorTest()
        {
            BangladeshiFarmers bdFarmer = new BangladeshiFarmers();
            Color color = bdFarmer.BackgroundColor();
            Color expected = Color.Green;

            Assert.AreEqual(color, expected);
        }
    }
}
