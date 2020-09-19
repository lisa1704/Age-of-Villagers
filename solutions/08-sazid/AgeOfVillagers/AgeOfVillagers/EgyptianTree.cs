using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianTree : AdvancedShape
    {
        public EgyptianTree(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X, clickPoint.Y);
            Point p2 = new Point(clickPoint.X + 70, clickPoint.Y + 80);
            Point p3 = new Point(clickPoint.X + 140, clickPoint.Y);
            Point p4 = new Point(clickPoint.X + 13, clickPoint.Y + 15);
            Point p5 = new Point(clickPoint.X + 20, clickPoint.Y-10);
            Point p6 = new Point(clickPoint.X - 20, clickPoint.Y);
            Point p7 = new Point(clickPoint.X + 120, clickPoint.Y - 20);
            Point p8 = new Point(clickPoint.X + 123, clickPoint.Y + 20);
            Point p9 = new Point(clickPoint.X + 180, clickPoint.Y);

            addShape(new LineShape(p1, p2));
            addShape(new LineShape(p2, p3));
            addShape(new LineShape(p4, p5));
            addShape(new LineShape(p4, p6));
            addShape(new LineShape(p7, p8));
            addShape(new LineShape(p8, p9));
          
        }
    }
}
