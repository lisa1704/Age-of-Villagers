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
            BangladeshiFarmerHouse house = new BangladeshiFarmerHouse(p);
            house.Draw_Shape(g);
        }

        public void Draw_Tree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color Color_Terrain()
        {
            return Color.Green;
        }
    }
}
