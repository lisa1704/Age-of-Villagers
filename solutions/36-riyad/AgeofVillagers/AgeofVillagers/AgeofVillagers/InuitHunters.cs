using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class InuitHunters : INation
    {

        Pen pen = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point p)
        {
            IunitHuntersHouse iHouse = new IunitHuntersHouse(p);
            iHouse.Paint(g, pen);
            return "Igloo";
        }

        public void DrawTree(Graphics g, Point p)
        {
            NulTree nulTree = new NulTree();
        }

        public void DrawWaterSource(Graphics g, Point mid)
        {
            NulTree nulTree = new NulTree();
        }

        public Color TerrainColor()
        {
            return System.Drawing.Color.White;
        }
    }
}
