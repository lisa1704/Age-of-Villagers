using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private Panel Drawingpanel;
        public Color terraincolor;
       
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            InuitHouse ihouse = new InuitHouse(point);
            ihouse.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            NullItem nullTree = new NullItem();
            nullTree.Draw(point, Drawingpanel);
        }


        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            NullItem nullWsource = new NullItem();
            nullWsource.Draw(point, Drawingpanel);
        }

        public Color PaintTerrain()
        {
            terraincolor = Color.White;
            return terraincolor;
        }
    }
}
