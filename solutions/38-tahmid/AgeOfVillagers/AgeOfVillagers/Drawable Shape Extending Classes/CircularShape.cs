using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class CircularShape : DrawableShapes
    {
        Point startingPoint;
        Pen p;
        Graphics g;
        int startAng=Constants.FILL_CIRCLE_STARTING_ANGLE, endAng=Constants.FULL_CIRCLE_ENDING_ANGle;
        int length, width;
        Pen pen;
        DrawableShapes arc;

        public CircularShape(Graphics g, Pen pen, Point startingPoint, int length, int width)
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

        public override void makeShape()
        {
            arc = getArcs(g, pen, startingPoint, startAng, endAng, length, width);
            drawShape();
        }
    }
}
