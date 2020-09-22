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
        IShape INation.HouseDraw()
        {
            throw new NotImplementedException();
        }

        IShape INation.TreeDraw()
        {
            throw new NotImplementedException();
        }

        IShape INation.WaterSourceDraw()
        {
            throw new NotImplementedException();
        }
    }
}
