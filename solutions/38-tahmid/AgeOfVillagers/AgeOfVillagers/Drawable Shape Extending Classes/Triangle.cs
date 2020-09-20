using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class Triangle : DrawableShapes
    {
        private Point  rightPoint, topPoint;
        Graphics g;
        Pen p;
        int height, base_length;
        DrawableShapes rightLine,leftLine,baseLine;
        private Point leftPoint;

        public Triangle(Point topPoint, Point rightPoint, Point leftPoint)
        {
            this.topPoint = topPoint;
            this.rightPoint = rightPoint;
            this.leftPoint = leftPoint;
        }

        public override void drawShape()
        {
            rightLine.drawShape();
            leftLine.drawShape();
            baseLine.drawShape();
        }

        public Point getTop()
        {
            return topPoint;
        }

        public override void makeShape()
        {
            
           

            rightLine = base.getLines(rightPoint, topPoint, g, p);
            leftLine = base.getLines(leftPoint, topPoint, g, p);
            baseLine = base.getLines(leftPoint, rightPoint, g, p);

            drawShape();
        }

        
    }
}
