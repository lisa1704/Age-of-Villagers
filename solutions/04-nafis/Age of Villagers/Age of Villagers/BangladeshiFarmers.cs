using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Age_of_Villagers
{
    class BangladeshiFarmers : INation
    {
        private readonly Point point;

        public BangladeshiFarmers(Point point)
        {
            this.point = point;
        }
        public IShape HouseDraw()
        {
            return new BangladeshHouse(point);
        }
        public Point GetHousePoint()
        {
            return point;
        }
        public IShape TreeDraw()
        {
            throw new NotImplementedException();
        }
        public Point GetTreePoint()
        {
            return point;
        }

        public IShape WaterSourceDraw()
        {
            throw new NotImplementedException();
        }
        public Point GetWaterSourcePoint()
        {
            return point;
        }
    }
}
