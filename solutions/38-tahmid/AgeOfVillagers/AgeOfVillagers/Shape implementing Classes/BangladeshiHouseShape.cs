using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Village_extended_classes
{
    class BangladeshiHouseShape : Shapes
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        DrawableShapeFactory basicShapeFactory;
       public BangladeshiHouseShape (Graphics g,Pen pen,Point point,int length,int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.point = point;
            basicShapeFactory = new DrawableShapeFactory();

            
        }

        public void makeShape()
        {
            DrawableShapes base_shape = basicShapeFactory.GetDrawableShape(g, pen, point, length / 2, width, Constants.RECT_HINT);
            base_shape.makeShape();
            DrawableShapes roof_top = basicShapeFactory.GetDrawableShape(g, pen, point, length / 2, width, Constants.TRIANGLE_HINT);
            roof_top.makeShape();
        }

       
    }
}
