using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_extended_classes;
using AgeOfVillagers.Village_extended_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ItemFactory
    {
        public  IItem GetItem(Graphics g, Pen pen, Point point,string hint)
        {

            
            if (hint.Equals(Constants.BDTREE_HINT))
            {
                return new BangladeshiTree(g, pen, point,  Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            }
            else
                return new BangladeshiFarmersHouse(g, pen, point, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);
            return null;
        }

       
    }
}
