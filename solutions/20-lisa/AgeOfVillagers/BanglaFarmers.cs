﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers

{
    class BanglaFarmers : INation
    {
        Pen pen = new Pen(Color.Green);
        private string vName;

        public void DrawHouse(Graphics graphics, Point point)
        {
            BanglaHouse bdH = new BanglaHouse(point);
            bdH.Draw(graphics, pen);
        }

        public void DrawTree(Graphics graphics, Point point)
        {
            BanglaTree bdTree = new BanglaTree(point);
            bdTree.Draw(graphics, pen);
        }

        public void DrawWaterSource(Graphics graphics, Point point)
        {
            BanglaWaterSource bdWS = new BanglaWaterSource(point);
            bdWS.Draw(graphics, pen);
        }

        public string GetVillageName()
        {
            return vName;
        }

        public Color SetTerrain()
        {
            return Color.Green;
        }

        public void SetVillageName(string vName)
        {
            this.vName = vName;
        }

        public void SetWaterSource()
        {
            throw new NotImplementedException();
        }

    }
}
