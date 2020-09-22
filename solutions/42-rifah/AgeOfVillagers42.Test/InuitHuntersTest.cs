using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Inuit_Hunters;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class InuitHuntersTest
    {
        [TestMethod]
        public void BackgroundColorTest()
        {
            InuitHunters inuitHuntersBackgroundColor = new InuitHunters();
            Color actual = inuitHuntersBackgroundColor.BackgroundColor();
            Color expected = Color.White;

            Assert.AreEqual(actual, expected);
        }
    }
}
