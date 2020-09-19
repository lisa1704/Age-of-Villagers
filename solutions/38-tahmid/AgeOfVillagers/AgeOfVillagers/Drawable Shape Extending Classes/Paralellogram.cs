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
        private Point firstPoint;
        private Point secondPoint;
        private int height;
        private int width;

        public Paralellogram(Graphics g, Pen pen, Point firstPoint, Point secondPoint, int height, int width)
        {
            this.g = g;
            this.pen = pen;
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.height = height;
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
