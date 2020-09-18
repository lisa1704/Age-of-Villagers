using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class House : IItem
    {
        Point point;
        private Graphics graphics;
        private Pen pen;

       

        public House(Point point, Graphics graphics, Pen pen) 
        {
            this.point = point;
            this.graphics = graphics;
            this.pen = pen;
        }

        public void placeItem(Shapes shape)
        {
            shape.makeShape();
        }
    }
}
