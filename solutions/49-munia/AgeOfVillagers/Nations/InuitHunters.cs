using AgeOfVillagers.NationItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class InuitHunters : INation
    {

        Pen pen = new Pen(Color.Black);
        InuitItems ii = new InuitItems();
        public void DrawHouse(Graphics g, Point p)
        {
            ii.House(g,p);
        }

        public void DrawTree(Graphics g, Point p)
        {
            ii.Tree(g, p);
        }

        public void DrawWater(Graphics g, Point p)
        {
            ii.Water(g, p);
        }

        public Color TerrainColor()
        {
            return Color.White;
        }
    }
}
