using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_implementing_Classes
{
    class BangladeshiWaterSourceShape : Shapes
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        DrablerShapeFactory basicShapeFactory;
        public BangladeshiWaterSourceShape(Graphics g, Pen pen, Point point, int length, int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.point = point;
            basicShapeFactory = new DrablerShapeFactory();
        }

        public void makeShape()
        {
            DrawableShapes nonagon = basicShapeFactory.GetDrableShape(g, pen, point, length / 8, width / 8, Constants.UNEQUAL_NONAGON_HINT);
            nonagon.makeShape();
        }

       
    }
}
