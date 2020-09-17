﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class InuitHuntersHouse : CompositeShape
    {
        private Point point;

        public InuitHuntersHouse(Point point)
        {
            addShape(new BaseArc(point, 24, 24));
        }
    }
}
