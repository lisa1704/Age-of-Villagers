﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class Arc : IShapeIItem
    {
        private readonly Point point1;
        private readonly Point point2;
        public float x, y, width, heigth, initialangle, sweepAngle;
        public Arc(float x, float y, float width, float heigth,float initialangle,float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.heigth = heigth;
            this.initialangle = initialangle;
            this.sweepAngle = sweepAngle;
        }
            
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, heigth, initialangle, sweepAngle);
        }
    }
}
