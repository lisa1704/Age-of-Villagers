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
        public House (Point point)
        {
            this.point = point;
        }
        public void placeItem(Shapes shape)
        {
            shape.makeShape();
        }
    }
}
