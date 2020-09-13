using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    class Line : IShapeIItem
    {
        private readonly Point point1;
        private readonly Point point2;

        public Line(Point p1, Point p2)
        {
            point1 = p1;
            point2 = p2;
        }
        public void Draw(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, point1, point2);
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
