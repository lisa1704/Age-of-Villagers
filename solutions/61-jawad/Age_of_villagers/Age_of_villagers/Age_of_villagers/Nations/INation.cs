using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace Age_of_villagers.Nations
{
    interface INation
    {
        string DrawHouse(Graphics g, Point pt);
        void DrawTree(Graphics g, Point pt);
        void DrawWaterSource(Graphics g, Point MPt);
        Color GetTerrainColor();
    }
}
