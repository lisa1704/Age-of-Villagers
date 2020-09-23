﻿using System;
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
        public Point GetTreePoint()
        {
            return point;
        }

        public IShape WaterSourceDraw()
        {
            throw new NotImplementedException();
        }
    }
}
