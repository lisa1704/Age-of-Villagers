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

}
