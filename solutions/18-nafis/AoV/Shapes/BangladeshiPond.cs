using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AoV.Shapes
{
    class BangladeshiPond : ComposeShape
    {

        public BangladeshiPond(Point clickPoint)
        {
            Point p1 = new Point(clickPoint.X, clickPoint.Y);
            Point p2 = new Point(clickPoint.X + 30, clickPoint.Y);
            Point p3 = new Point(clickPoint.X + 5, clickPoint.Y + 60);
            Point p4 = new Point(clickPoint.X - 35, clickPoint.Y + 65);
            Point p5 = new Point(clickPoint.X, clickPoint.Y - 20);

            AddShape(new Line(p1, p2));
            AddShape(new Line(p2, p3));
            AddShape(new Line(p3, p4));
            AddShape(new Line(p4, p5));
            AddShape(new Line(p5, p1));

        }

    }
}
