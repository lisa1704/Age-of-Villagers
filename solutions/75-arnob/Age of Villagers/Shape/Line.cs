using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Line
    {
        private readonly Point _point1;
        private readonly Point _point2;

        public Line(Point point1, Point point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        public void Paint(Graphics graphics)
        {
            var pen = new Pen(Color.Black, 1);
            graphics.DrawLine(pen, _point1, _point2);
        }
    }
}
