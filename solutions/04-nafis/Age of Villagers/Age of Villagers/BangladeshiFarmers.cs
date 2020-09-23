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
            throw new NotImplementedException();
        }
        public Point GetHousePoint()
        {
            return point;
        }
        public IShape TreeDraw()
        {
            throw new NotImplementedException();
        }

        public IShape WaterSourceDraw()
        {
            throw new NotImplementedException();
        }
    }
}
