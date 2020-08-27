using Microsoft.VisualStudio.TestTools.UnitTesting;
using Age_Of_Villagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_Of_Villagers.Tests
{
    [TestClass()]
    public class RectangleTest
    {
        Point topLeft, topRight, bottomRight, bottomLeft;
        Rectangle rectangle;

      

        public RectangleTest()
        {

            topLeft = new Point(0, 16);
            topRight = new Point(24, 16);
            bottomLeft = new Point(0, 0);
            bottomRight = new Point(16, 0);
            rectangle = new Rectangle(topLeft, topRight, bottomLeft, bottomRight);

        }
        [TestMethod()]
        public void GetHeightTest()
        {

            Assert.AreEqual(16, rectangle.GetHeight());
        }


        [TestMethod()]
        public void GetWidthTest()
        {
            Assert.AreEqual(24, rectangle.GetWidth());
        }

    }
}