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
        int startAng, endAng;
        public BangladeshiTree(Graphics g, Pen pen, Point point, int length, int width,int startAng,int endAng)
        {
            this.pen = pen;
            this.length = length;
            this.width = width;
            this.g = g;
            this.point = point;
            this.startAng = startAng;
            this.endAng = endAng;
            shapeFactory = new ShapeFactory();
        }

        public void placeItem()
        {
            
        }
    }
}
