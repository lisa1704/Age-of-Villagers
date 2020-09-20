﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    internal interface IPainter
    {
        void drawHouse(Axis axes);
        void drawTree(Axis axes);
        void drawWaterSource(Axis axes);
        void paintTerrain();
    }
}
