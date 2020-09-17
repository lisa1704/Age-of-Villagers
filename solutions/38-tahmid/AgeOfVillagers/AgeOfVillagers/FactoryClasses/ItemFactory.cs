using AgeOfVillagers.IItem_Implementing_Classes;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    class ItemFactory
    {
        public IItem GetItem(Point point,string hint)
        {
           
            if (hint.Equals(Constants.TREE_ITEM))
            {
                return new Tree(point);
            }
            else if (hint.Equals(Constants.HOUSE_ITEM))
                return new House(point);
            else if (hint.Equals(Constants.WATER_SOURCE_ITEM))
                return new WaterSource(point);
            return null;
        }
    }
}
