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


        public Arc(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, height, i_angle, s_angle);
        }
    }
}
