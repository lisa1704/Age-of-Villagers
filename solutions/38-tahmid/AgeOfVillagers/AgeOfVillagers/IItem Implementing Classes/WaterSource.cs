using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class WaterSource : IItem
    {
        Point point;
        private Graphics graphics;
        private Pen pen;

        ShapeFactory shapeFactory;
        Shapes shape;



        public WaterSource(Point point, Graphics graphics, Pen pen) 
        {
            this.point = point;
            this.graphics = graphics;
            this.pen = pen;
            shapeFactory = new ShapeFactory();
        }

        public void placeItem(string nationHint)
        {
            shape = shapeFactory.GetShape(graphics, pen, point, nationHint);
        }
    }
}
