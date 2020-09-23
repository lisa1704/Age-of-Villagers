using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    interface IComplexShape
    {
        void drawComponent(Graphics g, Point p);
    }

    class BDhouse : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            Point trianglePoint1 = new Point(p.X + 16, p.Y - 16);
            Point trianglePoint2 = new Point(p.X + 24, p.Y);
            
            Point rectanglePoint1 = new Point(trianglePoint2.X, trianglePoint2.Y + 16);
            Point rectanglePoint2 = new Point(p.X, p.Y + 16);

            Triangle triangle = new Triangle(p, trianglePoint1, trianglePoint2);
            triangle.draw(g,pen);
            Rectangle rectangle = new Rectangle(p, trianglePoint2,rectanglePoint1,rectanglePoint2);
            rectangle.draw(g, pen);
        }
    }

    class BDtree : IComplexShape
    {
        Pen pen = new Pen(Color.Red);
        public void drawComponent(Graphics g, Point p)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            Point pcenter = new Point(p.X + 8, p.Y + 8);
            Point p1 = new Point(pcenter.X - 2, pcenter.Y);
            Point p2 = new Point(pcenter.X + 2, pcenter.Y);
            Point p3 = new Point(p1.X, p1.Y + 16);
            Point p4 = new Point(p2.X, p3.Y);
            Rectangle rectangle = new Rectangle(p1, p2, p4, p3);
            rectangle.draw(g,pen);
            
        }
    }

}
