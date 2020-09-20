using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Drawable_Shape_Extending_Classes
{
    class Vshape : DrawableShapes
    {
        private Point topPoint;
        private Point rightPoint;
        private Point leftPoint;
        private Graphics graphics;
        private Pen pen;

        public Vshape(Point topPoint, Point rightPoint, Point leftPoint, Graphics graphics, Pen pen)
        {
            this.topPoint = topPoint;
            this.rightPoint = rightPoint;
            this.leftPoint = leftPoint;
            this.graphics = graphics;
            this.pen = pen;
        }

        public override void drawShape()
        {
            
        }

        public override void makeShape()
        {
            
        }
    }
}
