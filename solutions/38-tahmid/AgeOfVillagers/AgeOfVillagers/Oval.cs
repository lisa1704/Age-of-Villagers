using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Oval : Shape
    {
        Point startingPoint;
        Pen p;
        Graphics g;
        int startAng, endAng;
        int length, width;
        Pen pen;
        Shape arc;

        public Oval(Graphics g, Pen pen, Point startingPoint, int startAng, int endAng, int length, int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.startingPoint = startingPoint;
            this.startAng = startAng;
            this.endAng = endAng;
            

        }
        public override void drawShape()
        {
            arc.drawShape();
        }

        internal override void makeShape()
        {
            arc = getArcs(g, pen, startingPoint, startAng, endAng, length, width);
            drawShape();
        }
    }
}
