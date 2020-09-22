using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Bangladeshi : INation
    {
        //private readonly Pen pen;

        public IShapes DrawTree(Graphics gr, Point p)
        {
            BangladeshiTree t = new BangladeshiTree(p);
        
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
