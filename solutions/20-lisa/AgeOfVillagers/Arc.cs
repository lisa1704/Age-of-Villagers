using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        private readonly float x;
        private readonly float y;
        private readonly float w;
        private readonly float h;
        private readonly float angle1;
        private readonly float angle2;

        public Arc(float x, float y, float w, float h,float angle1, float angle2)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.angle1 = angle1;
            this.angle2 = angle2;

        }

        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawArc(pen, x, y, w, h, angle1, angle2);
        }

    }
}
