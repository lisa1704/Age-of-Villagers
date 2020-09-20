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
        public  Shapes GetShape(Graphics graphics, Pen pen, Point startingPoint,string hint)
        {


            if (hint.Equals(Constants.BDTREE_HINT))
            {
                return new BangladeshiTreeShape(graphics, pen, startingPoint, Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            }
            else if (hint.Equals(Constants.BDWATERSOURCE_HINT))
            {

                return new BangladeshiWaterSourceShape(graphics, pen, startingPoint, Constants.BDWaterSource_HEIGHT, Constants.BDWATERSOURCE_WIDTH);
            }
            else if (hint.Equals(Constants.BDHOUSE_HINT))
                return new BangladeshiHouseShape(graphics, pen, startingPoint, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);

            else if (hint.Equals(Constants.ARABIAN_HOUSE_HINT))
                return new ArabianHouseShape(graphics, pen, startingPoint, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);

            else if (hint.Equals(Constants.ARABIAN_TREE_HINT))
                return new ArabianTreeShape(graphics, pen, startingPoint, Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            else if (hint.Equals(Constants.EGYPTIAN_HOUSE_HINT))
                return new EgyptianHouseShape(graphics, pen, startingPoint, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);
            else if (hint.Equals(Constants.EGYPTIAN_TREE_HINT))
            {
                return new EgyptianTreeShape(graphics, pen, startingPoint, Constants.TREE_HEIGHT, Constants.TREE_WIDTH);
            }
            else if (hint.Equals(Constants.EGYPTIAN_WATER_SOURCE_HINT))
            {
                return new EgyptianWaterSourceShape(graphics, pen, startingPoint, Constants.Egyptian_WATER_SOURCE_HEIGHT, Constants.Egyptian_WATER_SOURCE_WIDTH);
            }

            else if (hint.Equals(Constants.INUIT_HOUSE_HINT))
            {
                return new InuitHouseIglooShape(graphics, pen, startingPoint, Constants.HOUSE_HEIGHT, Constants.HOUSE_WIDTH);
            }

            return null;
        }

       
    }
}
