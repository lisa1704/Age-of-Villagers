using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiWaterSource : AdvancedShape
    {
        public BangladeshiWaterSource(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X, clickPoint.Y);
            Point p2 = new Point(clickPoint.X + 30, clickPoint.Y);
            Point p3 = new Point(clickPoint.X + 5, clickPoint.Y + 60);
            Point p4 = new Point(clickPoint.X - 35, clickPoint.Y + 65);
            Point p5 = new Point(clickPoint.X, clickPoint.Y - 20);

            addShape(new LineShape(p1, p2));
            addShape(new LineShape(p2, p3));
            addShape(new LineShape(p3, p4));
            addShape(new LineShape(p4, p5));
            addShape(new LineShape(p5, p1));
        }
    }
}
