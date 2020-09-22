using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Bangladeshi : INation
    {
        public IShapes DrawTree(Graphics g, Point p)
        {
            BangladeshiTree t = new BangladeshiTree(p);
            t.DrawShapes(g);
            return t;

        }
        public IShapes DrawHouse(Graphics g, Point p)
        {
            CompositeShapes h = new BangladeshiHouse(p);
            return h;
        }

        public IShapes DrawWaterSource(Graphics g, Point p)
        {
            CompositeShapes w = new BangladeshiWaterSource(p);
            return w;

        }
    }
}
