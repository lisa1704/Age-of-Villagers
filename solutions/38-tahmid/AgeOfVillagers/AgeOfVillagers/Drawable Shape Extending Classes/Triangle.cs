using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Triangle : DrawableShapes
    {
        Point startPoint, rightPoint, topPoint;
        Graphics g;
        Pen p;
        int height, base_length;
        DrawableShapes rightLine,leftLine,baseLine;

        public Triangle(Graphics g, Pen p, Point startPoint, int height, int base_length)
        {
            this.startPoint = startPoint;
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

        public Point getTopPoint()
        {
            return topPoint;
        }
        public Point getRightPoint()
        {
            return rightPoint;
        }

        public override void makeShape()
        {
            rightPoint = new Point(startPoint.X + base_length, startPoint.Y);
            topPoint = new Point(startPoint.X + (base_length / 2), startPoint.Y - height);

            rightLine = base.getLines(rightPoint, topPoint, g, p);
            leftLine = base.getLines(startPoint, topPoint, g, p);
            baseLine = base.getLines(startPoint, rightPoint, g, p);

            drawShape();
        }

        
    }
}
