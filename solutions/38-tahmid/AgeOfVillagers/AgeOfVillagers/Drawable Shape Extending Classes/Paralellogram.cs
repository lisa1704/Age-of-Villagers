using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Drawable_Shape_Extending_Classes
{
    class Paralellogram : DrawableShapes
    {
        private Graphics g;
        private Pen pen;
        private Point topLeftPoint;
        private Point bottomLeftPoint;
        private Point topRightPoint;
        private Point bottomRightPoint;
        private int width;

     
        public Paralellogram(Graphics g, Pen pen, Point topLeftPoint, Point bottomLeftPoint, int width)
        {
            this.g = g;
            this.pen = pen;
            this.topLeftPoint = topLeftPoint;
            this.bottomLeftPoint = bottomLeftPoint;
            
            this.width = width;
        }

        public override void drawShape()
        {
            
        }

        public override void makeShape()
        {
            
        }
    }
}
