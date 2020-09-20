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
            Arab_House arab_house = new Arab_House(new Point(_point.X, _point.Y), new Point(_point.X - 4, _point.Y + 13), new Point(_point.X + 4, _point.Y + 13), new Point(_point.X + 8, _point.Y - 3), new Point(_point.X + 12, _point.Y + 11));
            arab_house.Paint(graphics);

        }

        public Color getTerrainColour()
        {
            return Color.LightYellow;
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Arab_Tree arab_tree = new Arab_Tree(new Point(_point.X, _point.Y), new Point(_point.X + 8, _point.Y - 4), new Point(_point.X - 8, _point.Y - 4), new Point(_point.X + 6, _point.Y - 10), new Point(_point.X - 6, _point.Y - 10), new Point(_point.X, _point.Y - 13), new Point(_point.X - 1, _point.Y + 8), new Point(_point.X + 1, _point.Y));
            arab_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            Null_item null_object = new Null_item(_point);
            null_object.Paint(graphics);
        }
    }
}
