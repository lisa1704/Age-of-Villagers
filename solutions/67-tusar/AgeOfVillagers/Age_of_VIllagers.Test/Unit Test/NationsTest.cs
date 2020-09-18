using System;
using System.Text;
using Age_of_Villagers;
using System.Drawing;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Age_of_VIllagers.Test.Unit_Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class NationsTest
    {
        [TestMethod]
        public void TestNationHouse()
        {
            AbstractPainter painter = new BangladeshiPainter(new Panel());
            Assert.AreEqual(painter.getHouseType().GetType(), new BangladeshiHouse().GetType());
        }
    }
}
