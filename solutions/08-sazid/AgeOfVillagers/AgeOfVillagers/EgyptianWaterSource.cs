﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class EgyptianWaterSource : AdvancedShape
    {
        public EgyptianWaterSource(Point clickPoint)
        {
            Point point = new Point(clickPoint.X + 50, clickPoint.Y + 50 );
            addShape(new EllipseShape(clickPoint, point));
        }
    }
}