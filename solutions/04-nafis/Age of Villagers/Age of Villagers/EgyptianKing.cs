using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class EgyptianKing : INation
    {
        private readonly Point point;

        public EgyptianKing(Point point)
        {
            this.point = point;
        }
        public IShape HouseDraw()
        {
            return new EgyptHouse(point);
        }
        public Point GetHousePoint()
        {
            return point;
        }
        public IShape TreeDraw()
        {
            return new EgyptTree(point);
        }
        public Point GetTreePoint()
        {
            return point;
        }

        public IShape WaterSourceDraw()
        {
            return new EgyptWaterResource(point);
        }
        public Point GetWaterSourcePoint()
        {
            return point;
        }
        public Color GetTerrainColor()
        {
            return Color.Yellow;
        }
    }
}
