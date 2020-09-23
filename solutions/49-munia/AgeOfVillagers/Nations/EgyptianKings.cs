using AgeOfVillagers.NationItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class EgyptianKings : INation
    {
        Pen pen = new Pen(Color.Black);
        EgyptianItems ep = new EgyptianItems();
        public void DrawHouse(Graphics g, Point p)
        {
            ep.House(g, p);
        }

        public void DrawTree(Graphics g, Point p)
        {
            ep.Tree(g, p);
        }

        public void DrawWater(Graphics g, Point p)
        {
            ep.Water(g, p);
        }

        public Color TerrainColor()
        {
            return Color.LightYellow;
        }
    }
}
