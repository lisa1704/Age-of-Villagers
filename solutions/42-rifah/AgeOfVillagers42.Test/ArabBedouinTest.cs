using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Arab_Bedouin;
using System.Drawing;

namespace AgeOfVillagers42.Test
{
    [TestClass]
    public class ArabBedouinTest
    {
        [TestMethod]
        public void BackgroundColorTest()
        {
            ArabBedouin arabBedouinBackgroundColor = new ArabBedouin();
            Color actual = arabBedouinBackgroundColor.BackgroundColor();
            Color expected = Color.GreenYellow;

            Assert.AreEqual(actual, expected);
        }
    }
}
