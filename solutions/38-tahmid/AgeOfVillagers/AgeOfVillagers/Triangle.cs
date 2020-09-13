using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : Shape
    {
        Point start, right, top;
        Graphics g;
        Pen p;
        int height, base_length;
        Shape rightLine,leftLine,baseLine;

        public Triangle(Graphics g, Pen p, Point start, int height, int base_length)
        {
            this.start = start;
            this.height = height;
            this.base_length = base_length;
            this.g = g;
            this.p = p;
        }

        public override void drawShape()
        {
            rightLine.drawShape();
            leftLine.drawShape();
            baseLine.drawShape();
        }

        internal override void makeShape()
        {
            right = new Point(start.X + base_length, start.Y);
            top = new Point(start.X + (base_length / 2), start.Y - height);

            rightLine = base.getLines(right, top, g, p);
            leftLine = base.getLines(start, top, g, p);
            baseLine = base.getLines(start, right, g, p);

            drawShape();
        }

        
    }
}
