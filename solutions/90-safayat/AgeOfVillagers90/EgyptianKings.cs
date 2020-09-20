﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class EgyptianKings : INation
    {
        public Color BackGroundColor()
        {
            return Color.Yellow;
        }

        public void DrawHouse(Graphics g, Point pt)
        {
            EgyptianHouse ekh = new EgyptianHouse(pt);
            ekh.Draw(g);
        }

        public void DrawTree(Graphics g, Point pt)
        {
            EgyptianTree ekt = new EgyptianTree(pt);
            ekt.Draw(g);
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            EgytianWaterSource ekws = new EgytianWaterSource(pt);
            ekws.Draw(g);
        }
    }
}
