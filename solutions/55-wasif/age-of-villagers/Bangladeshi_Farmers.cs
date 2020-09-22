
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
        Point p;
        public Bangladeshi_Farmers(Graphics gp, Point p)
        {
            this.gp = gp;
            this.p = p;

        }
        public void draw_house()
        {
            Point p1 = new Point(p.X + 25, p.Y - 25);
            Point p2 = new Point(p.X + 50, p.Y);
            Point p3 = new Point(p.X, p.Y + 25);
            Point p4 = new Point(p2.X, p2.Y + 25);

            gp.DrawLine(pen, p, p1);
            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p2, p);
            gp.DrawLine(pen, p, p2);
            gp.DrawLine(pen, p, p3);
            gp.DrawLine(pen, p2, p4);
            gp.DrawLine(pen, p3, p4);
        }

        public void draw_tree()
        {
            Point p1 = new Point(p.X - 2, p.Y);
            Point p2 = new Point(p.X + 2, p.Y);
            Point p3 = new Point(p.X - 2, p.Y + 50);
            Point p4 = new Point(p.X + 2, p.Y + 50);
            gp.DrawArc(pen, p.X-25, p.Y-30, 50, 50, 0, 360);
        

            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p3, p4);
            gp.DrawLine(pen, p2, p4);
        }

        public void draw_watersource()
        {
            Point p1 = new Point(p.X, p.Y);
            Point p2 = new Point(p.X + 5, p.Y - 2);
            Point p3 = new Point(p.X + 6, p.Y);
            Point p4 = new Point(p.X + 12, p.Y - 5);
            Point p5 = new Point(p.X + 19, p.Y);
            Point p6 = new Point(p.X + 17, p.Y + 9);
            Point p7 = new Point(p.X + 7, p.Y + 5);
            Point p8 = new Point(p.X, p.Y + 11);
            Point p9 = new Point(p.X - 5, p.Y + 7);

            gp.DrawLine(pen, p1, p2);
            gp.DrawLine(pen,p2, p3);
            gp.DrawLine(pen,p3, p4);
            gp.DrawLine(pen,p4, p5);
            gp.DrawLine(pen,p5, p6);
            gp.DrawLine(pen,p6, p7);
            gp.DrawLine(pen,p7, p8);
            gp.DrawLine(pen,p8, p9);
            gp.DrawLine(pen,p9, p1);
        }
    }
}