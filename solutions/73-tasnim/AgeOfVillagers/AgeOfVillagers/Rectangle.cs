using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Rectangle : AbstractShape
    {
        private Point TopLeft;
        private Point BottomRight;
        private Point TopRight;
        private Point BottomLeft;
        public Rectangle(Point topLeft, Point BottomRight)
        {
            TopRight = new Point(BottomRight.X, topLeft.Y);
            BottomLeft = new Point(topLeft.X, BottomRight.Y);

            addShape(new Line(topLeft, BottomLeft));
            addShape(new Line(topLeft, TopRight));
            addShape(new Line(BottomLeft, BottomRight));
            addShape(new Line(BottomRight, TopRight));
        }
}
