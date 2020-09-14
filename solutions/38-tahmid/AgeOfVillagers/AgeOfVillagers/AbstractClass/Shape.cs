﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.AbstractClass
{
    abstract class Shape
    {
        public abstract void drawShape();

        public void setDrawingElement( Graphics g, Pen p)
        {
            
        }


        internal Shape getLines(Point start, Point end,Graphics g,Pen pen)
        {
            return new Line(start, end,g,pen);
        }

        internal Shape getArcs(Graphics g, Pen pen, Point point, int startAng, int endAng, int lenght, int width)
        {
            return new Arc(g,pen,point,startAng,endAng,lenght,width);
        }

        internal abstract void makeShape();
    }
}
