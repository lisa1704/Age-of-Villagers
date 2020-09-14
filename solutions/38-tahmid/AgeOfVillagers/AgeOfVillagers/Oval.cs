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
        public Oval(Graphics g, Pen pen, Point startPoint, int startAng, int endAng, int length, int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.startingPoint = startPoint;
            this.startAng = startAng;
            this.endAng = endAng;
            shapeFactory = new ShapeFactory();

        }
        public override void drawShape()
        {
            
        }

        internal override void makeShape()
        {
            
        }
    }
}
