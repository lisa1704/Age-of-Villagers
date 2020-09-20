using Age_of_Villagers.Egyptian_King;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers.Nation
{
    public class Egyptian_King : INation
    {
        string name;

        public Egyptian_King(string name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public void GetHouse(Graphics graphics, Point _point)
        {
            Egyptian_House Egyptian_house = new Egyptian_House(new Point(_point.X, _point.Y), new Point(_point.X - 8, _point.Y + 12), new Point(_point.X + 3, _point.Y + 15), new Point(_point.X + 8, _point.Y + 8));
            Egyptian_house.Paint(graphics);
        }


        public Color getTerrainColour()
        {
            throw new NotImplementedException();
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Egyptian_Tree egyptian_tree = new Egyptian_Tree(new Point(_point.X, _point.Y), new Point(_point.X - 3, _point.Y - 8), new Point(_point.X + 3, _point.Y - 8), new Point(_point.X - 5, _point.Y - 16), new Point(_point.X + 4, _point.Y - 17), new Point(_point.X - 8, _point.Y - 14), new Point(_point.X - 1, _point.Y - 17), new Point(_point.X + 1, _point.Y - 16), new Point(_point.X + 8, _point.Y - 16));
            egyptian_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            throw new NotImplementedException();
        }
    }
}
