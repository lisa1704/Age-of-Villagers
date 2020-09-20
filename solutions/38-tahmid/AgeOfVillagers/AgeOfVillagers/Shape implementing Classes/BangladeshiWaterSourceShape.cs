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
        private Point startingPoint;

        int length, width;
        DrawableShapeFactory basicShapeFactory;
        public BangladeshiWaterSourceShape(Graphics g, Pen pen, Point startingPoint, int length, int width)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.startingPoint = startingPoint;
            basicShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            topLeftPoint = new Point(startingPoint.X + 3 * unitWidth, startingPoint.Y - 2 * unitHeight);
            topMidLeftPoint = new Point(topLeftPoint.X + unitWidth, startingPoint.Y - 3 * unitHeight);
            topMidPoint = new Point(topMidLeftPoint.X, startingPoint.Y - unitHeight);
            topMidRightPoint = new Point(topMidPoint.X + 2 * unitWidth, startingPoint.Y - 4 * unitHeight);
            bottomLeftPoint = new Point(startingPoint.X + 3 * unitWidth, startingPoint.Y + 4 * unitHeight);
            bottomMidLeftPoint = new Point(bottomLeftPoint.X + unitWidth, startingPoint.Y + unitHeight);
            bottomMidRightPoint = new Point(bottomMidLeftPoint.X + unitWidth, startingPoint.Y + 3 * unitHeight);
            endPoint = new Point(startingPoint.X + 8 * unitWidth, startingPoint.Y);
            DrawableShapes nonagon = basicShapeFactory.GetDrawableShape(g, pen, startingPoint, length / 8, width / 8, Constants.UNEQUAL_NONAGON_HINT);
            nonagon.makeShape();
        }

       
    }
}
