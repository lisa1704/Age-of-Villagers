using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class InuitHouseShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int house_height;
        private int house_width;

        public InuitHouseShape(Graphics graphics, Pen pen, Point startingPoint, int house_height, int house_width)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.house_height = house_height;
            this.house_width = house_width;
        }

        public void makeShape()
        {
            
        }
    }
}
