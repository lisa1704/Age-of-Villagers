﻿using System.Drawing;

namespace AgeOfVillagers
{
    class Arc : IShapeItem
    {
        private readonly Point point1;
        private readonly Point point2;
        private float x, y, width, height, startAngle, sweepAngle;
        

        public Arc(float x, float y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
        public void Paint(Graphics g,Pen p)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen,x, y, width, height, startAngle, sweepAngle);
        }
        public class Ellipse : CompositeShape
        {
            private readonly Point _topleft;
            private readonly Point _bottomright;

            public Ellipse(Point tLeft, Point bRight)
            {
                _topleft = tLeft;
                _bottomright = bRight;
                AddComp(new Arc(_topleft.X, _topleft.Y, _bottomright.X - _topleft.X, _bottomright.Y - _topleft.Y, 0, 360));
            }
        }
    }
}

