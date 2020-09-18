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
            AbstractPainter bdpainter = new BangladeshiPainter(new Panel());
            Assert.AreEqual(bdpainter.getHouseType().GetType(), new BangladeshiHouse().GetType());

            AbstractPainter arpainter = new ArabPainter(new Panel());
            Assert.AreEqual(arpainter.getHouseType().GetType(), new ArabHouse().GetType());

            AbstractPainter egpainter = new EgyptianPainter(new Panel());
            Assert.AreEqual(egpainter.getHouseType().GetType(), new EgyptianHouse().GetType());

            AbstractPainter inpainter = new InuitPainter(new Panel());
            Assert.AreEqual(inpainter.getHouseType().GetType(), new InuitHouse().GetType());
        }

        [TestMethod]
        public void TestNationTree()
        {
            AbstractPainter bdpainter = new BangladeshiPainter(new Panel());
            Assert.AreEqual(bdpainter.getTreeType().GetType(), new BangladeshiTree().GetType());

            AbstractPainter arpainter = new ArabPainter(new Panel());
            Assert.AreEqual(arpainter.getTreeType().GetType(), new ArabTree().GetType());

            AbstractPainter egpainter = new EgyptianPainter(new Panel());
            Assert.AreEqual(egpainter.getTreeType().GetType(), new EgyptianTree().GetType());

            AbstractPainter inpainter = new InuitPainter(new Panel());
            Assert.AreEqual(inpainter.getTreeType().GetType(), new NullTree().GetType());
        }
    }
}
