using System;
using AoV.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoV.Nations
{
    class InuitHunters : INation
    {
        private Color bgColor = Color.White;

        public string getName()
        {
            return "Inuit Hunters";
        }

        public Color TerrainColor()
        {
            return bgColor;
        }

        public void DrawHouse(Graphics g, Point p)
        {
            InuitHouse igloo = new InuitHouse(p);
            igloo.Draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            NullShape inTree = new NullShape();
            inTree.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            NullShape inWater = new NullShape();
            inWater.Draw(g);
        }
    }
}
