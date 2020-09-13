using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangle : Shape
    {
        Point start,topRight,bottomRight,bottomLeft;
        Graphics g;
        Pen p;
        int height,width;
        Shape line;
        public Rectangle(Graphics g, Pen p, Point start,int height, int width)
        {
            this.start = start;
            this.height = height;
            this.width = width;
            this.g = g;
            this.p = p;
            line = new Line(g, p);
            
        }
        public override void drawShape()
        {
            topRight = new Point(start.X + width, start.Y);
            bottomLeft= new Point(start.X , start.Y+height);
            bottomRight = new Point(start.X + width, start.Y+height);
            line.setLinePoints( start, topRight);
            line.drawShape();
            line.setLinePoints( start, bottomLeft);
            line.drawShape();
            line.setLinePoints(  topRight,bottomRight);
            line.drawShape();
            line.setLinePoints( bottomLeft, topRight);
            line.drawShape();

        }
    }
}
