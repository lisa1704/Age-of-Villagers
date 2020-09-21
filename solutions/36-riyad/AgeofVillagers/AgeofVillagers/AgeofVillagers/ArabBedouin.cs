﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class ArabBedouin : INation
    {

        Pen pen = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point p)
        {
            ArabBedouinHouse arabHouse = new ArabBedouinHouse(p);
            arabHouse.Paint(g, pen);
            return "Stonehouse";
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point mid)
        {
            throw new NotImplementedException();
        }

        public Color TerrainColor()
        {
            return System.Drawing.Color.LightGoldenrodYellow; //yellowish
        }
    }
}
