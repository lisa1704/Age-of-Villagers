using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class ArabianHouseShape : DrawableShapes
    {
        private Graphics g;
        private Pen pen;
        private Point point;
        private int hOUSE_HEIGHT;
        private int hOUSE_WIDTH;

        public ArabianHouseShape(Graphics g, Pen pen, Point point, int hOUSE_HEIGHT, int hOUSE_WIDTH)
        {
            this.g = g;
            this.pen = pen;
            this.point = point;
            this.hOUSE_HEIGHT = hOUSE_HEIGHT;
            this.hOUSE_WIDTH = hOUSE_WIDTH;
        }

        public override void drawShape()
        {
            
        }

        public override void makeShape()
        {
            
        }
    }
}
