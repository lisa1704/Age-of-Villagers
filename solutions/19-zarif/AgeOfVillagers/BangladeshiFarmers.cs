using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
      

        public IGraphicShape GetHouse(Point point)
        {
            return new BdFarmerHouse(point);

        }

        public Color GetTerritoryColor()
        {
            return Color.Green;

        }

        public IGraphicShape GetTrees(Point point)
        {
            return new BdFarmerTree(point);

        }

        public IGraphicShape GetWaterSources(Point point)
        {
            return new BdFarmerWaterSc(point);
        }
    }
}
