using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class NullNation : INation
    {
        public string DrawHouse(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point mid)
        {
            throw new NotImplementedException();
        }

        public Color TerrainColor()
        {
            throw new NotImplementedException();
        }
    }
}
