﻿using System.Drawing;

namespace AgeOfVillagers
{
    class EgyptianKingsWaterSource : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            int x = e.X;
            int y = e.Y;
            g.DrawArc(p, x - 40, y - 50, 16, 16, 0, 360);
        }
    }
}