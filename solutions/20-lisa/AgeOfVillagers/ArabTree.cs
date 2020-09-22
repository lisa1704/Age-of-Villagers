using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class ArabTree : CompositeShape
    {
        public ArabTree(Point p)
        {
            Point p1 = new Point(p.X + 35, p.Y - 5);
            Point p2 = new Point(p.X - 35, p.Y - 5);
            Point p3 = new Point(p.X + 30, p.Y - 30);
            Point p4 = new Point(p.X - 35, p.Y - 30);
            Point p5 = new Point(p.X, p.Y - 35);
            Point topLeft = new Point(p.X - 2, p.Y);
            Point bottomRight = new Point(p.X + 2, p.Y + 45);

            AddComponent(new Rectangle(topLeft, bottomRight));
            AddComponent(new Line(p, p1));
            AddComponent(new Line(p, p2));
            AddComponent(new Line(p, p3));
            AddComponent(new Line(p, p4));
            AddComponent(new Line(p, p5));
    
        }
    }
}
