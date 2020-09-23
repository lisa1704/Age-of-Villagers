using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class ArabBeduins : INation
    {
        private Panel Drawingpanel;
        public Color terraincolor;

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
            NullItem nullWsource = new NullItem();
            nullWsource.Draw(point, Drawingpanel);
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.LightGoldenrodYellow;
            return terraincolor;
        }
        
    }
}
