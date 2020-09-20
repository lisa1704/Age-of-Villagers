using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class EgyptianWaterSourceShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int egyptian_WATER_SOURCE_HEIGHT;
        private int egyptian_WATER_SOURCE_WIDTH;

        public EgyptianWaterSourceShape(Graphics graphics, Pen pen, Point startingPoint, int egyptian_WATER_SOURCE_HEIGHT, int egyptian_WATER_SOURCE_WIDTH)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.egyptian_WATER_SOURCE_HEIGHT = egyptian_WATER_SOURCE_HEIGHT;
            this.egyptian_WATER_SOURCE_WIDTH = egyptian_WATER_SOURCE_WIDTH;
        }

        public void makeShape()
        {
            
        }
    }
}
