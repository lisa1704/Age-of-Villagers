using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_Villagers
{
    class line:IShape
    {
        private readonly Point point1;
        private readonly Point point2;
        public line(Point p1, Point p2)
        {
            this.point1 = p1;
            this.point2 = p2;
        }
        public void draw(Graphics g,Pen pen)
        {
            g.DrawLine(pen, point1, point2);
        }
    }
}
