using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        public IGraphicShape GetHouse(Point point)
        {

            return new ArabBedouinHouse(point);
        }

        public Color GetTerritoryColor()
        {
            return Color.GreenYellow;
        }

        public IGraphicShape GetTrees(Point point)
        {
            return new ArabBedouinTree(point);
        }

        public IGraphicShape GetWaterSources(Point point)
        {
            return new NullHandler();
        }
    }
}
