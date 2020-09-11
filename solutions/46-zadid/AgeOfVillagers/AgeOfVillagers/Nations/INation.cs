using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    interface INation
    {
        void DrawHouse(Graphics g, Point location);
        void DrawTree(Graphics g, Point location);
        void DrawWaterResource(Graphics g, Point location);
        void BackgoundColor(Graphics g);
    }
}
