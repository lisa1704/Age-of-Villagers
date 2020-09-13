using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Village_extended_classes
{
    class BangladeshiFarmersHouse : IItem
    {
        Graphics g;
        Point p1, p2;
       public BangladeshiFarmersHouse (Graphics g,Point p1,Point p2)
        {
            this.g = g;
            this.p1 = p1;
            this.p2 = p2;
        }

        public void placeItem()
        {
            throw new NotImplementedException();
        }
    }
}
