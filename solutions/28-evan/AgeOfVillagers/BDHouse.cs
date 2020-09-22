using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BDHouse : IAttributes
    {
        Pen p = new Pen(Color.Green);
        public void Draw(Graphics g, Point point)
        {
            Point t1 = new Point(point.X + 25, point.Y - 25);
            Point t2 = new Point(point.X + 50, point.Y);
            Point r1 = new Point(point.X, point.Y + 25);
            Point r2 = new Point(t1.X, t2.Y + 25);

            Triangle t = new Triangle(g, p, point, t1, t2);

            t.DrawShape();

            Rectangle r = new Rectangle(g, p, point, t2, r1, r2);

            r.DrawShape();
        }
    }
}
