using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        public IGraphicShape GetHouse(Point point)
        {
            return new InuitHuntersHouse(point);
        }

        public Color GetTerritoryColor()
        {
            return Color.White;
        }

        public IGraphicShape GetTrees(Point point)
        {
            return new NullHandler();
        }

        public IGraphicShape GetWaterSources(Point point)
        {
            return new NullHandler();
        }
    }
}
