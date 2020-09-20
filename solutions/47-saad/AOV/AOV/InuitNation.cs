﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class InuitNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            InuitHouse igloo = new InuitHouse(p);
            igloo.draw(g);
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterSource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return Color.White;
        }
    }
}
