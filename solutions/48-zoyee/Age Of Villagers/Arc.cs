using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    class Arc : IShape
    {
        public float x, y, width, height, i_angle, s_angle;
        private readonly Point point1;
        private readonly Point point2;

        public Arc(float x, float y, float width, float heigth, float i_angle, float s_angle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = heigth;
            this.i_angle = i_angle;
            this.s_angle = s_angle;
        }
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, i_angle, s_angle);
        }
    }
}
