﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    class BangladeshiNation : INation
    {
        public void DrawHouse(Graphics g, Point p)
        {
            
            Console.WriteLine("Bangladeshi House");            

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
            return Color.Green;
        }
    }
}
