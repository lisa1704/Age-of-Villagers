
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
            Age_of_Villagers.BDfarmer_Tree bangladeshi_tree = new BDfarmer_Tree(new Point(_point.X, _point.Y), new Point(_point.X + 9, _point.Y + 20), new Point(_point.X + 15, _point.Y + 12), new Point(_point.X + 7, _point.Y + 8));
            bangladeshi_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            BDfarmer_WaterSource bangladeshi_pond = new BDfarmer_WaterSource(new Point(_point.X, _point.Y), new Point(_point.X - 6, _point.Y + 12), new Point(_point.X, _point.Y + 18), new Point(_point.X + 9, _point.Y + 12), new Point(_point.X + 12, _point.Y + 18), new Point(_point.X + 18, _point.Y + 6), new Point(_point.X + 15, _point.Y - 3), new Point(_point.X + 6, _point.Y + 3), new Point(_point.X + 6, _point.Y - 2));
            bangladeshi_pond.Paint(graphics);
        }
    }
}
