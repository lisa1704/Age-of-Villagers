﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOV
{
    interface INation
    {
        void DrawHouse(Graphics g, Point p);

        void DrawTree(Graphics g, Point p);

        void DrawWaterSource(Graphics g, Point p);

        Color GetColor();
    }
}
