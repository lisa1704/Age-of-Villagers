using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class NullNation : INation
    {
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            NullItem nullH = new NullItem();
            nullH.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            NullItem nullT = new NullItem();
            nullT.Draw(point, Drawingpanel);
        }

        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            NullItem nullW = new NullItem();
            nullW.Draw(point, Drawingpanel);
        }

        public void PaintTerrain(Panel Drawingpanel)
        {
            Drawingpanel.BackColor = Color.White;
        }
    }
}
