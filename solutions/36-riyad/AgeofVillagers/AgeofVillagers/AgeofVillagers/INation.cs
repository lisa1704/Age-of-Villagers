using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public interface INation
    {
        public string DrawHouse(Graphics g, Point p);
        public void DrawTree(Graphics g, Point p);
        public void DrawWaterSource(Graphics g, Point mid);
        public Color TerrainColor();
    }
}
