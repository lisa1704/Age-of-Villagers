using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Arc : IShape
    {
        public float x, y, width, heigth, initialangle, sweepAngle;
        public Arc(float x, float y, float width, float heigth, float initialangle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.heigth = heigth;
            this.initialangle = initialangle;
            this.sweepAngle = sweepAngle;
        }

        public void Draw_Shape(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, heigth, initialangle, sweepAngle);
        }
    }
}
