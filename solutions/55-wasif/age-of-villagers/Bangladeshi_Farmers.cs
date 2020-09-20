using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class Bangladeshi_Farmers : INations
    {
        Pen pen = new Pen(Color.Black);
        Graphics gp;
        public void draw_house()
        {
            
            Point p = new Point(50, 50);
            Point p1 = new Point(p.X + 25, p.Y - 25);
            Point p2 = new Point(p.X + 50, p.Y);
            Point p3 = new Point(p.X, p.Y + 25);
            Point p4 = new Point(p2.X, p2.Y + 25);

            gp.DrawLine(pen, p, p1);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p2, p);
            gp.DrawLine(pen, p, p2);
            gp.DrawLine(pen, p, p3);
            gp.DrawLine(pen, p3, p4);
        }

        public void draw_tree()
        {
            Point p0 = new Point(50, 50);
            Point p1 = new Point(p0.X - 2, p0.Y);
            Point p2 = new Point(p0.X + 2, p0.Y);
            Point p3 = new Point(p0.X - 2, p0.Y + 50);
            Point p4 = new Point(p0.X + 2, p0.Y + 50);
            gp.DrawArc(pen, p0.X, p0.Y, 50, 50, 0, 360);

            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p3, p4);
            gp.DrawLine(pen, p2, p4);
        }

        public void draw_watersource()
        {
            throw new NotImplementedException();
        }
    }
}
