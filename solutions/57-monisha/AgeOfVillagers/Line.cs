using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class Line : IShapeItem
    {
        private readonly Point point1;
        private readonly Point point2;

        public Line(Point pt1,Point pt2)
        {
            point1 = pt1;
            point2 = pt2;
        }
        public void Paint(Graphics g)
        {
            var pen = new Pen(Color.Black,1);
            g.DrawLine(pen, point1, point2);
        }
    }
}
