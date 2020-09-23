﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiHouse : CompositeShapes
    {
        private Point p1, p2, p3, p4, p5;


        public BangladeshiHouse(Point p)
        {
            p1 = p;
            p2 = new Point(p1.X - 20, p1.Y + 20);
            p4 = new Point(p1.X + 20, p1.Y + 40);
            p3 = new Point(p2.X, p4.Y);
            p5 = new Point(p4.X, p2.Y);

            add_shapes(new Triangle(p1, p2, p5));
            add_shapes(new Rectangle( p2, p3, p4, p5));

        }
    }
}
