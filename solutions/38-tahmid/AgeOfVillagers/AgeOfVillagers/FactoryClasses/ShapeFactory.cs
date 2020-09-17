using AgeOfVillagers.IItem_implementing_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_extended_classes;
using AgeOfVillagers.Village_extended_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ShapeFactory
    {
        public  Shapes GetShape(Graphics g, Pen pen, Point point,string hint)
        {
           

            if (hint.Equals(Constants.BDTREE_HINT))
            {
                return new BangladeshiShapedTree(g, pen, point,  Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            }
            else if (hint.Equals(Constants.BDWATERSOURCE_HINT))
            {

                return new BangladeshiShapedWaterSource(g, pen, point, Constants.BDWaterSource_HEIGHT, Constants.BDWATERSOURCE_WIDTH);
            }
            else
                return new BangladeshiShapedHouse(g, pen, point, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);
            return null;
        }

       
    }
}
