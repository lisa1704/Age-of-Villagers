using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public interface INation
    {
        public IShapes DrawTree(Graphics g,Point p);
        public IShapes DrawHouse(Graphics g, Point p);
        public IShapes DrawWaterSource(Graphics g, Point p);

    }
}
