using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class Egyptian_Kings : INations
    {
        Pen pen = new Pen(Color.Black);
        Graphics gp;
        public void draw_house()
        {
            Point p0 = new Point(50, 50);
            Point p1 = new Point(p0.X + 50, p0.Y + 25);
            Point p2 = new Point(p0.X + 50, p0.Y - 75);
            Point p3 = new Point(p0.X + 100, p0.Y - 25);

            gp.DrawLine(pen, p0, p1);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p2, p0);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p2, p3);
        }

        public void draw_tree()
        {
            throw new NotImplementedException();
        }

        public void draw_watersource()
        {
            throw new NotImplementedException();
        }
    }
}
