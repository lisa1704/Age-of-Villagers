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
            Point top = new Point(p.X, p.Y);
            Point topleft = new Point(p.X - 70, p.Y + 40);
            Point bottomright = new Point(p.X + 70, p.Y + 120);
            BangladeshiFarmerHouse house = new BangladeshiFarmerHouse(top, topleft, bottomright);
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
