using AgeOfVillagers.IItem_implementing_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_extended_classes;
using AgeOfVillagers.Shape_implementing_Classes;
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
        public  Shapes GetShape(Graphics graphics, Pen pen, Point point,string hint)
        {
            

            if (hint.Equals(Constants.BDTREE_HINT))
            {
                return new BangladeshiTreeShape(graphics, pen, point,  Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            }
            else if (hint.Equals(Constants.BDWATERSOURCE_HINT))
            {

                return new BangladeshiWaterSourceShape(graphics, pen, point, Constants.BDWaterSource_HEIGHT, Constants.BDWATERSOURCE_WIDTH);
            }
            else if(hint.Equals(Constants.BDHOUSE_HINT))
                return new BangladeshiHouseShape(graphics, pen, point, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);
            
            else if (hint.Equals(Constants.ARABIAN_HOUSE_HINT))
                return new ArabianHouseShape(graphics, pen, point, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);

            else if (hint.Equals(Constants.ARABIAN_TREE_HINT))
                return new ArabianTreeShape(graphics, pen, point, Constants.TREE_HEIGHT, Constants.TREE_WIDTH);

            return null;
        }

       
    }
}
