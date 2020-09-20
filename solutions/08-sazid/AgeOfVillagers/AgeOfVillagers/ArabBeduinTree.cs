using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class ArabBeduinTree : AdvancedShape
    {
        public ArabBeduinTree(Point clickPoint)
        {
            Point rectP1 = new Point(clickPoint.X - 5, clickPoint.Y);
            Point rectP3 = new Point(clickPoint.X + 5, clickPoint.Y + 80);
            Point p1 = new Point(clickPoint.X - 40, clickPoint.Y - 30);
            Point p2 = new Point(clickPoint.X - 20, clickPoint.Y - 30);
            Point p3 = new Point(clickPoint.X , clickPoint.Y - 30);
            Point p4 = new Point(clickPoint.X + 20, clickPoint.Y - 30);
            Point p5 = new Point(clickPoint.X + 40, clickPoint.Y - 30);

            addShape(new RectangleShape(rectP1, rectP3));
            addShape(new LineShape(clickPoint, p1));
            addShape(new LineShape(clickPoint, p2));
            addShape(new LineShape(clickPoint, p3));
            addShape(new LineShape(clickPoint, p4));
            addShape(new LineShape(clickPoint, p5));
        }
    }
}
