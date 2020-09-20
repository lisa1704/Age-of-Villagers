using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AgeOfVillagers.Shape_extended_classes
{
    class BangladeshiTreeShape : Shapes
    {
        Graphics g;
        Pen pen;
        Point point;
        int length, width;
        DrawableShapeFactory basicShapeFactory;
   
        public BangladeshiTreeShape(Graphics g, Pen pen, Point point, int length, int width)
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
            DrawableShapes leaf = basicShapeFactory.GetDrawableShape(g, pen, point, 3 * (length / 4), width, Constants.OVAL_HINT);
            leaf.makeShape();
            DrawableShapes root = basicShapeFactory.GetDrawableShape(g, pen, new Point(point.X + 3 * (width / 8), point.Y + width / 2), 5 * (length / 8), width / 4, Constants.RECT_HINT);
            root.makeShape();
        }

       
    }
}
