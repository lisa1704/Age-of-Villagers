using Age_of_Villagers.Arab_bedouin;
using Age_of_Villagers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation
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
        public void GetHouse(Graphics graphics, Point point)
        {
            Arab_House arab_house = new Arab_House(point);
            arab_house.Paint(graphics);

        }

        public Color getTerrainColour()
        {
            return Color.LightYellow;
        }

        public void GetTree(Graphics graphics, Point point)
        {
            Arab_Tree arab_tree = new Arab_Tree(point);
            arab_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            Null_Item null_object = new Null_Item(_point);
            null_object.Paint(graphics);
        }
    }
}
