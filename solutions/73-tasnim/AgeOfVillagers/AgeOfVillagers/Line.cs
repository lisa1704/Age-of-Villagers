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
        private Point P1;
        private Point P2;

        public Line(Point P1, Point P2)
        {
            this.P1 = P1;
            this.P2 = P2;
        }
        public void Draw_Shape(Graphics g)
        {
            var pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, P1, P2);
        }
    }

}
