using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Village_extended_classes
{
    class BangladeshiFarmersHouse : IItem
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        ShapeFactory shapeFactory;
       public BangladeshiFarmersHouse (Graphics g,Pen pen,Point point,int length,int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.point = point;
            shapeFactory = new ShapeFactory();

            
        }

        public void placeItem()
        {
            Shape base_shape=shapeFactory.GetShape(g, pen, point, length / 2, width, Constants.RECT_HINT);
            base_shape.makeShape();
            Shape roof_top=shapeFactory.GetShape(g, pen, point, length / 2, width, Constants.TRIANGLE_HINT);
            roof_top.makeShape();

        }
    }
}
