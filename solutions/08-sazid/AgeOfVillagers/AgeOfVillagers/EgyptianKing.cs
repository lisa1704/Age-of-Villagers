﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianKing : INation
    {
        private Color backGroundColor = Color.Yellow;
        public void DrawHouse(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawTree(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public void DrawWaterResource(Graphics g, Point p)
        {
            throw new NotImplementedException();
        }

        public Color GetColor()
        {
            return backGroundColor;
        }
    }
}
