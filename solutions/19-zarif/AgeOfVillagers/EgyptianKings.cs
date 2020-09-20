using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class EgyptianKings : INation
    {
        private Point _point;

        public EgyptianKings(Point point)
        {
            _point = point;
        }
        public IGraphicShape GetHouse()
        {
            return new EgyptianKingsHouse(_point);
        }

        public Point GetHousePoint()
        {
            return _point;
        }

        public Color GetTerritoryColor()
        {
            return Color.Yellow;
        }

        public Point GetTreePoint()
        {
            return _point;
        }

        public IGraphicShape GetTrees()
        {
            return new EgyptianKingsTree(_point);
        }

        public Point GetWaterPoint()
        {
            return _point;
        }

        public IGraphicShape GetWaterSources()
        {
            return new EgyptianKingsWaterSource(_point);
        }
    }
}
