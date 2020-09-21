using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        public void Draw_House(Graphics g, Point p)
        {
            BangladeshiFarmersHouse house = new BangladeshiFarmersHouse(p);
            house.Draw_Shape(g);
        }

        public void Draw_Tree(Graphics g, Point p)
        {
            BangladeshiFarmersTree Tree = new BangladeshiFarmersTree(p);
            Tree.Draw_Shape(g);
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            BangladeshiFarmersWater water = new BangladeshiFarmersWater(p);
            water.Draw_Shape(g);
        }

        public Color Color_Terrain()
        {
            return Color.Green;
        }
    }
}
