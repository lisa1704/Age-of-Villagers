﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BDWaterSource : CompositeShape
    {
        public BDWaterSource(Point MPt)
        {
            Point pt1 = new Point(MPt.X - 24, MPt.Y + 50);
            Point pt2 = new Point(MPt.X , MPt.Y + 75);
            Point pt3 = new Point(MPt.X + 25, MPt.Y +50);
            Point pt4 = new Point(MPt.X + 50, MPt.Y + 75);
            Point pt5 = new Point(MPt.X + 75, MPt.Y + 25);
            

            AddComp(new Line(MPt, pt1));
            AddComp(new Line(pt1, pt2));
            AddComp(new Line(pt2, pt3));
        }
    }

    class EgyptianWaterSource : CompositeShape
    {
        public EgyptianWaterSource(Point MPt)
        {
            Point pt1 = new Point(MPt.X - 24, MPt.Y + 50);
            Point pt2 = new Point(MPt.X, MPt.Y + 75);
        
                    
        }
    }
}
