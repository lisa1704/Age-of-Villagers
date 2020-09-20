﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    public class InuitHunters : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point pt)
        {
            InuitHouse inhouse = new InuitHouse(pt);
            inhouse.Draw(g);
        }

        public void DrawTree(Graphics g, Point pt)
        {
            NullVillageItem InuitNulltree = new NullVillageItem();
            InuitNulltree.paint();
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem InuitNullws = new NullVillageItem();
            InuitNullws.paint();
        }
    }
}