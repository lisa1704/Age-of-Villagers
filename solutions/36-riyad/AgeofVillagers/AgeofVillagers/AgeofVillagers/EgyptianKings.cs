using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EgyptianKings : INation
    {
        Pen pen = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point p)
        {
            EgyptianKingsHouse eHouse = new EgyptianKingsHouse(p);
            eHouse.Paint(g, pen);
            return "Piramid";
        }

        public void DrawTree(Graphics g, Point p)
        {
            EgyptianKingsTree egyptTree = new EgyptianKingsTree(p);
            egyptTree.Paint(g, pen);
        }

        public void DrawWaterSource(Graphics g, Point mid)
        {
            throw new NotImplementedException();
        }

        public Color TerrainColor()
        {
            return System.Drawing.Color.Yellow;
        }
    }
}
