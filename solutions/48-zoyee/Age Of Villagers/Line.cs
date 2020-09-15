using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Age_Of_Villagers
{
    class Line : IShape
    {
        private readonly Point point_1;
        private readonly Point point_2;

        public Line(Point point1, Point point2)
        {
            this.point_1 = point1;
            this.point_2 = point2;
        }
        public void Draw(Graphics g)
        {
            // throw new NotImplementedException();
            var my_pen = new Pen(Color.Black, 1);
            g.DrawLine(my_pen, point_1, point_2);
        }
    }
}
