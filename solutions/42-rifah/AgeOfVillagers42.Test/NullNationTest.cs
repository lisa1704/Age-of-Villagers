using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class NullNationTest
    {
        [TestMethod]
        public void BackgroundColorTest()
        {
            NullNation NullNationBackgroundColor = new NullNation();
            Color actual = NullNationBackgroundColor.BackgroundColor();
            Color expected = Color.White;

            Assert.AreEqual(actual, expected);
        }
    }
}
