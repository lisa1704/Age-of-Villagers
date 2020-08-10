using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers.Tests
{
    [TestClass()]
    public class PointTest
    {
        [TestMethod()]
        public void PointsPointValueTest()
        {
            Point p = new Point(10, 30);
            Assert.AreEqual(10, p.x);
            Assert.AreEqual(30, p.y);
        }
    }
}