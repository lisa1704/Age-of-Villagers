using AgeOfVillagers.NationItems;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers.Nations
{
    class ArabBedouins : INation
    {
        Pen pen = new Pen(Color.Black);
        ArabItems ab = new ArabItems();
        public void DrawHouse(Graphics g, Point p)
        {
            ab.House(g, p);
        }

        public void DrawTree(Graphics g, Point p)
        {
            ab.Tree(g, p);
        }

        public void DrawWater(Graphics g, Point p)
        {
            ab.Water(g, p);
        }

        public Color TerrainColor()
        {
            return Color.Yellow;
        }
    }
}
