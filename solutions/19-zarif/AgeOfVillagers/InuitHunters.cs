using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHunters : INation
    {
        private Point _point;

        public InuitHunters(Point point)
        {
            _point = point;
        }
        public IGraphicShape GetHouse()
        {

            return new InuitHuntersHouse(_point);

        }

        public Point GetHousePoint()
        {
            return _point;
        }

        public Color GetTerritoryColor()
        {
            return Color.White;
        }

        public Point GetTreePoint()
        {
            return new Point();
        }

        public IGraphicShape GetTrees()
        {
            return new NullHandler();
        }

        public Point GetWaterPoint()
        {
            return new Point();
        }

        public IGraphicShape GetWaterSources()
        {
            return new NullHandler();
        }
    }
}
