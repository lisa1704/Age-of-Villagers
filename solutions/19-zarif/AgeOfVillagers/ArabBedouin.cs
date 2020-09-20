using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class ArabBedouin : INation
    {
        private Point _point;


        public ArabBedouin(Point point)
        {
            _point = point;
        }
        public IGraphicShape GetHouse()
        {

            return new ArabBedouinHouse(_point);
        }

        public Point GetHousePoint()
        {
            return _point;
        }

        public Color GetTerritoryColor()
        {
            return Color.GreenYellow;
        }

        public Point GetTreePoint()
        {
            return _point;
        }

        public IGraphicShape GetTrees()
        {
            return new ArabBedouinTree(_point);
        }

        public Point GetWaterPoint()
        {
            return Point.Empty;
        }

        public IGraphicShape GetWaterSources()
        {
            return new NullHandler();
        }
    }
}
