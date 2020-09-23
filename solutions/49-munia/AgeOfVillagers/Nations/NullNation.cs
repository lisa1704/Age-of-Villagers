using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class NullNation : Nation
    {
        Pen pen = new Pen(Color.Black);
        public void DrawHouse(Graphics g, Point p)
        {
           g.DrawLine(pen, 20, 100, 50, 300);
        }

        public void DrawTree(Graphics g, Point p)
        {
            g.DrawLine(pen, 20, 100, 250, 300);
        }

        public void DrawWater(Graphics g, Point p)
        {
            g.DrawLine(pen, 20, 100, 450, 300);
        }
        public Color TerrainColor()
        {
            return Color.GhostWhite;
        }
    }
}
