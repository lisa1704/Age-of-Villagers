﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        protected Panel Drawingpanel;
        public Color terraincolor;
        
        public void DrawHouse(Point point, Panel Drawingpanel)
        {
            BangladeshiHouse house = new BangladeshiHouse(point);
            house.Draw(point, Drawingpanel);
        }

        public void DrawTree(Point point, Panel Drawingpanel)
        {
            BangladeshiTree tree = new BangladeshiTree(point);
            tree.Draw(point, Drawingpanel);
        }

        public void DrawWaterSource(Point point, Panel Drawingpanel)
        {
            BangladeshiWaterSource ws = new BangladeshiWaterSource(point);
            ws.Draw(point, Drawingpanel);
        }

        public void PaintTerrain(Panel Drawingpanel)
        {
            terraincolor = Color.LightGreen;
            Drawingpanel.BackColor = terraincolor;
        }
        public Color GetTerrainColor()
        {
            return terraincolor;
        }
    }
}
