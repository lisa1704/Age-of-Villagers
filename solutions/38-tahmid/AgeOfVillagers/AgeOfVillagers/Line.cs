﻿using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Line : Shape
    {
        Point start,end;
        Graphics g;
        Pen pen;

       

        public Line(Point start, Point end,Graphics g, Pen pen)
        {
            
            this.start = start;
            this.end = end;
            this.g = g;
            this.pen = pen;
        }
       


        public override void drawShape()
        {
            g.DrawLine(pen, start, end);

        }

       

        internal override void makeShape()
        {
            drawShape();
        }
    }
}
