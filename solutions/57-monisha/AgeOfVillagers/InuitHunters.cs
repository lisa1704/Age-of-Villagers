﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgeOfVillagers.DrawArc;

namespace AgeOfVillagers
{
    class InuitHunters : INations
    {
        Pen p = new Pen(Color.Black);
        public string DrawHouse(Graphics g, Point pt)
        {
            InuitHouse IglooHouse = new InuitHouse(pt);
            IglooHouse.Paint(g, p);
            
            return "Igloo";
        }

        public void DrawTree(Graphics g, Point pt)
        {
            NullTree ntree = new NullTree();
            ntree.Paint(g, p);
        }

        public void DrawWaterSource(Graphics g, Point MPt)
        {
            NullWater nullWater = new NullWater();
            nullWater.Paint(g, p);
        }

        public Color GetTerrainColor()
        {
            return Color.White;
        }
    }
}
