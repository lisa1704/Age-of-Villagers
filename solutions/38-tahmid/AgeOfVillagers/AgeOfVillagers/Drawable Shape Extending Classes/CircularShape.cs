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
        Graphics graphics;
        int startAngle, endAngle;
        int length, width;
        Pen pen;
        DrawableShapes arc;
        private Point point;
        private int height;
        private int startingAngle;
        private int endingAngle;

        public CircularShape(Graphics graphics, Pen pen, Point point, int height, int width, int startingAngle, int endingAngle)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.point = point;
            this.height = height;
            this.width = width;
            this.startingAngle = startingAngle;
            this.endingAngle = endingAngle;
        }

        public override void drawShape()
        {
            arc.drawShape();
        }

        public override void makeShape()
        {
            arc = getArcs(graphics, pen, startingPoint, startAngle, endAngle, length, width);
            drawShape();
        }
    }
}
