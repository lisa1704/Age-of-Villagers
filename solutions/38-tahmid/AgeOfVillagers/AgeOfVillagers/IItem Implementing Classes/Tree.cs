using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    class Tree : IItem
    {
        Point point;
        public Tree(Point point)
        {
            this.point = point;
        }
        public void placeItem(Shapes shape)
        {
            shape.makeShape();
        }
    }
}
