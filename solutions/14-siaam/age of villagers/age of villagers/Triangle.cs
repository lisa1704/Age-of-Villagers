﻿using System.Drawing;

namespace age_of_villagers
{
    class Triangle : IShape
    {
        Point p1,p2, p3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public void draw(Graphics g, Pen p)
        {
            g.DrawLine(p, p1, p2);
            g.DrawLine(p, p2, p3);
            g.DrawLine(p, p3, p1);
        }
    }
}