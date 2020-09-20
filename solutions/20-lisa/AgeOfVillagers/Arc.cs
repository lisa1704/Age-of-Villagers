using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        private float x;
        private float y;
        private float width;
        private float height;
        private float angle1;
        private float angle2;
        

        public Arc(float x,float y,float height, float width, float angle1, float angle2)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.angle1 = angle1;
            this.angle2 = angle2;

        }


        public void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawArc(pen, x, y, width, height, angle1, angle2);
        }

    }
}
