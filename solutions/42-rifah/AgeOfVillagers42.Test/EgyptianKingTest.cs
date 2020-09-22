using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using AgeOfVillagers.Egyptian_Kings;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class EgyptianKingTest
    {
        [TestMethod]
        public void BackgroundColorTest()
        {
            EgyptianKings egyptianKingsBackgroundColor = new EgyptianKings();
            Color actual = egyptianKingsBackgroundColor.BackgroundColor();
            Color expected = Color.Yellow;

            Assert.AreEqual(actual, expected);
        }
    }
}
