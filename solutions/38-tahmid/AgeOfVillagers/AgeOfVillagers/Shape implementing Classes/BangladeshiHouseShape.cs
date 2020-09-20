﻿using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Village_extended_classes
{
    class BangladeshiHouseShape : Shapes
    {
        private Graphics g;
        private Pen pen;
        private Point startingPoint;
        private Point roofTopPoint;
        private Point roofRightPoint;
        private Point baseTopRightPoint;
        private Point baseBottomLeftPoint;
        private Point baseBottomRightPoint;
        private int height, width;
        private DrawableShapeFactory basicShapeFactory;
       public BangladeshiHouseShape (Graphics g,Pen pen,Point startinhPoint,int height,int width)
        {
            this.pen = pen;
            this.height = height;
            this.width = width;
            this.g = g;
            this.startingPoint = startinhPoint;
            basicShapeFactory = new DrawableShapeFactory();

            
        }

        public void makeShape()
        {
            baseTopRightPoint = new Point(startingPoint.X + width, startingPoint.Y);
            baseBottomRightPoint= new Point(startingPoint.X + width, startingPoint.Y + 3 * height / 4);
            baseBottomLeftPoint= new Point(startingPoint.X , startingPoint.Y+3*height/4);
            DrawableShapes base_shape = basicShapeFactory.GetDrawableShape(g, pen, startingPoint,baseTopRightPoint,baseBottomLeftPoint,baseBottomRightPoint, Constants.RECT_HINT);
            base_shape.makeShape();
            roofRightPoint = baseTopRightPoint;
            roofTopPoint = new Point(startingPoint.X + width/2, startingPoint.Y- height / 4);
            DrawableShapes roof_top = basicShapeFactory.GetDrawableShape(g, pen, roofTopPoint,roofRightPoint, startingPoint, Constants.TRIANGLE_HINT);
            roof_top.makeShape();
        }

       
    }
}
