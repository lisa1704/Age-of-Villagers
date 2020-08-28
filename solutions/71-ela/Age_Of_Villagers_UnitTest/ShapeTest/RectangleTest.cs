using System;
using System.Drawing;
using Age_Of_Villagers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = Age_Of_Villagers.Rectangle;

namespace Age_Of_Villagers_UnitTest.ShapeTest
{
    [TestClass]

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
