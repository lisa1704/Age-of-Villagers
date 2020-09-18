using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public interface INation
    {
        public void DrawHouse(Point point, Panel Drawingpanel);
        public void DrawTree(Point point, Panel Drawingpanel);
        public void DrawWaterSource(Point point, Panel Drawingpanel);
        public void PaintTerrain(Panel Drawingpanel);

    }
}
