using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class InuitHunters : INation
    {
        private readonly Point point;

        public InuitHunters(Point point)
        {
            this.point = point;
        }
        public IShape HouseDraw()
        {
            return new InuitHouse(point);
        }

        public Point GetHousePoint()
        {
            return point;
        }
        public IShape TreeDraw()
        {
            return new NullShape();
        }
        public Point GetTreePoint()
        {
            return Point.Empty;
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
            return Color.White;
        }
    }
}
