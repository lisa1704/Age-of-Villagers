using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Arab_Bedouin : INation
    {
        string name;

        public Arab_Bedouin(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public void GetHouse(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }

        public Color getTerrainColour()
        {
            return Color.LightYellow;
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
