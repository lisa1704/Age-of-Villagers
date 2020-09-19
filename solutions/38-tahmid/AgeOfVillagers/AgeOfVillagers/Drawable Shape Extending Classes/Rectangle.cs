using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Rectangle : DrawableShapes
    {
        Point start,topRight,bottomRight,bottomLeft;
        Graphics g;
        Pen p;
        int height,width;
        DrawableShapes upLine,downLine,leftLine,rightLine;
        public Rectangle(Graphics g, Pen p, Point start,int height, int width)
        {
            this.start = start;
            this.height = height;
            this.width = width;
            this.g = g;
            this.p = p;
            
            
        }
        public override void drawShape()
        {
            upLine.drawShape();
            downLine.drawShape();
            leftLine.drawShape();
            rightLine.drawShape();
        }
      

        public override void makeShape()
        {
            topRight = new Point(start.X + width, start.Y);
            bottomLeft = new Point(start.X, start.Y + height);
            bottomRight = new Point(start.X + width, start.Y + height);
            upLine = base.getLines(start, topRight, g, p);
            downLine = base.getLines(bottomLeft, bottomRight, g, p);
            rightLine = base.getLines(topRight, bottomRight, g, p);
            leftLine = base.getLines(start, bottomLeft, g, p);
            drawShape();
        }
    }
}
