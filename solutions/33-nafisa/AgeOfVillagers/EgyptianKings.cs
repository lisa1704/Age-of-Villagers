using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class EgyptianKings : INation
    {
        private Panel Drawingpanel;
        private Color terraincolor;
        public EgyptianKings(Panel Drawingpanel)
        {
            this.Drawingpanel = Drawingpanel;
        }
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            EgyptianHouse ehouse = new EgyptianHouse(point);
            ehouse.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            EgyptianTree etree = new EgyptianTree(point);
            etree.Draw(point, Drawingpanel);
        }

        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            EgyptianWatersource ewatersource = new EgyptianWatersource(point);
            ewatersource.Draw(point, Drawingpanel);
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.Yellow;
            return terraincolor;
        }
    }

   
}
