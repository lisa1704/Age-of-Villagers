using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class NullNation : INation
    {
        public NullNation(Point point)
        {

        }
        public IShape DrawHouse(Point p)
        {
            return new NullItems();
        }

        public IShape DrawTree(Point p)
        {
            return new NullItems();
        }

        public IShape DrawWaterSource(Point p)
        {
            return new NullItems();
        }

        public Color PaintTerrain(Point p)
        {
            return Color.Empty;
        }
    }
}
