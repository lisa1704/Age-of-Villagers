using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class Tree : IItem
    {
        Point point;
        private Graphics graphics;
        private Pen pen;

        

        public Tree(Point point, Graphics graphics, Pen pen) : 
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
