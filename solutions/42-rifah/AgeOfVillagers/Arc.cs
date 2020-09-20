﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Arc : IShape
    {
        public int x, y;
        private float width, height, StartAngle, SweepAngle;


        public Arc(int x, int y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.StartAngle = startAngle;
            this.SweepAngle = sweepAngle;
        }

        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, StartAngle, SweepAngle);
        }
    }

    public class Ellipse : Composite
    {
        private readonly Point TopLeft;
        private readonly Point BottomRight;

        public Ellipse(Point TopLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.BottomRight = BottomRight;
            AddComponent(new Arc(TopLeft.X, TopLeft.Y, BottomRight.X-TopLeft.X, BottomRight.Y-TopLeft.Y, 0, 360));
        }
    }
}