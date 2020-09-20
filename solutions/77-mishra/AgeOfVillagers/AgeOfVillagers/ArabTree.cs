using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabTree : CompositeShapes
    {
        public ArabTree(Point point)
        {
            Point point1 = new Point(point.X + 30, point.Y - 10);
            Point point2 = new Point(point.X - 30, point.Y - 10);
            Point point3 = new Point(point.X + 24, point.Y - 24);
            Point point4 = new Point(point.X - 24, point.Y - 24);
            Point point5 = new Point(point.X, point.Y - 28);
            Point point6 = new Point(point.X, point.Y);
            Point point7 = new Point(point.X, point.Y + 30);

            addshapes(new Line(point6, point7));
            addshapes(new Line(point, point1));
            addshapes(new Line(point, point2));
            addshapes(new Line(point, point3));
            addshapes(new Line(point, point4));
            addshapes(new Line(point, point5));
        }
       
    }
}
