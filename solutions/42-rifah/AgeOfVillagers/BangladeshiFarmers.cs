using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class BangladeshiFarmers : INation
    {
        Pen p = new Pen(Color.Green);
        public void DrawHouse(Graphics g, Point point)
        {
            g.DrawLine(p, point.X, point.Y, 100, 100);
        }
        public void DrawTree()
        {
            throw new NotImplementedException();
        }
        public void DrawWaterSource()
        {
            throw new NotImplementedException();
        }
    }
}
