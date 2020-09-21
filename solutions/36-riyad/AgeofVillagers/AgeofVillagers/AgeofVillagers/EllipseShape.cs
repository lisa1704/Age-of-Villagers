﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeofVillagers
{
    public class EllipseShape : CompositeShape
    {
        public Point leftTop;
        public Point rightBottom;

        public EllipseShape(Point Left, Point Right)
        {
            leftTop = Left;
            rightBottom = Right;
            AddComponents(new Arc(leftTop.X, leftTop.Y, rightBottom.X - leftTop.X, rightBottom.Y - leftTop.Y, 0, 360));
        }
    }
}
