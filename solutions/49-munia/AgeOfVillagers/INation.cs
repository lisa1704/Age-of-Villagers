﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawHouse(Graphics g);
        void DrawTree(Graphics g);
        void drawWater(Graphics g);
        void terrainColor(Graphics g);

    }
}
