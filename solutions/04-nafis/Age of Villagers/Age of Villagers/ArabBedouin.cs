using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class ArabBedouin: INation
    {
        private readonly Point point;

        public ArabBedouin(Point point)
        {
            this.point = point;
        }
        public IShape HouseDraw()
        {
            return new ArabHouse(point);
        }

        public Point GetHousePoint()
        {
            return point;
        }

        public IShape TreeDraw()
        {
            return new ArabTree(point);
        }
        public Point GetTreePoint()
        {
            return point;
        }

        public IShape WaterSourceDraw()
        {
            return new NullShape();
        }
        public Point GetWaterSourcePoint()
        {
            return Point.Empty;
        }
        public Color GetTerrainColor()
        {
            return Color.LightGoldenrodYellow;
        }
    }
}
