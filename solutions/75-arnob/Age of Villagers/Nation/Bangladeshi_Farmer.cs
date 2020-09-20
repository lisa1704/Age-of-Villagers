using System;
using System.Collections.Generic;
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

            Bdfarmer_House bangladeshi_house = new BDfarmerHouse(new Point(_point.X, _point.Y - 8), new Point(_point.X - 8, _point.Y), new Point(_point.X + 8, _point.Y + 8));
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
            throw new NotImplementedException();
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }
    }
}
