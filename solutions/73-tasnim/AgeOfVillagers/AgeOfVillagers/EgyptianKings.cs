using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        public Color Color_Terrain()
        {
            return Color.Yellow;
        }

        public void Draw_House(Graphics g, Point p)
        {
            EgyptianKingsHouse house = new EgyptianKingsHouse(p);
            house.Draw_Shape(g);
        }

        public void Draw_Tree(Graphics g, Point p)
        {
            EgyptianKingsTree Tree = new EgyptianKingsTree(p);
            Tree.Draw_Shape(g);
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            EgyptianKingsWater Water = new EgyptianKingsWater(p);
            Water.Draw_Shape(g);
        }
    }
}
