
using Age_of_Villagers;
using System;
using Age_of_Villagers;
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
            Egyptian_House Egyptian_house = new Egyptian_House(_point);
            Egyptian_house.Paint(graphics);
        }


        public Color getTerrainColour()
        {
            return Color.Yellow; 
        }

        public void GetTree(Graphics graphics, Point _point)
        {
            Egyptian_Tree egyptian_tree = new Egyptian_Tree(_point);
            egyptian_tree.Paint(graphics);
        }

        public void GetWaterSource(Graphics graphics, Point _point)
        {
            Egyptian_WaterSource egyptian_ws = new Egyptian_WaterSource(_point);
            egyptian_ws.Paint(graphics);
        }
    }
}
