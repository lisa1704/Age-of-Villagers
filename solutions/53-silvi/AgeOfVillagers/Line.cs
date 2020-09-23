using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Line : IShape
    {
        private readonly Point point_1;
        private readonly Point point_2;
        private object g;

        public Line(Point point1, Point point2)
        {
            this.point_1 = point1;
            this.point_2 = point2;
        }
        public void Draw()
        {
            var my_pen = new Pen(Color.Black, 1);
            g.DrawLine(my_pen, point_1, point_2);
        }
    }
}
