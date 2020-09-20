using Age_of_Villagers.Bangladeshi_Farmer;
using Age_of_Villagers.BD_Farmer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Bangladeshi_Farmer : INation
    {
        private string nationName;

        public Bangladeshi_Farmer(string nationName)
        {
            this.nationName = nationName;
        }

        public void GetHouse(Graphics graphics, Point _point)
        {

            BDfarmer_House bangladeshi_house = new BDfarmer_House(new Point(_point.X, _point.Y - 8), new Point(_point.X - 8, _point.Y), new Point(_point.X + 8, _point.Y + 8));
            bangladeshi_house.Paint(graphics);
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColour()
        {
            return Color.PaleGreen;
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Age_of_Villagers.Bangladeshi_Farmer.BDfarmer_Tree bangladeshi_tree = new Age_of_Villagers.Bangladeshi_Farmer.BDfarmer_Tree(new Point(_point.X, _point.Y), new Point(_point.X + 9, _point.Y + 20), new Point(_point.X + 15, _point.Y + 12), new Point(_point.X + 7, _point.Y + 8));
            bangladeshi_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            Age_of_Villagers.Bangladeshi_Farmer.BDfarmer_WaterSource bangladeshi_pond = new Age_of_Villagers.Bangladeshi_Farmer.BDfarmer_WaterSource(new Point(_point.X, _point.Y), new Point(_point.X - 6, _point.Y + 12), new Point(_point.X, _point.Y + 18), new Point(_point.X + 9, _point.Y + 12), new Point(_point.X + 12, _point.Y + 18), new Point(_point.X + 18, _point.Y + 6), new Point(_point.X + 15, _point.Y - 3), new Point(_point.X + 6, _point.Y + 3), new Point(_point.X + 6, _point.Y - 2));
            bangladeshi_pond.Paint(graphics);
        }
    }
}
