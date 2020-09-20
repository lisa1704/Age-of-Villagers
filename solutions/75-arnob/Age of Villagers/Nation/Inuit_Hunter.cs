using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    public class Inuit_Hunter : INation
    {
        public void GetHouse(Graphics graphics, Point _point)
        {
            InuitHouse inuit_house = new InuitHouse(new Point(_point.X, _point.Y), new Point(_point.X + 16, _point.Y));
            inuit_house.Paint(graphics);
        }

        string name;

        public Inuit_Hunter(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }

        public Color getTerrainColour()
        {
            throw new NotImplementedException();
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
