using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        protected Panel Drawingpanel;
        
        public BangladeshiFarmers(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            BangladeshiHouse house = new BangladeshiHouse(Drawingpanel);
            house.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            BangladeshiTree tree = new BangladeshiTree(Drawingpanel);
            tree.Draw(point, Drawingpanel);
        }

        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            BangladeshiWaterSource ws = new BangladeshiWaterSource(Drawingpanel);
            ws.Draw(point, Drawingpanel);
        }

        public void PaintTerrain(Panel Drawingpanel)
        {
           // Drawingpanel.BackColor = System.Drawing.Color.LightGreen;
        }
    }
}
