using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        private Panel Drawingpanel;

        public InuitHunters(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            InuitHouse ihouse = new InuitHouse(point);
            ihouse.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            throw new NotImplementedException();
        }


        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            throw new NotImplementedException();
        }

        public void PaintTerrain(Panel Drawingpanel)
        {
            Drawingpanel.BackColor = System.Drawing.Color.White;
        }
    }
}
