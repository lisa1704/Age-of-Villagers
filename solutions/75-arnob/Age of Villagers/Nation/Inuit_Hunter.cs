using Age_of_Villagers.Inuit_Hunter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation
{
    public class Inuit_Hunter : INation
    {
        public void GetHouse(Graphics graphics, Point _point)
        {
            Inuit_House inuit_house = new Inuit_House(new Point(_point.X, _point.Y), new Point(_point.X + 16, _point.Y));
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
            return Color.White;
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Null_Item null_object = new Null_Item (_point);
            null_object.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            Null_Item null_object = new Null_Item (_point);
            null_object.Paint(graphics);
        }
    }
}
