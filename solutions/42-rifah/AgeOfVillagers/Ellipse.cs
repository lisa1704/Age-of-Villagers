﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Ellipse : Composite
    {
        public Ellipse(Point TopLeft, Point BottomRight)
        {
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y, 0, 360));
        }
    }
}
