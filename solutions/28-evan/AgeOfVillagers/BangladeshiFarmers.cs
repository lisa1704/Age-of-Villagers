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
        Color bkgColor = Color.Green;
        Pen pn = new Pen(Color.Red);
        public Color DrawTerrain()
        {
            return bkgColor;
        }
        public void DrawHouse(Graphics g, Point p)
        {
            BDHouse house = new BDHouse();
            house.Draw(g, p);
        }

        public void DrawTree(Graphics g, Point p)
        {
            BDHouse house = new BDHouse();
            house.Draw(g, p);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            BDHouse house = new BDHouse();
            house.Draw(g, p); ;
        }
    }
}
