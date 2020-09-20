using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class BangladeshiFarmers : INation
    {
        private Point _point;

        public BangladeshiFarmers(Point point)
        {
            _point = point;
        }
        public IGraphicShape GetHouse()
        {
            return new BdFarmerHouse(_point);

        }

        public Point GetHousePoint()
        {
            return _point;
        }

        public Color GetTerritoryColor()
        {
            return Color.Green;

        }

        public Point GetTreePoint()
        {
            return _point;
        }

        public IGraphicShape GetTrees()
        {
            return new BdFarmerTree(_point);

        }

        public Point GetWaterPoint()
        {
            return _point;
        }

        public IGraphicShape GetWaterSources()
        {
            return new BdFarmerWaterSc(_point);
        }
    }
}
