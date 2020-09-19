using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Drawable_Shape_Extending_Classes
{
    class Paralellogram : DrawableShapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point topLeftPoint;
        private Point bottomLeftPoint;
        private Point topRightPoint;
        private Point bottomRightPoint;
        private int width;
        private DrawableShapes rightLine;
        private DrawableShapes leftLine;
        private DrawableShapes topLine;
        private DrawableShapes bottomLine;


        public Paralellogram(Graphics graphics, Pen pen, Point topLeftPoint, Point bottomLeftPoint, int width)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.topLeftPoint = topLeftPoint;
            this.bottomLeftPoint = bottomLeftPoint;
            
            this.width = width;
        }

        public override void drawShape()
        {
            topLine.drawShape();
            bottomLine.drawShape();
            leftLine.drawShape();
            rightLine.drawShape();
        }

        public override void makeShape()
        {
            topRightPoint = new Point(topLeftPoint.X + width, topLeftPoint.Y);
            bottomRightPoint= new Point(bottomLeftPoint.X + width, bottomLeftPoint.Y);

            topLine = base.getLines(topLeftPoint, topRightPoint, graphics, pen);
            leftLine= base.getLines(topLeftPoint, bottomLeftPoint, graphics, pen);
            rightLine= base.getLines(topRightPoint, bottomRightPoint, graphics, pen);
            bottomLine= base.getLines(bottomLeftPoint, bottomRightPoint, graphics, pen);
            drawShape();

        }
    }
}
