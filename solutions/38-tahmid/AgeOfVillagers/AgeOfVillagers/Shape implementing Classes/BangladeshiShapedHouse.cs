using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Village_extended_classes
{
    class BangladeshiShapedHouse : Shapes
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        BasicShapeFactory basicShapeFactory;
       public BangladeshiShapedHouse (Graphics g,Pen pen,Point point,int length,int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.point = point;
            basicShapeFactory = new BasicShapeFactory();

            
        }

        public void makeShape()
        {
            BasicShapes base_shape = basicShapeFactory.GetDrableShape(g, pen, point, length / 2, width, Constants.RECT_HINT);
            base_shape.makeShape();
            BasicShapes roof_top = basicShapeFactory.GetDrableShape(g, pen, point, length / 2, width, Constants.TRIANGLE_HINT);
            roof_top.makeShape();
        }

       
    }
}
