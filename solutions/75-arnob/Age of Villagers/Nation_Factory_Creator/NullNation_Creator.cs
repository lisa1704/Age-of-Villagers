using System;
using Age_of_Villagers;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_Villagers
{
    public class NullNation_Creator : INation

    {
   

        public void GetHouse(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColour()
        {
            return Color.Black;
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
