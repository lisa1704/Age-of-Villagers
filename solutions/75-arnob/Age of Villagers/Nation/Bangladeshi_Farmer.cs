
using Age_of_Villagers.Bangladeshi_Farmer_Item;

using System;
using System.Drawing;

namespace Age_of_Villagers.Nation
{
    public class Bangladeshi_Farmer : INation
    {
         string name;

      

        public Bangladeshi_Farmer(string name)
        {
            this.name = name;
        }



        public String getName()
        {
            return name;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {

            BDfarmer_House bangladeshi_house = new BDfarmer_House(_point);
            bangladeshi_house.Paint(graphics);
        }



        public Color getTerrainColour()
        {
            return Color.PaleGreen;
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Age_of_Villagers.BDfarmer_Tree bangladeshi_tree = new BDfarmer_Tree(_point);
            bangladeshi_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            BDfarmer_WaterSource bangladeshi_pond = new BDfarmer_WaterSource(_point);
            bangladeshi_pond.Paint(graphics);
        }
    }
}
