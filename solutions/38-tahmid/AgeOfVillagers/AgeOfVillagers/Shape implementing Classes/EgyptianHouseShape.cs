using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class EgyptianHouseShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int hOUSE_HEIGHT;
        private int hOUSE_WIDTH;

        public EgyptianHouseShape(Graphics graphics, Pen pen, Point startingPoint, int hOUSE_HEIGHT, int hOUSE_WIDTH)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.hOUSE_HEIGHT = hOUSE_HEIGHT;
            this.hOUSE_WIDTH = hOUSE_WIDTH;
        }

        public void makeShape()
        {
            
        }
    }
}
