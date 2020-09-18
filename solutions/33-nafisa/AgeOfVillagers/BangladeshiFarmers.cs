using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
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
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            throw new NotImplementedException();
        }
    }
}
