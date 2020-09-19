using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public class LineShape : IShape
    {
        private Point p1;
        private Point p2;

        public LineShape(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, p1, p2);
        }
    }
}
