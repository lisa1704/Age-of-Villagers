﻿using System;
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
        Point p0;
        public Egyptian_Kings(Graphics gp, Point p0)
        {
            this.gp = gp;
            this.p0 = p0;
        }
        public void draw_house()
        {
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
            Point p1 = new Point(p0.X + 25, p0.Y - 25);
            Point p2 = new Point(p0.X - 25, p0.Y - 25);
            Point p3 = new Point(p1.X + 25, p1.Y - 25);
            Point p4 = new Point(p1.X, p1.Y - 25);
            Point p5 = new Point(p1.X + 25, p0.Y - 25);
            Point p6 = new Point(p2.X + 25, p2.Y - 25);
            Point p7 = new Point(p2.X - 5, p2.Y - 25);
            Point p8 = new Point(p2.X - 25, p2.Y - 25);
            gp.DrawLine(pen, p0, p1);
            gp.DrawLine(pen, p0, p2);
            gp.DrawLine(pen, p1, p3);
            gp.DrawLine(pen, p1, p4);
            gp.DrawLine(pen, p1, p5);
            gp.DrawLine(pen, p2, p6);
            gp.DrawLine(pen, p2, p7);
            gp.DrawLine(pen, p2, p8);
        }

        public void draw_watersource()
        {
            gp.DrawArc(pen, p0.X, p0.Y, 12, 12, 0, 360);

        }
    }
}