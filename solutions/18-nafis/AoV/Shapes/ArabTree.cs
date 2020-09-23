using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class ArabTree : ComposeShape
    {
        public ArabTree(Point clickPoint)
        {
            Point rect1 = new Point(clickPoint.X - 5, clickPoint.Y);
            Point rect3 = new Point(clickPoint.X + 5, clickPoint.Y + 80);
            Point p1 = new Point(clickPoint.X - 40, clickPoint.Y - 30);
            Point p2 = new Point(clickPoint.X - 20, clickPoint.Y - 30);
            Point p3 = new Point(clickPoint.X, clickPoint.Y - 30);
            Point p4 = new Point(clickPoint.X + 20, clickPoint.Y - 30);
            Point p5 = new Point(clickPoint.X + 40, clickPoint.Y - 30);

            AddShape(new Rectangle(rect1, rect3));
            AddShape(new Line(clickPoint, p1));
            AddShape(new Line(clickPoint, p2));
            AddShape(new Line(clickPoint, p3));
            AddShape(new Line(clickPoint, p4));
            AddShape(new Line(clickPoint, p5));
        }
    }
}
