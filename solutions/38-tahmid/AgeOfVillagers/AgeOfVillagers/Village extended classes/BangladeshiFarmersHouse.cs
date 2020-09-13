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
            shapeFactory.GetShape(g, pen, point, length / 2, width, Constants.RECT_HINT);
            shapeFactory.GetShape(g, pen, point, length / 2, width, Constants.TRIANGLE_HINT);

        }
    }
}
