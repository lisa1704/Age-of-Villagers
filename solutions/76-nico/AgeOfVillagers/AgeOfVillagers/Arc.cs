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
        private readonly Point point1;
        private readonly Point point2;
        public int x, y, width, heigth, initialngle, sweepAngle;
        public Arc(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public void draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawArc(pen, x, y, width, heigth, initialngle, sweepAngle);
        }
    }
}
