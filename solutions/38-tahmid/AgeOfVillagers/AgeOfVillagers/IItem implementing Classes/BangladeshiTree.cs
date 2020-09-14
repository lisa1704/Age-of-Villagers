﻿using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AgeOfVillagers.Shape_extended_classes
{
    class BangladeshiTree : IItem
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        ShapeFactory shapeFactory;
   
        public BangladeshiTree(Graphics g, Pen pen, Point point, int length, int width)
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
            Shape leaf = shapeFactory.GetShape(g, pen, point, Constants.OVAL_STARTING_ANG, Constants.OVAL_ENDING_ANG, 3*(length/4), width, Constants.OVAL_HINT);
            leaf.makeShape();
            Shape root= shapeFactory.GetShape(g, pen, new Point(point.X+width/2,point.Y+width/2), 3*(length / 8), width/4, Constants.RECT_HINT);
            root.makeShape();
        }
    }
}
