using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class Line : IShape

    {
        private readonly Point point1;
        private readonly Point point2;
        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;

        }
        public void Draw(Graphics g)

        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, point1, point2);

        }

        public void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
