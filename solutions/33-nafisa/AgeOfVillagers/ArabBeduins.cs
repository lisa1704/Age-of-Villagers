using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class ArabBeduins : INation
    {
        private Panel Drawingpanel;

        public ArabBeduins(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }

        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            ArabHouse abhouse = new ArabHouse(point);
            abhouse.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            ArabTree abtree = new ArabTree(point);
            abtree.Draw(point, Drawingpanel);
        }

    
        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            throw new NotImplementedException();
        }

        public void PaintTerrain(Panel Drawingpanel)
        {
            Drawingpanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }
    }
}
