using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1_Test;
using System.Drawing;

namespace TestWindowsFormsApp1.UnitTests
{
    
    [TestClass]
    public class UnitTest1
    {
        Graphics g;
        [TestMethod]
        public void Test1()
        {
            var actual = 2;
            var expected = 2;
            Assert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void Test2()
        {
            BangladeshiFarmers bd = new BangladeshiFarmers(g);
            Color expected = Color.Green;
            Color actual = bd.drawcolor();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Test3()
        {
            EgyptianKing ek = new EgyptianKing(g);
            Color expected = Color.Yellow;
            Color actual = ek.drawcolor();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test4()
        {
            ArabBedouin ab = new ArabBedouin(g);
            Color expected = Color.YellowGreen;
            Color actual = ab.drawcolor();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test5()
        {
            InuitHunters ab = new InuitHunters(g);
            Color expected = Color.White;
            Color actual = ab.drawcolor();
            Assert.AreEqual(actual, expected);
        }
    }
}
