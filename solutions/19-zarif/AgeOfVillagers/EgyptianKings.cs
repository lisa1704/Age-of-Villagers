using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        public IGraphicShape GetHouse(Point point)
        {
            return new EgyptianKingsHouse(point);
        }

        public Color GetTerritoryColor()
        {
            return Color.Yellow;
        }

        public IGraphicShape GetTrees(Point point)
        {
            return new EgyptianKingsTree(point);
        }

        public IGraphicShape GetWaterSources(Point point)
        {
            return new EgyptianKingsWaterSource(point);
        }
    }
}
