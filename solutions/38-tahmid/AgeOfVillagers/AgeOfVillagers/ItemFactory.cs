using AgeOfVillagers.Interface;
using AgeOfVillagers.Village_extended_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ItemFactory
    {
        public  IItem GetItem(Graphics g, Pen pen, Point point, int length, int width,string hint)
        {

            return new BangladeshiFarmersHouse(g,pen,point,length,width);
        }
    }
}
