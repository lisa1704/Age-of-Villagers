using System;
using AoV.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    class BangladeshiFarmer : INation
    {

        private Color bgColor = Color.Green;

        public string getName()
        {
            return "Bangladeshi Farmers";
        }

        public Color TerrainColor()
        {
            return bgColor;
        }

        public void DrawHouse(Graphics g, Point p)
        {
            BangladeshiHouse bdHouse = new BangladeshiHouse(new Point(p.X, p.Y), new Point(p.X - 60, p.Y + 30), new Point(p.X + 60, p.Y + 110));
            bdHouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            BangladeshiTree bdTree = new BangladeshiTree(p);
            bdTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            BangladeshiPond wSource = new BangladeshiPond(p);
            wSource.Draw(g);
        }
    }
}
