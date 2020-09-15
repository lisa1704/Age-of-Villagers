﻿using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_implementing_Classes
{
    class BangladeshiWaterSource : IItem
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        ShapeFactory shapeFactory;
        public BangladeshiWaterSource(Graphics g, Pen pen, Point point, int length, int width)
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
            Shape nonagon = shapeFactory.GetShape(g, pen, point, length / 8, width / 8, Constants.UNEQUAL_NONAGON_HINT);
            nonagon.makeShape();
        }
    }
}
