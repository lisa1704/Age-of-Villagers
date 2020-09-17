using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Oval : BasicShapes
    {
        Point startingPoint;
        Pen p;
        Graphics g;
        int startAng=Constants.OVAL_STARTING_ANG, endAng=Constants.OVAL_ENDING_ANG;
        int length, width;
        Pen pen;
        BasicShapes arc;

        public Oval(Graphics g, Pen pen, Point startingPoint, int length, int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.startingPoint = startingPoint;

            

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
