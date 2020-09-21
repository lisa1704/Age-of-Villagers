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
            BangladeshiFarmers bdFarmersBackgroundColor = new BangladeshiFarmers();
            Color actual = bdFarmersBackgroundColor.BackgroundColor();
            Color expected = Color.Green;

            Assert.AreEqual(actual, expected);
        }
    }
}
